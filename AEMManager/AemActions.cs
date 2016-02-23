using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using AEMManager.Util;

namespace AEMManager {

  class AemActions {

    private static readonly log4net.ILog mLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    // utility class only
    private AemActions() { }

    public static void AddOpenMenuItems(Menu.MenuItemCollection pParent, AemInstance pInstance, bool pSetDefaultItem) {
      List<MenuItem> menuItems = new List<MenuItem>();
      MenuItem item;

      item = new MenuItem();
      item.Text = "Open Author/Publish";
      item.Click += new EventHandler(OpenAuthorPublish);
      if (pSetDefaultItem) {
        item.DefaultItem = true;
      }
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Open CRX";
      item.Click += new EventHandler(OpenCRX);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Open CRX Content Explorer";
      item.Click += new EventHandler(OpenCRXContentExplorer);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Open CRXDE Lite";
      item.Click += new EventHandler(OpenCRXDE);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Open Felix Console";
      item.Click += new EventHandler(OpenFelixConsole);
      menuItems.Add(item);

      if (pInstance.AemInstanceType == AemInstanceType.AEM54) {
        item = new MenuItem();
        item.Text = "Open Servlet Engine Admin";
        item.Click += new EventHandler(OpenServletEngineAdmin);
        menuItems.Add(item);
      }

      foreach (MenuItem i in menuItems) {
        i.Tag = pInstance;
      }

      pParent.AddRange(menuItems.ToArray());
    }

    public static void OpenAuthorPublish(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenUrl(instance.UrlWithContextPath, instance);
    }

    private static void OpenCRX(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      string url = instance.UrlWithContextPath + "/crx/explorer/";
      if (instance.AemInstanceType == AemInstanceType.AEM54) {
        url = instance.UrlWithoutContextPath + "/crx/";
      }
      OpenUrl(url, instance);
    }

    private static void OpenCRXContentExplorer(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      string url = instance.UrlWithContextPath + "/crx/explorer/browser/";
      if (instance.AemInstanceType == AemInstanceType.AEM54) {
        url = instance.UrlWithoutContextPath + "/crx/browser/index.jsp";
      }
      OpenUrl(url, instance);
    }

    private static void OpenCRXDE(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      string url = instance.UrlWithContextPath + "/crx/de/";
      if (instance.AemInstanceType == AemInstanceType.AEM54) {
        url = instance.UrlWithoutContextPath + "/crx/de/";
      }
      OpenUrl(url, instance);
    }

    private static void OpenFelixConsole(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenUrl(instance.UrlWithContextPath + "/system/console", instance);
    }

    private static void OpenServletEngineAdmin(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenUrl(instance.UrlWithoutContextPath + "/admin", instance);
    }

    private static void OpenUrl(string pUrl, AemInstance pInstance) {
      mLog.Info("Open Url: " + pUrl);

      System.Diagnostics.Process p = new System.Diagnostics.Process();
      if (string.IsNullOrEmpty(pInstance.BrowserExecutable)) {
        p.StartInfo.FileName = pUrl;
      }
      else {
        p.StartInfo.FileName = pInstance.BrowserExecutable;
        p.StartInfo.Arguments = pUrl;
      }
      p.Start();
    }

    public static void AddControlMenuItems(Menu.MenuItemCollection pParent, AemInstance pInstance) {
      List<MenuItem> menuItems = new List<MenuItem>();
      MenuItem item;

      item = new MenuItem();
      item.Text = "Start instance";
      item.Click += new EventHandler(ControlStartInstance);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Stop instance";
      item.Click += new EventHandler(ControlStopInstance);
      menuItems.Add(item);

      /*
      -- this does not work yet, disabled --
      item = new MenuItem();
      item.Text = "Kill instance";
      item.Click += new EventHandler(ControlKillInstance);
      menuItems.Add(item);
      */

      foreach (MenuItem i in menuItems) {
        i.Tag = pInstance;
      }

      pParent.AddRange(menuItems.ToArray());
    }

    private static string BuildCommandLineArguments(AemInstance pInstance) {

      List<string> javaArgs = new List<string>();
      List<string> jarArgs = new List<string>();

      // memory settings
      javaArgs.Add("-Xms" + pInstance.HeapMinSizeMb + "m");
      javaArgs.Add("-Xmx" + pInstance.HeapMaxSizeMb + "m");
      javaArgs.Add("-XX:MaxPermSize=" + pInstance.MaxPermSizeMb + "m");

      // instance port
      if (pInstance.AemInstanceType == AemInstanceType.AEM54) {
        javaArgs.Add("-D-crx.quickstart.server.port=" + pInstance.Port);
      }
      else {
        jarArgs.Add("-p " + pInstance.Port);
      }

      // run modes
      string runModes = pInstance.Runmode.ToString().ToLower()
        + "," + (pInstance.RunmodeSampleContent ? "samplecontent" : "nosamplecontent")
        + (!string.IsNullOrEmpty(pInstance.AdditionalRunmodes) ? "," + pInstance.AdditionalRunmodes : "");
      if (pInstance.AemInstanceType == AemInstanceType.AEM54) {
        javaArgs.Add("-Dsling.run.modes=" + runModes);
      }
      else {
        jarArgs.Add("-r " + runModes);
      }

      // context path
      if (!string.IsNullOrEmpty(pInstance.ContextPath) && pInstance.ContextPath!="/") {
        jarArgs.Add("-contextpath " + pInstance.ContextPath);
      }

      // debug mode
      if (pInstance.JVMDebug && (pInstance.DebugPort > 0)) {
        javaArgs.Add("-Xdebug -Xnoagent -Djava.compiler=NONE -Xrunjdwp:transport=dt_socket,server=y,suspend=n,address=" + pInstance.DebugPort);
      }

      // JProfile mode
      if (pInstance.JProfiler && (pInstance.JProfilerPort > 0)) {
        javaArgs.Add("-agentlib:jprofilerti=port=" + pInstance.JProfilerPort + " -Xbootclasspath/a:" + AEMManager.Properties.Settings.Default.JProfilerAgent.Replace("\\", "/"));
      }

      // JConsole mode
      if (pInstance.JConsole && (pInstance.JConsolePort > 0)) {
        javaArgs.Add("-Dcom.sun.management.jmxremote.port=" + pInstance.JConsolePort + " -Dcom.sun.management.jmxremote.ssl=false -Dcom.sun.management.jmxremote.authenticate=false");
      }

      // Hide AEM configuration wizards
      if (pInstance.HideConfigWizard) {
        javaArgs.Add("-DhideConfigWizard=true");
      }

      // custom JVM args
      if (pInstance.CustomJVMParam1Active) {
        javaArgs.Add(pInstance.CustomJVMParam1);
      }
      if (pInstance.CustomJVMParam2Active) {
        javaArgs.Add(pInstance.CustomJVMParam2);
      }
      if (pInstance.CustomJVMParam3Active) {
        javaArgs.Add(pInstance.CustomJVMParam3);
      }

      // configure AEM start mode
      if (pInstance.ShowInstanceWindow) {
        jarArgs.Add("-v");
      }
      if (!pInstance.OpenBrowser) {
        jarArgs.Add("-nobrowser");
      }

      // suppress forking for AEM55 and above, because otherwise debugging will not work
      if (pInstance.AemInstanceType != AemInstanceType.AEM54) {
        jarArgs.Add("-nofork");
      }

      // add jar command line args
      javaArgs.Add("-jar " + pInstance.PathFilename + " " + String.Join(" ", jarArgs.ToArray()));

      // build complete string
      return String.Join(" ", javaArgs.ToArray());
    }

    private static void ControlStartInstance(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }

      if (instance.CurrentBundleStatus == BundleStatus.UNKNOWN
          || instance.CurrentBundleStatus == BundleStatus.STARTING_STOPPING
          || instance.CurrentBundleStatus == BundleStatus.RUNNING) {
        if (MessageBox.Show("The instance seems to be running already.\n"
            + "Press OK to continue starting the instance, it may fail.",
            "Start Instance", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.Cancel) {
          return;
        }
      }

      string executable = "cmd";
      string aemInstanceArguments = BuildCommandLineArguments(instance);
      string arguments = "/c \"" + instance.JavaExecutable + "\" " + aemInstanceArguments;

      // add jprofiler path to current applications path to make sure spawned process gets it as well
      if (instance.JProfiler && (instance.JProfilerPort > 0)) {
        string path = System.Environment.GetEnvironmentVariable("Path");
        if (!path.Contains(AEMManager.Properties.Settings.Default.JProfilerPath)) {
          path += ";" + AEMManager.Properties.Settings.Default.JProfilerPath;
          System.Environment.SetEnvironmentVariable("Path", path);
        }
      }

      bool isConsoleOutputWindow = instance.ConsoleOutputWindow.Visible;
      if (!isConsoleOutputWindow) {
        // show and hide console window again when it is not shown already - to prevent deadlock that occured sometimes stopping instances (DINT-349)
        instance.ConsoleOutputWindow.Show();
      }
      instance.ConsoleOutputWindow.InitStartProcess(instance.PathWithoutFilename, instance.JavaExecutable, aemInstanceArguments);

      instance.JavaProcess = ExecuteCommand(instance.PathWithoutFilename, executable, arguments, instance.Name, instance.ShowInstanceWindow, "aem.ico", false, instance);
      instance.JavaProcessVisible = instance.ShowInstanceWindow;

      if (!isConsoleOutputWindow) {
        instance.ConsoleOutputWindow.Hide();
      }
    }

    private static void ControlStopInstance(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      StopInstance(instance);
    }

    public static void StopInstance(AemInstance pInstance) {
      string shutdownUrl = pInstance.UrlWithContextPath + "/system/console/vmstat?shutdown_type=Stop";
      if (pInstance.AemInstanceType == AemInstanceType.AEM54) {
        shutdownUrl = pInstance.UrlWithoutContextPath + "/admin/shutdown";
      }

      try {
        mLog.Debug("Execute shutdown URL: " + shutdownUrl);

        pInstance.ConsoleOutputWindow.AppendConsoleLog("Shutting down instance...");

        WebRequest request = WebRequestCreate(pInstance, shutdownUrl);
        request.Method = "POST";
        request.Timeout = 3000;

        request.GetResponse();
      }
      catch (WebException ex) {
        mLog.Debug("Unable to connect to " + shutdownUrl + ": " + ex.Message);
      }
      catch (Exception ex) {
        mLog.Error("Error executing shutdown URL: " + shutdownUrl, ex);
      }

    }

    private static void ControlKillInstance(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }

      Process process = instance.GetInstanceJavaProcess();
      if (process != null && !process.HasExited) {
        mLog.Debug("Killing process for instance " + instance.Name);
        process.Kill();
      }

    }

    private static Process ExecuteCommand(string pWorkDir, string pExecutable, string pArguments, string pProcessName,
        bool pShowInstanceWindow, string pIconFile, bool pProcessNameViaShortcut, AemInstance pAemInstance) {
      mLog.Info("Execute: WorkDir=" + pWorkDir + ", executable=" + pExecutable + ", arguments=" + pArguments);

      Process process;

      // execute via auto-generated shortcut
      if (pShowInstanceWindow && pProcessNameViaShortcut) {
        string shortcutFilename = Path.GetTempPath() + pProcessName + ".lnk";

        IWshRuntimeLibrary.WshShell wshShell = new IWshRuntimeLibrary.WshShellClass();
        IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(shortcutFilename);

        if (!string.IsNullOrEmpty(pWorkDir)) {
          shortcut.WorkingDirectory = pWorkDir;
        }
        try {
          shortcut.TargetPath = pExecutable;
        }
        catch (ArgumentException) {
          MessageBox.Show("Executable not found: " + pExecutable, "Execute Command", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return null;
        }
        shortcut.Arguments = pArguments;
        shortcut.Description = pProcessName;
        if (!string.IsNullOrEmpty(pIconFile)) {
          shortcut.IconLocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + pIconFile;
        }
        shortcut.Save();

        process = new Process();
        process.StartInfo.FileName = shortcutFilename;
      }

      // start directly
      else {
        process = new Process();
        if (!string.IsNullOrEmpty(pWorkDir)) {
          process.StartInfo.WorkingDirectory = pWorkDir;
        }
        process.StartInfo.FileName = pExecutable;
        process.StartInfo.Arguments = pArguments;
      }

      if (!pShowInstanceWindow) {
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      }

      if (pProcessNameViaShortcut) {
        // use shellexecute if start via shortcut is used - this forbids using output stream redirection etc.
        process.StartInfo.UseShellExecute = true;
      }
      else {
        // directy start process if no shortcut is used.
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = !pShowInstanceWindow;
        if (pAemInstance != null && !pShowInstanceWindow) {
          // use output handling if AEM instance is available
          process.OutputDataReceived += new DataReceivedEventHandler(pAemInstance.ConsoleOutputWindow.Process_OutputDataReceived);
          process.StartInfo.RedirectStandardOutput = true;
          process.ErrorDataReceived += new DataReceivedEventHandler(pAemInstance.ConsoleOutputWindow.Process_ErrorDataReceived);
          process.StartInfo.RedirectStandardError = true;
        }
      }

      try {
        process.Start();

        if (!pProcessNameViaShortcut) {
          if (pAemInstance != null && !pShowInstanceWindow) {
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
          }
        }

        return process;
      }
      catch (Exception ex) {
        throw new Exception(ex.Message + "\n"
          + "WorkDir: " + pWorkDir + "\n"
          + "Executable: " + pExecutable + "\n"
          + "Arguments: " + pArguments, ex);
      }
    }

    public static void AddLogMenuItems(Menu.MenuItemCollection pParent, AemInstance pInstance) {
      List<MenuItem> menuItems = new List<MenuItem>();
      MenuItem item;

      item = new MenuItem();
      item.Text = "Error Log";
      item.Click += new EventHandler(LogError);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "Request Log";
      item.Click += new EventHandler(LogRequest);
      menuItems.Add(item);

      if (pInstance.AemInstanceType != AemInstanceType.AEM54) {
        item = new MenuItem();
        item.Text = "Access Log";
        item.Click += new EventHandler(LogAccess);
        menuItems.Add(item);
      }

      if (pInstance.AemInstanceType == AemInstanceType.AEM54) {
        item = new MenuItem();
        item.Text = "Server Log";
        item.Click += new EventHandler(LogServer);
        menuItems.Add(item);
      }

      item = new MenuItem();
      item.Text = "StdOut Log";
      item.Click += new EventHandler(LogStdOut);
      menuItems.Add(item);

      item = new MenuItem();
      item.Text = "StdErr Log";
      item.Click += new EventHandler(LogStdErr);
      menuItems.Add(item);

      if (pInstance.AemInstanceType == AemInstanceType.AEM54) {
        item = new MenuItem();
        item.Text = "CRX Log";
        item.Click += new EventHandler(LogCRX);
        menuItems.Add(item);
      }

      item = new MenuItem();
      item.Text = "Console Window";
      item.Click += new EventHandler(ShowConsoleWindow);
      menuItems.Add(item);

      foreach (MenuItem i in menuItems) {
        i.Tag = pInstance;
      }

      pParent.AddRange(menuItems.ToArray());
    }

    private static void LogError(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\error.log", instance.Name + " - error.log");
    }

    private static void LogRequest(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\request.log", instance.Name + " - request.log");
    }

    private static void LogAccess(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\access.log", instance.Name + " - access.log");
    }

    private static void LogServer(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\server.log", instance.Name + " - server.log");
    }

    private static void LogStdOut(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\stdout.log", instance.Name + " - stdout.log");
    }

    private static void LogStdErr(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\stderr.log", instance.Name + " - stderr.log");
    }

    private static void LogCRX(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      OpenLogViewer(instance.PathWithoutFilename + "\\crx-quickstart\\logs\\crx\\error.log", instance.Name + " - crx_error.log");
    }

    private static void ShowConsoleWindow(object sender, EventArgs e) {
      AemInstance instance = Program.GetActionInstance(sender);
      if (instance == null) {
        return;
      }
      instance.ConsoleOutputWindow.Show();
    }

    private static void OpenLogViewer(string pLogFile, string pProcessName) {

      if (!File.Exists(pLogFile)) {
        MessageBox.Show("File does not exist:\n" + pLogFile, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      RegistryKey preferencesKey = RegistryUtil.GetUserKey("Preferences");
      string logViewer = (string)preferencesKey.GetValue("LogViewer", "notepad.exe");

      string executable = logViewer;
      string arguments = "\"" + pLogFile + "\"";

      int pos = executable.IndexOf(" ");
      if (pos>=0) {
        arguments = executable.Substring(pos + 1) + " " + arguments;
        executable = executable.Substring(0, pos);
      }

      string workdir = null;
      try {
        workdir = Path.GetDirectoryName(executable);
      }
      catch (Exception) {
        // ignore
      }

      ExecuteCommand(workdir, executable, arguments, pProcessName, true, "log.ico", AEMManager.Properties.Settings.Default.ProcessNameViaShortcut, null);
    }

    public static BundleStatus GetCombinedBundleStatus(AemInstance pInstance) {
      if (pInstance == null) {
        return BundleStatus.NO_ACTIVE_INSTANCE;
      }

      // check if process is running
      if (!pInstance.RemoteProcess) {
        Process process = pInstance.GetInstanceJavaProcess();
        if (process == null || process.HasExited) {
          return BundleStatus.DISABLED;
        }
      }

      // get bundle status
      BundleStatus bundleStatus = BundleStatus.UNKNOWN;
      string bundleListUrl = pInstance.UrlWithContextPath + "/system/console/bundles/.json";
      Stopwatch responseTimeStopwatch = new Stopwatch();
      try {
        mLog.Debug("Get bundle list from URL: " + bundleListUrl);

        WebRequest request = WebRequestCreate(pInstance, bundleListUrl);
        request.Method = "GET";
        request.Timeout = AEMManager.Properties.Settings.Default.BundleListTimeout;

        responseTimeStopwatch.Start();
        using (WebResponse response = request.GetResponse()) {
          responseTimeStopwatch.Stop();

          String responseText;
          using (StreamReader streamReader = new StreamReader(response.GetResponseStream())) { 
            responseText = streamReader.ReadToEnd();
          }

          // parse JSON
          bool success = false;
          object value = JSON.JsonDecode(responseText, ref success);
          if (success) {
            bundleStatus = GetCombinedBundleStatus(value, responseTimeStopwatch.ElapsedMilliseconds);
          }
          else {
            mLog.Warn("Parsing JSON response failed: " + responseText);
          }
        }

      }
      catch (WebException ex) {
        if (ex.Status == WebExceptionStatus.Timeout) {
          mLog.Debug("Unable to connect to " + bundleListUrl + " due to timeout. "
            + "Configured timeout: " + AEMManager.Properties.Settings.Default.BundleListTimeout + "ms, "
            + "measured response time: " + responseTimeStopwatch.ElapsedMilliseconds + "ms");
        }
        else {
          mLog.Debug("Unable to connect to " + bundleListUrl + ": " + ex.Message);
          bundleStatus = BundleStatus.UNKNOWN;
        }
      }
      catch (Exception ex) {
        mLog.Error("Error getting bundle list from URL: " + bundleListUrl, ex);
        bundleStatus = BundleStatus.UNKNOWN;
      }

      return bundleStatus;
    }

    private static BundleStatus GetCombinedBundleStatus(object pJsonObject, long pRepsonseTime) {
      BundleStatus bundleStatus = BundleStatus.RUNNING;

      Hashtable root = GetHashtable(pJsonObject);
      string status = (string)root["status"];

      ArrayList data = GetArrayList(root["data"]);
      foreach (object dataItem in data) {
        Hashtable bundle = GetHashtable(dataItem);
        string state = (string)bundle["state"];
        if (!string.IsNullOrEmpty(state)) {
          if (!(state.Equals("Active") || state.Equals("Fragment"))) {
            bundleStatus = BundleStatus.STARTING_STOPPING;
            break;
          }
        }
      }

      mLog.Debug("Status: " + status + ", result: " + bundleStatus + " (response time: " + pRepsonseTime + "ms)");

      return bundleStatus;
    }

    /// <summary>
    /// Creates a web request with preemptive authentication.
    /// </summary>
    /// <param name="instance">AEM instance</param>
    /// <param name="url">URL</param>
    /// <returns></returns>
    private static WebRequest WebRequestCreate(AemInstance instance, string url) {
      WebRequest request = WebRequest.Create(url);

      // "manual" preemptive authentication
      string authInfo = instance.Username + ":" + instance.Password;
      authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
      request.Headers["Authorization"] = "Basic " + authInfo;

      return request;
    }

    private static Hashtable GetHashtable(object pJsonObject) {
      if (pJsonObject is Hashtable) {
        return (Hashtable)pJsonObject;
      }
      else {
        return new Hashtable();
      }
    }

    private static ArrayList GetArrayList(object pJsonObject) {
      if (pJsonObject is ArrayList) {
        return (ArrayList)pJsonObject;
      }
      else {
        return new ArrayList();
      }
    }

  }

}
