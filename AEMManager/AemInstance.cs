using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using AEMManager.Util;
using System.Net;

namespace AEMManager {

  public class AemInstance {

    private static readonly log4net.ILog mLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static readonly int DEFAULT_PORT = 4502;
    public static readonly int DEFAULT_HEAP_MIN_MB = 128;
    public static readonly int DEFAULT_HEAP_MAX_MB = 1024;
    public static readonly int DEFAULT_PERMSIZE_MB = 256;
    public static readonly int DEFAULT_JPROFILER_PORT = 8849;
    public static readonly int DEFAULT_JCONSOLE_PORT = 9999;

    private string mId;
    private AemInstanceType mAemInstanceType = AemInstanceType.AEM55;
    private string mName = "";
    private string mHostname = "localhost";
    private int mPort = DEFAULT_PORT;
    private string mContextPath = "/";
    private string mPath = "";
    private string mJavaExecutable = "java";
    private string mUsername = "admin";
    private string mPassword = "admin";
    private Runmode mRunmode = Runmode.AUTHOR;
    private bool mRunmodeSampleContent = false;
    private string mAdditionalRunmodes = "";
    private IconSet mIconSet = IconSet.DEFAULT;
    private string mCustomIconPath = "";
    private bool mShowInTaskbar = true;
    private int mHeapMinSizeMb = DEFAULT_HEAP_MIN_MB;
    private int mHeapMaxSizeMb = DEFAULT_HEAP_MAX_MB;
    private int mMaxPermSizeMb = DEFAULT_PERMSIZE_MB;
    private bool mJVMDebug = false;
    private int mDebugPort = 0;
    private bool mJProfiler = false;
    private int mJProfilerPort = DEFAULT_JPROFILER_PORT;
    private bool mJConsole = false;
    private int mJConsolePort = DEFAULT_JCONSOLE_PORT;
    private bool mHideConfigWizard = true;
    private bool mShowInstanceWindow = false;
    private bool mOpenBrowser = false;
    private bool mRemoteProcess = false;
    private bool mCustomJVMParam1Active = false;
    private string mCustomJVMParam1 = "";
    private bool mCustomJVMParam2Active = false;
    private string mCustomJVMParam2 = "";
    private bool mCustomJVMParam3Active = false;
    private string mCustomJVMParam3 = "";
    private string mBrowserExecutable = "";

    // variables not saved in registry, but used for process/status management
    private Process mJavaProcess;
    private bool mJavaProcessVisible;
    private BundleStatus mCurrentBundleStatus = BundleStatus.NO_ACTIVE_INSTANCE;
    private BundleStatus mLastBundleStatus = BundleStatus.NO_ACTIVE_INSTANCE;
    private DateTime mLastBundleStatusChange = DateTime.MinValue;
    private bool mBundleStatusRunningReported = false;
    private NotifyIcon mNotifyIcon;
    private readonly ConsoleWindow mConsoleOutputWindow;


    public AemInstance() {
      mId = Guid.NewGuid().ToString();
      mConsoleOutputWindow = new ConsoleWindow(this);
      InitializeNotifyIcon();
    }

    public string Id {
      get {
        return mId;
      }
    }

    public AemInstanceType AemInstanceType {
      get {
        return mAemInstanceType;
      }
      set {
        mAemInstanceType = value;
        InitializeNotifyIcon();
      }
    }

    public string Name {
      get {
        return mName;
      }
      set {
        mName = value;
        InitializeNotifyIcon();
      }
    }

    public string Hostname {
      get {
        return mHostname;
      }
      set {
        mHostname = value;
      }
    }

    public int Port {
      get {
        return mPort;
      }
      set {
        mPort = value;
      }
    }

    public string ContextPath {
      get {
        return mContextPath;
      }
      set {
        mContextPath = value;
      }
    }

    public string Path {
      get {
        return mPath;
      }
      set {
        mPath = value;
      }
    }

    public string JavaExecutable {
      get {
        return mJavaExecutable;
      }
      set {
        mJavaExecutable = value;
      }
    }

    public string Username {
      get {
        return mUsername;
      }
      set {
        mUsername = value;
      }
    }

    public string Password {
      get {
        return mPassword;
      }
      set {
        mPassword = value;
      }
    }

    public Runmode Runmode {
      get {
        return mRunmode;
      }
      set {
        mRunmode = value;
      }
    }

    public bool RunmodeSampleContent {
      get {
        return mRunmodeSampleContent;
      }
      set {
        mRunmodeSampleContent = value;
      }
    }

    public string AdditionalRunmodes {
      get {
        return mAdditionalRunmodes;
      }
      set {
        mAdditionalRunmodes = value;
      }
    }

    public IconSet IconSet {
      get {
        return mIconSet;
      }
      set {
        mIconSet = value;
      }
    }

    public string CustomIconPath {
      get {
        return mCustomIconPath;
      }
      set {
        mCustomIconPath = value;
      }
    }

    public string PathWithoutFilename {
      get {
        int pos = mPath.LastIndexOf("\\");
        if (pos >= 0) {
          return mPath.Substring(0,pos);
        }
        else {
          return mPath;
        }
      }
    }

    public string PathFilename {
      get {
        int pos = mPath.LastIndexOf("\\");
        if (pos >= 0) {
          return mPath.Substring(pos+1);
        }
        else {
          return mPath;
        }
      }
    }

    public bool ShowInTaskbar {
      get {
        return mShowInTaskbar;
      }
      set {
        mShowInTaskbar = value;
        InitializeNotifyIcon();
      }
    }

    public int HeapMinSizeMb {
      get {
        return mHeapMinSizeMb;
      }
      set {
        mHeapMinSizeMb = value;
      }
    }

    public int HeapMaxSizeMb {
      get {
        return mHeapMaxSizeMb;
      }
      set {
        mHeapMaxSizeMb = value;
      }
    }

    public int MaxPermSizeMb {
      get {
        return mMaxPermSizeMb;
      }
      set {
        mMaxPermSizeMb = value;
      }
    }

    public bool JVMDebug {
      get {
        return mJVMDebug;
      }
      set {
        mJVMDebug = value;
      }
    }

    public int DebugPort {
      get {
        return mDebugPort;
      }
      set {
        mDebugPort = value;
      }
    }

    public bool JProfiler {
      get {
        return mJProfiler;
      }
      set {
        mJProfiler = value;
      }
    }

    public int JProfilerPort {
      get {
        return mJProfilerPort;
      }
      set {
        mJProfilerPort = value;
      }
    }

    public bool JConsole {
      get {
        return mJConsole;
      }
      set {
        mJConsole = value;
      }
    }

    public int JConsolePort {
      get {
        return mJConsolePort;
      }
      set {
        mJConsolePort = value;
      }
    }

    public bool HideConfigWizard {
      get {
        return mHideConfigWizard;
      }
      set {
        mHideConfigWizard = value;
      }
    }

    public bool ShowInstanceWindow {
      get {
        return mShowInstanceWindow;
      }
      set {
        mShowInstanceWindow = value;
      }
    }

    public bool OpenBrowser {
      get {
        return mOpenBrowser;
      }
      set {
        mOpenBrowser = value;
      }
    }

    public bool RemoteProcess {
      get {
        return mRemoteProcess;
      }
      set {
        mRemoteProcess = value;
      }
    }

    public bool CustomJVMParam1Active {
      get {
        return mCustomJVMParam1Active;
      }
      set {
        mCustomJVMParam1Active = value;
      }
    }

    public string CustomJVMParam1 {
      get {
        return mCustomJVMParam1;
      }
      set {
        mCustomJVMParam1 = value;
      }
    }

    public bool CustomJVMParam2Active {
      get {
        return mCustomJVMParam2Active;
      }
      set {
        mCustomJVMParam2Active = value;
      }
    }

    public string CustomJVMParam2 {
      get {
        return mCustomJVMParam2;
      }
      set {
        mCustomJVMParam2 = value;
      }
    }

    public bool CustomJVMParam3Active {
      get {
        return mCustomJVMParam3Active;
      }
      set {
        mCustomJVMParam3Active = value;
      }
    }

    public string CustomJVMParam3 {
      get {
        return mCustomJVMParam3;
      }
      set {
        mCustomJVMParam3 = value;
      }
    }

    public string BrowserExecutable {
      get {
        return mBrowserExecutable;
      }
      set {
        mBrowserExecutable = value;
      }
    }

    public string UrlWithContextPath {
      get {
        string url = "http://" + mHostname + ":" + mPort;
        if (!string.IsNullOrEmpty(mContextPath)) {
          url += mContextPath;
        }
        if (url.EndsWith("/")) {
          url = url.Substring(0, url.Length - 1);
        }
        return url;
      }
    }

    public string UrlWithoutContextPath {
      get {
        return "http://" + mHostname + ":" + mPort;
      }
    }

    public Process JavaProcess {
      get {
        return mJavaProcess;
      }
      set {
        mJavaProcess = value;
      }
    }

    public bool JavaProcessVisible {
      get {
        return mJavaProcessVisible;
      }
      set {
        mJavaProcessVisible = value;
      }
    }

    public NotifyIcon NotifyIcon {
      get {
        return mNotifyIcon;
      }
      set {
        mNotifyIcon = value;
      }
    }

    public BundleStatus CurrentBundleStatus {
      get {
        return mCurrentBundleStatus;
      }
    }

    private void InitializeNotifyIcon() {
      if (mNotifyIcon == null) {
        mNotifyIcon = new NotifyIcon();

        mNotifyIcon.DoubleClick += new EventHandler(mNotifyIcon_DoubleClick);
      }

      ContextMenu contextMenu = new ContextMenu();

      MenuItem nameMenuItem = new MenuItem(this.Name + " (" + AemInstanceTypeUtil.GetLabel(this.AemInstanceType) + ")");
      nameMenuItem.Enabled = false;
      contextMenu.MenuItems.Add(nameMenuItem);

      contextMenu.MenuItems.Add(new MenuItem("-"));
      AemActions.AddControlMenuItems(contextMenu.MenuItems, this);

      contextMenu.MenuItems.Add(new MenuItem("-"));
      AemActions.AddLogMenuItems(contextMenu.MenuItems, this);

      contextMenu.MenuItems.Add(new MenuItem("-"));
      AemActions.AddOpenMenuItems(contextMenu.MenuItems, this, true);

      contextMenu.MenuItems.Add(new MenuItem("-"));
      contextMenu.MenuItems.Add(new MenuItem("Properties", propertiesMenuItem_Click));

      this.NotifyIcon.ContextMenu = contextMenu;

      mNotifyIcon.Text = this.Name;
      mNotifyIcon.Visible = this.ShowInTaskbar;

      string trayIcon = "trayicon_disabled";
      mNotifyIcon.Icon = IconCache.GetIcon(this.IconSet, this.CustomIconPath, trayIcon);
    }

    void propertiesMenuItem_Click(object sender, EventArgs e) {
      AemInstanceDialog dialog = new AemInstanceDialog(this);
      dialog.StartPosition = FormStartPosition.CenterScreen;
      if (dialog.ShowDialog() == DialogResult.OK) {
        this.Save();
        Program.InstanceList.SortByName();
        Program.UpdateInstanceListInViews();
      }
    }

    void mNotifyIcon_DoubleClick(object sender, EventArgs e) {
      AemActions.OpenAuthorPublish(this, e);
    }

    /// <summary>
    /// Updates tooltip text and icon of tray icon
    /// </summary>
    public void UpdateNofiyIconText(BundleStatus pBundleStatus) {
      mCurrentBundleStatus = pBundleStatus;

      string trayIcon = "trayicon_default";
      string statusText = "";
      switch (pBundleStatus) {
        case BundleStatus.NO_ACTIVE_INSTANCE:
          trayIcon = "trayicon_default";
          break;
        case BundleStatus.DISABLED:
          trayIcon = "trayicon_disabled";
          statusText = "not running";
          break;
        case BundleStatus.UNKNOWN:
          trayIcon = "trayicon_unknown";
          statusText = "server starting/stopping";
          break;
        case BundleStatus.STARTING_STOPPING:
          trayIcon = "trayicon_starting";
          statusText = "bundles starting/stopping";
          break;
        case BundleStatus.RUNNING:
          trayIcon = "trayicon_running";
          statusText = "running";
          break;
      }

      this.NotifyIcon.Text = this.Name + " (" + statusText + ")";
      this.NotifyIcon.Icon = IconCache.GetIcon(this.IconSet, this.CustomIconPath, trayIcon);

      // show baloon message if instance was started up
      if (mLastBundleStatus!=pBundleStatus) {
        mLastBundleStatus = pBundleStatus;
        mLastBundleStatusChange = DateTime.Now;
        if (pBundleStatus == BundleStatus.RUNNING) {
          mBundleStatusRunningReported = false;
        }
      }
      if (pBundleStatus == BundleStatus.RUNNING
          && !mBundleStatusRunningReported
          && (DateTime.Now.Subtract(mLastBundleStatusChange).TotalMilliseconds > AEMManager.Properties.Settings.Default.ReportStatusChangeTimeout)) {
        mBundleStatusRunningReported = true;
        ShowNotfiyIconMessage("AEM instance is ready.", ToolTipIcon.Info);
      }
    }

    private void ShowNotfiyIconMessage(string pMessage, ToolTipIcon pIcon) {
      this.NotifyIcon.ShowBalloonTip(3, this.Name, pMessage, pIcon);
    }

    public AemInstance(RegistryKey pKey) {
      mConsoleOutputWindow = new ConsoleWindow(this);

      mId = pKey.Name.Substring(pKey.Name.LastIndexOf("\\") + 1);
      mAemInstanceType = (AemInstanceType)Enum.Parse(typeof(AemInstanceType), (string)pKey.GetValue("AemInstanceType", mAemInstanceType.ToString()), true);
      mName = (string)pKey.GetValue("Name", mName);
      mHostname = (string)pKey.GetValue("Hostname", mHostname);
      mPort = (int)pKey.GetValue("Port", mPort);
      mContextPath = (string)pKey.GetValue("ContextPath", mContextPath);
      mPath = (string)pKey.GetValue("Path", mPath);
      mJavaExecutable = (string)pKey.GetValue("JavaExecutable", mJavaExecutable);
      mUsername = (string)pKey.GetValue("Username", mUsername);
      mPassword = (string)pKey.GetValue("Password", mPassword);
      mRunmode = (Runmode)Enum.Parse(typeof(Runmode), (string)pKey.GetValue("Runmode", mRunmode.ToString()), true);
      mAdditionalRunmodes = (string)pKey.GetValue("AdditionalRunmodes", mAdditionalRunmodes);
      mRunmodeSampleContent = ((int)pKey.GetValue("RunmodeSampleContent", mRunmodeSampleContent ? 1 : 0)) != 0;
      mIconSet = (IconSet)Enum.Parse(typeof(IconSet), (string)pKey.GetValue("IconSet", mIconSet.ToString()), true);
      mCustomIconPath = (string)pKey.GetValue("CustomIconPath", mCustomIconPath);
      mShowInTaskbar = ((int)pKey.GetValue("ShowInTaskbar", mShowInTaskbar ? 1 : 0)) != 0;
      mHeapMinSizeMb = (int)pKey.GetValue("HeapMinSizeMb", mHeapMinSizeMb);
      mHeapMaxSizeMb = (int)pKey.GetValue("HeapMaxSizeMb", mHeapMaxSizeMb);
      mMaxPermSizeMb = (int)pKey.GetValue("MaxPermSizeMb", mMaxPermSizeMb);
      mJVMDebug = ((int)pKey.GetValue("JVMDebug", mJVMDebug ? 1 : 0)) != 0;
      mDebugPort = (int)pKey.GetValue("DebugPort", mDebugPort);
      mJProfiler = ((int)pKey.GetValue("JProfiler", mJProfiler ? 1 : 0)) != 0;
      mJProfilerPort = (int)pKey.GetValue("JProfilerPort", mJProfilerPort);
      mJConsole = ((int)pKey.GetValue("JConsole", mJConsole ? 1 : 0)) != 0;
      mJConsolePort = (int)pKey.GetValue("JConsolePort", mJConsolePort);
      mHideConfigWizard = ((int)pKey.GetValue("HideConfigWizard", mHideConfigWizard ? 1 : 0)) != 0;
      mShowInstanceWindow = ((int)pKey.GetValue("ShowInstanceWindow", mShowInstanceWindow ? 1 : 0)) != 0;
      mOpenBrowser = ((int)pKey.GetValue("OpenBrowser", mOpenBrowser ? 1 : 0)) != 0;
      mRemoteProcess = ((int)pKey.GetValue("RemoteProcess", mRemoteProcess ? 1 : 0)) != 0;
      mCustomJVMParam1Active = ((int)pKey.GetValue("CustomJVMParam1Active", mCustomJVMParam1Active ? 1 : 0)) != 0;
      mCustomJVMParam1 = (string)pKey.GetValue("CustomJVMParam1", mCustomJVMParam1);
      mCustomJVMParam2Active = ((int)pKey.GetValue("CustomJVMParam2Active", mCustomJVMParam2Active ? 1 : 0)) != 0;
      mCustomJVMParam2 = (string)pKey.GetValue("CustomJVMParam2", mCustomJVMParam2);
      mCustomJVMParam3Active = ((int)pKey.GetValue("CustomJVMParam3Active", mCustomJVMParam3Active ? 1 : 0)) != 0;
      mCustomJVMParam3 = (string)pKey.GetValue("CustomJVMParam3", mCustomJVMParam3);
      mBrowserExecutable = (string)pKey.GetValue("BrowserExecutable", mBrowserExecutable);
      InitializeNotifyIcon();
    }

    public void Save() {
      RegistryKey instancesKey = RegistryUtil.GetUserKey("Instances");

      RegistryKey key = instancesKey.OpenSubKey(mId, true);
      if (key == null) {
        key = instancesKey.CreateSubKey(mId);
      }

      key.SetValue("AemInstanceType", mAemInstanceType.ToString());
      key.SetValue("Name", mName);
      key.SetValue("Hostname", mHostname);
      key.SetValue("Port", mPort);
      key.SetValue("ContextPath", mContextPath);
      key.SetValue("Path", mPath);
      key.SetValue("JavaExecutable", mJavaExecutable);
      key.SetValue("Username", mUsername);
      key.SetValue("Password", mPassword);
      key.SetValue("Runmode", mRunmode.ToString());
      key.SetValue("AdditionalRunmodes", mAdditionalRunmodes);
      key.SetValue("RunmodeSampleContent", mRunmodeSampleContent ? 1 : 0);
      key.SetValue("IconSet", mIconSet.ToString());
      key.SetValue("CustomIconPath", mCustomIconPath.ToString());
      key.SetValue("ShowInTaskbar", mShowInTaskbar ? 1 : 0);
      key.SetValue("HeapMinSizeMb", mHeapMinSizeMb);
      key.SetValue("HeapMaxSizeMb", mHeapMaxSizeMb);
      key.SetValue("MaxPermSizeMb", mMaxPermSizeMb);
      key.SetValue("JVMDebug", mJVMDebug ? 1 : 0);
      key.SetValue("DebugPort", mDebugPort);
      key.SetValue("JProfiler", mJProfiler ? 1 : 0);
      key.SetValue("JProfilerPort", mJProfilerPort);
      key.SetValue("JConsole", mJConsole ? 1 : 0);
      key.SetValue("JConsolePort", mJConsolePort);
      key.SetValue("HideConfigWizard", mHideConfigWizard ? 1 : 0);
      key.SetValue("ShowInstanceWindow", mShowInstanceWindow ? 1 : 0);
      key.SetValue("OpenBrowser", mOpenBrowser ? 1 : 0);
      key.SetValue("RemoteProcess", mRemoteProcess ? 1 : 0);
      key.SetValue("CustomJVMParam1Active", mCustomJVMParam1Active ? 1 : 0);
      key.SetValue("CustomJVMParam1", mCustomJVMParam1);
      key.SetValue("CustomJVMParam2Active", mCustomJVMParam2Active ? 1 : 0);
      key.SetValue("CustomJVMParam2", mCustomJVMParam2);
      key.SetValue("CustomJVMParam3Active", mCustomJVMParam3Active ? 1 : 0);
      key.SetValue("CustomJVMParam3", mCustomJVMParam3);
      key.SetValue("BrowserExecutable", mBrowserExecutable);

    }

    public string Validate() {

      if (string.IsNullOrEmpty(mName)) {
        return "Please enter a name.";
      }
      if (string.IsNullOrEmpty(mHostname)) {
        return "Please enter a host name.";
      }
      if (mPort<=0) {
        return "Please enter a valid port number.";
      }
      if (string.IsNullOrEmpty(mPath)) {
        return "Please enter a path.";
      }
      if (string.IsNullOrEmpty(mUsername)) {
        return "Please enter a user name.";
      }
      if (string.IsNullOrEmpty(mPassword)) {
        return "Please enter a password.";
      }

      return null;
    }

    public AemInstance Clone() {
      AemInstance clone = new AemInstance();

      clone.mAemInstanceType = mAemInstanceType;
      clone.mName = mName;
      clone.mHostname = mHostname;
      clone.mPort = mPort;
      clone.mContextPath = mContextPath;
      clone.mPath = mPath;
      clone.mJavaExecutable = mJavaExecutable;
      clone.mUsername = mUsername;
      clone.mPassword = mPassword;
      clone.mRunmode = mRunmode;
      clone.mAdditionalRunmodes = mAdditionalRunmodes;
      clone.mRunmodeSampleContent = mRunmodeSampleContent;
      clone.mIconSet = mIconSet;
      clone.mCustomIconPath = mCustomIconPath;
      clone.mShowInTaskbar = mShowInTaskbar;
      clone.mHeapMinSizeMb = mHeapMinSizeMb;
      clone.mHeapMaxSizeMb = mHeapMaxSizeMb;
      clone.mMaxPermSizeMb = mMaxPermSizeMb;
      clone.mJVMDebug = mJVMDebug;
      clone.mDebugPort = mDebugPort;
      clone.mJProfiler = mJProfiler;
      clone.mJProfilerPort = mJProfilerPort;
      clone.mJConsole = mJConsole;
      clone.mJConsolePort = mJConsolePort;
      clone.mHideConfigWizard = mHideConfigWizard;
      clone.mShowInstanceWindow = mShowInstanceWindow;
      clone.mOpenBrowser = mOpenBrowser;
      clone.mRemoteProcess = mRemoteProcess;
      clone.mCustomJVMParam1Active = mCustomJVMParam1Active;
      clone.mCustomJVMParam1 = mCustomJVMParam1;
      clone.mCustomJVMParam2Active = mCustomJVMParam2Active;
      clone.mCustomJVMParam2 = mCustomJVMParam2;
      clone.mCustomJVMParam3Active = mCustomJVMParam3Active;
      clone.mCustomJVMParam3 = mCustomJVMParam3;
      clone.mBrowserExecutable = mBrowserExecutable;

      return clone;
    }

    public void Delete() {
      RegistryKey instancesKey = RegistryUtil.GetUserKey("Instances");
      instancesKey.DeleteSubKeyTree(mId);
    }

    public Process GetInstanceJavaProcess() {
      Process instanceProcess = null;

      try {

        // try to find matching process name
        /*
        -- this was supposed to support finding running instance again when AEM manager was stopped
        -- but this does not seem to work any longer, and even creates performance issues on some machines
        -- so, deactivate it for now
        foreach (Process process in Process.GetProcesses()) {
          if (process.MainWindowTitle.Equals(this.Name)
              || process.MainWindowTitle.EndsWith("\\" + this.Name + ".lnk")) {
            instanceProcess = process;
            break;
          }
        }
        */

        // if none found use process associated with instance
        if (instanceProcess == null) {
          instanceProcess = this.JavaProcess;
        }

        // check if process is still alive
        if (instanceProcess != null) {
          if (instanceProcess.HasExited) {
            instanceProcess = null;
            mJavaProcess = null;
          }
          else {
            instanceProcess.Refresh();
          }
        }

      }
      catch (InvalidOperationException ex) {
        mLog.Warn("Error checking process state of '" + this.Name + "'.", ex);
        instanceProcess = null;
        mJavaProcess = null;
      }

      return instanceProcess;
    }

    public string GetStatusText() {
      List<string> statusTexts = new List<string>();
      if (this.ShowInTaskbar) {
        statusTexts.Add("Taskbar");
      }
      Process process = this.GetInstanceJavaProcess();
      if (process != null && !process.HasExited) {
        statusTexts.Add("Started");
      }
      return string.Join(", ", statusTexts.ToArray());
    }

    public ConsoleWindow ConsoleOutputWindow {
      get {
        return mConsoleOutputWindow;
      }
    }

    /// <summary>
    /// Creates a web request with preemptive authentication.
    /// </summary>
    /// <param name="instance">AEM instance</param>
    /// <param name="url">URL</param>
    /// <returns></returns>
    public HttpWebRequest WebRequestCreate(string url) {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

      // "manual" preemptive authentication
      string authInfo = this.Username + ":" + this.Password;
      authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
      request.Headers["Authorization"] = "Basic " + authInfo;

      // default timeouts
      request.Timeout = AEMManager.Properties.Settings.Default.HttpTimeout;
      request.ReadWriteTimeout = AEMManager.Properties.Settings.Default.HttpTimeout;

      // disable keep alive
      request.KeepAlive = false;

      return request;
    }

  }

}
