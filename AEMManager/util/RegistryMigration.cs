using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AEMManager.Util {

  class RegistryMigration {

    /// <summary>
    /// Checks if legacy registry settings from predecessor of AEM manager exists, and ask if they should be migrated to AEM manager.
    /// </summary>
    public static void CheckForLegacyRegistrySettings() {

      // check if registry key for AEM manager already exists - skip migration then
      if (HasAemManagerRegistrySettings()) {
        return;
      }

      // check if registry key for predecessor exists - aks for migration then
      RegistryKey oldSettings = GetPredecessorRegistrySettings();
      if (oldSettings != null) {
        if (MessageBox.Show("Existing settings from CQ Manager 1.x found. Press OK to migrate them to AEM Manager, Cancel to ignore them.",
            "Migration settings from CQ Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) {
          MigrateSettings(oldSettings);
        }
      }

    }

    private static bool HasAemManagerRegistrySettings() {
      Assembly assembly = Assembly.GetEntryAssembly();
      AssemblyCompanyAttribute attrCompany = (AssemblyCompanyAttribute)assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true)[0];
      AssemblyTitleAttribute attrTitle = (AssemblyTitleAttribute)assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), true)[0];

      RegistryKey keyUser = Registry.CurrentUser;
      RegistryKey keySoftware = keyUser.OpenSubKey("Software", false);
      RegistryKey keyCompany = keySoftware.OpenSubKey(attrCompany.Company, false);
      if (keyCompany == null) {
        return false;
      }
      RegistryKey keyApplication = keyCompany.OpenSubKey(attrTitle.Title, false);
      return keyApplication != null;
    }

    private static RegistryKey GetPredecessorRegistrySettings() {
      RegistryKey keyUser = Registry.CurrentUser;
      RegistryKey keySoftware = keyUser.OpenSubKey("Software", false);
      RegistryKey keyCompany = keySoftware.OpenSubKey("pro!vision GmbH", false);
      if (keyCompany == null) {
        return null;
      }
      return keyCompany.OpenSubKey("cqstone CQ Manager", true);
    }

    private static void MigrateSettings(RegistryKey source) {
      RegistryKey oldCqManager = source.OpenSubKey("CqManager", false);
      if (oldCqManager != null) {
        MigrateAemManager(oldCqManager, RegistryUtil.GetUserKey("AemManager"));
      }

      RegistryKey oldInstances = source.OpenSubKey("Instances", false);
      if (oldInstances != null) {
        MigrateInstances(oldInstances, RegistryUtil.GetUserKey("Instances"));
      }

      RegistryKey oldPreferences = source.OpenSubKey("Preferences", false);
      if (oldPreferences != null) {
        MigrateInstances(oldPreferences, RegistryUtil.GetUserKey("Preferences"));
      }
    }

    private static void MigrateAemManager(RegistryKey source, RegistryKey target) {
      MigrateIntValues(source, target,
        "WindowPos_WindowHeight",
        "WindowPos_WindowState",
        "WindowPos_WindowWidth",
        "WindowPos_WindowX",
        "WindowPos_WindowY");
    }

    private static void MigrateInstances(RegistryKey source, RegistryKey target) {
      string[] subkeys = source.GetSubKeyNames();
      for (int i = 0; i < subkeys.Length; i++) {
        RegistryKey oldInstance = source.OpenSubKey(subkeys[i], false);
        RegistryKey instance = target.CreateSubKey(subkeys[i]);
        MigrateInstance(oldInstance, instance);
      }
    }

    private static void MigrateInstance(RegistryKey source, RegistryKey target) {
      MigrateStringValues(source, target,
        "AdditionalRunmodes",
        "BrowserExecutable",
        "ContextPath",
        "CustomIconPath",
        "CustomJVMParam1",
        "CustomJVMParam2",
        "CustomJVMParam3",
        "Hostname",
        "IconSet",
        "JavaExecutable",
        "Name",
        "Password",
        "Path",
        "Runmode",
        "Username");
      MigrateIntValues(source, target,
        "CustomJVMParam1Active",
        "CustomJVMParam2Active",
        "CustomJVMParam3Active",
        "DebugPort",
        "HeapMaxSizeMb",
        "HeapMinSizeMb",
        "JConsole",
        "JConsolePort",
        "JProfiler",
        "JProfilerPort",
        "JVMDebug",
        "MaxPermSizeMb",
        "OpenBrowser",
        "Port",
        "RemoteProcess",
        "RunmodeSampleContent",
        "ShowInstanceWindow",
        "ShowInTaskbar");

      string cqInstanceType = (string)source.GetValue("CqInstanceType", "");
      if (cqInstanceType == "CQ54") {
        target.SetValue("AemInstanceType", AemInstanceType.AEM54.ToString());
      }
      else if (cqInstanceType == "CQ55") {
        target.SetValue("AemInstanceType", AemInstanceType.AEM55.ToString());
      }
    }

    private static void MigratePreferences(RegistryKey source, RegistryKey target) {
      MigrateStringValues(source, target,
        "LogViewer");
    }

    private static void MigrateStringValues(RegistryKey source, RegistryKey target, params string[] propertyNames) {
      for (int i=0; i<propertyNames.Length; i++) {
        target.SetValue(propertyNames[i], (string)source.GetValue(propertyNames[i], ""));
      }
    }

    private static void MigrateIntValues(RegistryKey source, RegistryKey target, params string[] propertyNames) {
      for (int i = 0; i < propertyNames.Length; i++) {
        target.SetValue(propertyNames[i], (int)source.GetValue(propertyNames[i], 0));
      }
    }

  }

}