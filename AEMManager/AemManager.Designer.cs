namespace AEMManager {
  partial class AemManager {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AemManager));
            this.timerStartup = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.setSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBundleStatus = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogJar = new System.Windows.Forms.OpenFileDialog();
            this.dgInstances = new System.Windows.Forms.DataGridView();
            this.timerStatusRefresh = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstances)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStartup
            // 
            this.timerStartup.Tick += new System.EventHandler(this.timerStartup_Tick);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.instancesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(705, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(129, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // instancesToolStripMenuItem
            // 
            this.instancesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.setSelectedToolStripMenuItem});
            this.instancesToolStripMenuItem.Name = "instancesToolStripMenuItem";
            this.instancesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.instancesToolStripMenuItem.Text = "&Instances";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addToolStripMenuItem.Text = "&Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editToolStripMenuItem.Text = "&Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem.Text = "&Duplicate...";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 6);
            // 
            // setSelectedToolStripMenuItem
            // 
            this.setSelectedToolStripMenuItem.Name = "setSelectedToolStripMenuItem";
            this.setSelectedToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.setSelectedToolStripMenuItem.Text = "&Set Selected";
            this.setSelectedToolStripMenuItem.Click += new System.EventHandler(this.setShowInTaskbarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.infoToolStripMenuItem.Text = "Inf&o...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // timerBundleStatus
            // 
            this.timerBundleStatus.Interval = 2000;
            this.timerBundleStatus.Tick += new System.EventHandler(this.timerBundleStatus_Tick);
            // 
            // openFileDialogJar
            // 
            this.openFileDialogJar.Filter = "JAR Files|*.jar|All files|*.*";
            this.openFileDialogJar.Title = "Select AEM JAR File";
            // 
            // dgInstances
            // 
            this.dgInstances.AllowUserToAddRows = false;
            this.dgInstances.AllowUserToDeleteRows = false;
            this.dgInstances.AllowUserToResizeRows = false;
            this.dgInstances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInstances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInstances.Location = new System.Drawing.Point(0, 24);
            this.dgInstances.MultiSelect = false;
            this.dgInstances.Name = "dgInstances";
            this.dgInstances.ReadOnly = true;
            this.dgInstances.RowHeadersWidth = 25;
            this.dgInstances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInstances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInstances.Size = new System.Drawing.Size(705, 206);
            this.dgInstances.TabIndex = 2;
            this.dgInstances.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgInstances_CellMouseDoubleClick);
            this.dgInstances.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgInstances_MouseClick);
            // 
            // timerStatusRefresh
            // 
            this.timerStatusRefresh.Enabled = true;
            this.timerStatusRefresh.Interval = 500;
            this.timerStatusRefresh.Tick += new System.EventHandler(this.timerStatusRefresh_Tick);
            // 
            // AemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 230);
            this.Controls.Add(this.dgInstances);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 194);
            this.Name = "AemManager";
            this.Text = "AEM Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AemManager_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AemManager_FormClosed);
            this.Load += new System.EventHandler(this.AemManager_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timerStartup;
    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem instancesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem setSelectedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.Timer timerBundleStatus;
    private System.Windows.Forms.OpenFileDialog openFileDialogJar;
    private System.Windows.Forms.DataGridView dgInstances;
    private System.Windows.Forms.Timer timerStatusRefresh;
  }
}

