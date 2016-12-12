using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using AEMManager.Util;

namespace AEMManager {

  static class Program {

    private static readonly log4net.ILog mLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static NotifyIcon NotifyIcon = null;
    public static AemManager AemManagerForm = null;
    public static MenuItem ShowInTaskbarContextMenu = null;
    public static AemInstanceList InstanceList;

    private static ContextMenu mContextMenu = null;
    private static Mutex mStartupMutex = null;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {

      // initialize app
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
      Application.ThreadExit += new EventHandler(Application_ThreadExit);
      Control.CheckForIllegalCrossThreadCalls = false;

      // Check if instance of AEM manager is already running
      bool fFirstInstance;
      mStartupMutex = new Mutex(false, "AEMManager_Mutex@@1", out fFirstInstance);
      if (!fFirstInstance) {
        MessageBox.Show("AEM Manager already started.", "AEM Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        mStartupMutex.Close();
        Application.Exit();
        return;
      }

      // check if registry settings should be migrated
      RegistryMigration.CheckForLegacyRegistrySettings();

      // initialice tray icon
      InitializeNotifyIcon();

      // run application main thread
      Program.AemManagerForm = new AemManager();
      Program.AemManagerForm.Visible = false;
      Application.Run(Program.AemManagerForm);
    }

    private static void InitializeNotifyIcon() {
      // initialize tray icon
      Program.NotifyIcon = new NotifyIcon();
      Program.NotifyIcon.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);
      Program.NotifyIcon.Text = "AEM Manager";

      string trayIcon = "trayicon_default.ico";
      string iconset = IconSet.DEFAULT.ToString().ToLower();
      Program.NotifyIcon.Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream("AEMManager.resources." + iconset + "." + trayIcon));

      // main context menu
      List<MenuItem> menuItems = new List<MenuItem>();
      MenuItem item;

      item = new MenuItem("&Show in Taskbar");
      menuItems.Add(item);
      Program.ShowInTaskbarContextMenu = item;

      item = new MenuItem("-");
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Info...";
      item.Click += new EventHandler(ContextMenu_Info);
      menuItems.Add(item);

      item = new MenuItem("-");
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "AEM Documentation";
      item.Click += new EventHandler(AEMDocumentation_Click);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "AEM Reference Materials";
      item.Click += new EventHandler(AEMRefDocs_Click);
      menuItems.Add(item);

      item = new MenuItem("-");
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "&Open Manager";
      item.Click += new EventHandler(ContextMenu_Open);
      item.DefaultItem = true;
      menuItems.Add(item);

      item = new MenuItem("&Close Manager", new EventHandler(ContextMenu_Close));
      menuItems.Add(item);

      mContextMenu = new ContextMenu(menuItems.ToArray());

      Program.NotifyIcon.ContextMenu = mContextMenu;
    }

    static void AEMDocumentation_Click(object sender, EventArgs e) {
      System.Diagnostics.Process p = new System.Diagnostics.Process();
      p.StartInfo.FileName = "https://docs.adobe.com/";
      p.Start();
    }

    static void AEMRefDocs_Click(object sender, EventArgs e) {
      System.Diagnostics.Process p = new System.Diagnostics.Process();
      p.StartInfo.FileName = "https://docs.adobe.com/docs/en/aem/6-2/develop/ref.html";
      p.Start();
    }

    static void ContextMenu_Info(object sender, EventArgs e) {
      InfoDialog dialog = new InfoDialog();
      dialog.StartPosition = FormStartPosition.CenterScreen;
      dialog.ShowDialog();
    }

    static void ContextMenu_Open(object sender, EventArgs e) {
      AemManagerForm.Show();
      AemManagerForm.Activate();
    }

    static void ContextMenu_Close(object sender, EventArgs e) {

      // hide all instance icons
      foreach (AemInstance instance in Program.InstanceList) {
        instance.NotifyIcon.Visible = false;
      }

      AemManagerForm.Close();
      Application.Exit();
    }

    static void NotifyIcon_DoubleClick(object sender, EventArgs e) {
      ContextMenu_Open(sender, e);
    }

    /// <summary>
    /// Instance to execute actions upon
    /// </summary>
    public static AemInstance GetActionInstance(Object pSender) {
      AemInstance instance = null;
      if (pSender is AemInstance) {
        instance = (AemInstance)pSender;
      }
      else if (pSender is MenuItem) {
        instance = (AemInstance)((MenuItem)pSender).Tag;
      }
      if (instance == null && Program.AemManagerForm.Visible) {
        instance = Program.AemManagerForm.SelectedInstanceInListview;
      }
      return instance;
    }

    public static void UpdateInstanceListInViews() {
      // update list in manager form
      Program.AemManagerForm.UpdateInstanceListView();

      Program.ShowInTaskbarContextMenu.MenuItems.Clear();
      foreach (AemInstance instance in Program.InstanceList) {
        MenuItem menuItem = new MenuItem(instance.Name);
        menuItem.Checked = instance.ShowInTaskbar;
        menuItem.Tag = instance;
        menuItem.Click += new EventHandler(ShowInTaskbarMenuItem_Click);
        Program.ShowInTaskbarContextMenu.MenuItems.Add(menuItem);
      }
    }

    static void ShowInTaskbarMenuItem_Click(object sender, EventArgs e) {
      MenuItem menuItem = (MenuItem)sender;
      AemInstance selectedInstance = (AemInstance)menuItem.Tag;
      selectedInstance.ShowInTaskbar = !selectedInstance.ShowInTaskbar;
      selectedInstance.Save();
      Program.UpdateInstanceListInViews();
    }

    private static void Application_ThreadException(object pSender, ThreadExceptionEventArgs pArgs) {
      mLog.Error("Application error.", pArgs.Exception);
      MessageBox.Show(pArgs.Exception.Message + "\n\n" + pArgs.Exception.StackTrace, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    static void Application_ThreadExit(object sender, EventArgs e) {
      // automatically stop instances that are still running on exit
      try {
        if (Program.InstanceList != null) {
          foreach (AemInstance instance in Program.InstanceList) {
            Process process = instance.GetInstanceJavaProcess();
            if (process != null && !process.HasExited) {
              try {
                AemActions.StopInstance(instance);
                instance.NotifyIcon.Visible = false;
                instance.NotifyIcon.Dispose();
                instance.NotifyIcon = null;
              }
              catch (Exception ex) {
                mLog.Error("Error stopping instance '" + instance.Name + "'.", ex);
              }
            }
          }
        }
      }
      catch (Exception ex) {
        mLog.Error("Error checking for running instances or application shutdown.", ex);
      }
    }

  }

}
