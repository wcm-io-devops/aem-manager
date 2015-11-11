using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AEMManager.Util;

namespace AEMManager {

  public partial class AemManager : Form {

    private System.Timers.Timer timerBundleStatus;
    private System.Timers.Timer timerStatusRefresh;

    public AemManager() {
      InitializeComponent();
    }

    private void AemManager_Load(object sender, EventArgs e) {
      SystemUtil.RestoreWindowPos(this);

      // setup gridview
      dgInstances.AutoGenerateColumns = false;
      dgInstances.Columns.Add("Name", "Name");
      dgInstances.Columns.Add("Type", "Type");
      dgInstances.Columns.Add("URL", "URL");
      dgInstances.Columns.Add("Path", "Path");
      dgInstances.Columns.Add("Status", "Status");
      foreach (DataGridViewColumn col in dgInstances.Columns) {
        col.DataPropertyName = col.Name;
      }

      Program.InstanceList = new AemInstanceList();
      Program.InstanceList.LoadFromRegistry();
      Program.UpdateInstanceListInViews();

      timerStartup.Enabled = true;

      timerStatusRefresh = new System.Timers.Timer();
      timerStatusRefresh.Interval = 1000;
      timerStatusRefresh.Elapsed += timerStatusRefresh_Tick;
      timerStatusRefresh.Enabled = true;

      timerBundleStatus = new System.Timers.Timer();
      timerBundleStatus.Interval = AEMManager.Properties.Settings.Default.TrayIconRefreshInterval;
      timerBundleStatus.Elapsed += timerBundleStatus_Tick;
      timerBundleStatus.Enabled = true;
    }

    private void AemManager_FormClosed(object sender, FormClosedEventArgs e) {
      if (Program.NotifyIcon != null) {
        Program.NotifyIcon.Visible = false;
      }
    }

    private void AemManager_FormClosing(object sender, FormClosingEventArgs e) {
      SystemUtil.SaveWindowPos(this);
      if (e.CloseReason==CloseReason.UserClosing) {
        e.Cancel = true;
        this.Hide();
      }
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
      Application.Exit();
    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e) {
      InfoDialog dialog = new InfoDialog();
      dialog.ShowDialog(this);
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e) {
      if (openFileDialogJar.ShowDialog(this) == DialogResult.OK) {
        AemInstance instance = new AemInstance();

        // auto-detect some instance properties
        instance.Path = openFileDialogJar.FileName;
        string[] pathParts = instance.Path.Split('/', '\\');

        string jarFilename = pathParts[pathParts.Length-1];
        if (jarFilename.Contains("-publish") || instance.Path.Contains("/publish/")) {
          instance.Runmode = Runmode.PUBLISH;
        }
        else {
          instance.Runmode = Runmode.AUTHOR;
        }

        string[] fileParts = jarFilename.Split('-','.');
        foreach (string filePart in fileParts) {
          int port = 0;
          if (int.TryParse(filePart, out port)) {
            instance.Port = port;
          }
        }

        if (pathParts.Length > 4) {
          string name = pathParts[pathParts.Length - 2];
          if ("author".Equals(name) || "publish".Equals(name)) {
            name = pathParts[pathParts.Length - 3];
          }
          instance.Name = name;
        }


        AemInstanceDialog dialog = new AemInstanceDialog(instance);
        if (dialog.ShowDialog(this) == DialogResult.OK) {
          instance.Save();
          Program.InstanceList.Add(instance);
          Program.InstanceList.SortByName();
          Program.UpdateInstanceListInViews();
        }
      }

    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e) {
      AemInstance instance = this.SelectedInstanceInListview;
      if (instance == null) {
        return;
      }
      AemInstanceDialog dialog = new AemInstanceDialog(instance);
      if (dialog.ShowDialog(this) == DialogResult.OK) {
        instance.Save();
        Program.InstanceList.SortByName();
        Program.UpdateInstanceListInViews();
      }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
      AemInstance instance = this.SelectedInstanceInListview;
      if (instance == null) {
        return;
      }
      instance = instance.Clone();
      instance.Name = "Copy of " + instance.Name;
      AemInstanceDialog dialog = new AemInstanceDialog(instance);
      if (dialog.ShowDialog(this) == DialogResult.OK) {
        instance.Save();
        Program.InstanceList.Add(instance);
        Program.InstanceList.SortByName();
        Program.UpdateInstanceListInViews();
      }
      else {
        // remove instance icon because instance not saved
        instance.NotifyIcon.Visible = false;
        instance.NotifyIcon.Dispose();
        instance.NotifyIcon = null;
      }
    }

    private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
      AemInstance instance = this.SelectedInstanceInListview;
      if (instance == null) {
        return;
      }
      if (MessageBox.Show(this, "Instance '" + instance.Name + "' will be removed.", "Remove intance", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) {
        instance.NotifyIcon.Visible = false;
        instance.NotifyIcon.Dispose();
        instance.NotifyIcon = null;
        instance.Delete();
        Program.InstanceList.Remove(instance);
        Program.UpdateInstanceListInViews();
      }
    }

    private void setShowInTaskbarToolStripMenuItem_Click(object sender, EventArgs e) {
      AemInstance instance = this.SelectedInstanceInListview;
      if (instance == null) {
        return;
      }
      MenuItem menuItem = (MenuItem)sender;
      instance.ShowInTaskbar = !instance.ShowInTaskbar;
      menuItem.Checked = instance.ShowInTaskbar;
      instance.Save();
      Program.UpdateInstanceListInViews();
    }

    private void preferencesToolStripMenuItem_Click(object sender, EventArgs e) {
      PreferencesDialog dialog = new PreferencesDialog();
      dialog.ShowDialog(this);
    }

    private void timerStartup_Tick(object sender, EventArgs e) {
      timerStartup.Enabled = false;
      this.Hide();
      if (Program.NotifyIcon != null) {
        Program.NotifyIcon.Visible = true;
      }
    }

    private void timerBundleStatus_Tick(object sender, EventArgs e) {
      foreach (AemInstance instance in Program.InstanceList) {
        if (instance.ShowInTaskbar) {
          instance.UpdateNofiyIconText(AemActions.GetCombinedBundleStatus(instance));
        }
      }
    }

    public AemInstance SelectedInstanceInListview {
      get {
        DataGridViewRow gridRow = this.dgInstances.CurrentRow;
        if (gridRow == null) {
          return null;
        }
        DataRow row = (DataRow)((DataRowView)gridRow.DataBoundItem).Row;
        return (AemInstance)row["Instance"];
      }
    }

    public void UpdateInstanceListView() {
      AemInstance selectedInstance = this.SelectedInstanceInListview;

      DataTable dt = new DataTable();
      dt.Columns.Add("Instance", typeof(AemInstance));
      dt.Columns.Add("Name", typeof(string));
      dt.Columns.Add("Type", typeof(string));
      dt.Columns.Add("URL", typeof(string));
      dt.Columns.Add("Path", typeof(string));
      dt.Columns.Add("Status", typeof(string));

      foreach (AemInstance instance in Program.InstanceList) {
        DataRow row = dt.NewRow();
        row["Instance"] = instance;
        row["Name"] = instance.Name;
        row["Type"] = AemInstanceTypeUtil.GetLabel(instance.AemInstanceType);
        row["URL"] = instance.UrlWithContextPath;
        row["Path"] = instance.Path;
        row["Status"] = instance.GetStatusText();
        dt.Rows.Add(row);
      }

      dgInstances.DataSource = dt;

      foreach (DataGridViewRow gridRow in dgInstances.Rows) {
        DataRow row = (DataRow)((DataRowView)gridRow.DataBoundItem).Row;
        if (row["Instance"] == selectedInstance) {
          dgInstances.CurrentCell = gridRow.Cells[0];
          break;
        }
      }
    }

    private void dgInstances_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
      editToolStripMenuItem_Click(null, null);
    }

    private void dgInstances_MouseClick(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Right) {

        // select instance below mousepointer
        DataGridView.HitTestInfo hitTestInfo = this.dgInstances.HitTest(e.X, e.Y);
        if (hitTestInfo.RowIndex >= 0) {
          dgInstances.CurrentCell.Selected = false;
          dgInstances.CurrentCell = dgInstances[0, hitTestInfo.RowIndex];
        }

        AemInstance instance = this.SelectedInstanceInListview;
        if (instance == null) {
          return;
        }

        // Context-Menü initialisieren
        List<MenuItem> menuItems = new List<MenuItem>();
        MenuItem item;

        item = new MenuItem();
        item.Text = "&Add...";
        item.Click += new EventHandler(addToolStripMenuItem_Click);
        menuItems.Add(item);

        item = new MenuItem();
        item.Text = "&Edit...";
        item.DefaultItem = true;
        item.Click += new EventHandler(editToolStripMenuItem_Click);
        menuItems.Add(item);

        item = new MenuItem();
        item.Text = "&Duplicate...";
        item.Click += new EventHandler(copyToolStripMenuItem_Click);
        menuItems.Add(item);

        item = new MenuItem();
        item.Text = "&Remove";
        item.Click += new EventHandler(removeToolStripMenuItem_Click);
        menuItems.Add(item);

        item = new MenuItem();
        item.Text = "-";
        menuItems.Add(item);

        item = new MenuItem();
        item.Text = "&Show in Taskbar";
        item.Click += new EventHandler(setShowInTaskbarToolStripMenuItem_Click);
        item.Checked = instance.ShowInTaskbar;
        menuItems.Add(item);

        dgInstances.ContextMenu = new ContextMenu(menuItems.ToArray());

        dgInstances.ContextMenu.MenuItems.Add("-");
        AemActions.AddControlMenuItems(dgInstances.ContextMenu.MenuItems, instance);

        dgInstances.ContextMenu.MenuItems.Add("-");
        AemActions.AddOpenMenuItems(dgInstances.ContextMenu.MenuItems, instance, false);

        dgInstances.ContextMenu.MenuItems.Add("-");
        AemActions.AddLogMenuItems(dgInstances.ContextMenu.MenuItems, instance);

        dgInstances.ContextMenu.Show(dgInstances, e.Location);
      }
    }

    private void timerStatusRefresh_Tick(object sender, EventArgs e) {
      if (!this.Visible) {
        return;
      }
      foreach (DataGridViewRow gridRow in dgInstances.Rows) {
        DataRow row = (DataRow)((DataRowView)gridRow.DataBoundItem).Row;
        AemInstance instance = (AemInstance)row["Instance"];
        row["Status"] = instance.GetStatusText();
      }
    }

  }

}
