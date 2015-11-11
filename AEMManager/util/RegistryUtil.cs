using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Win32;

namespace AEMManager.Util {

  static class RegistryUtil {

    /// <summary>
    /// Gets a registry user key for the given form in a subkey of the current application.
    /// The Application subkey is build using the company and application name information form assembly info.
    /// </summary>
    /// <param name="pfrm">Form instance</param>
    /// <returns>Registry key</returns>
    public static RegistryKey GetUserKey(Form pfrm) {
      RegistryKey keyUser = GetUserKey();
      RegistryKey keyForm = keyUser.OpenSubKey(pfrm.Name, true);
      if (keyForm == null) {
        keyForm = keyUser.CreateSubKey(pfrm.Name);
      }
      return keyForm;
    }

    /// <summary>
    /// Gets a registry user key for the given form in a subkey of the current application.
    /// The Application subkey is build using the company and application name information form assembly info.
    /// </summary>
    /// <param name="pSubKey">Subkey name</param>
    /// <returns>Registry key</returns>
    public static RegistryKey GetUserKey(string pSubKey) {
      RegistryKey keyUser = GetUserKey();
      RegistryKey subkey = keyUser.OpenSubKey(pSubKey, true);
      if (subkey == null) {
        subkey = keyUser.CreateSubKey(pSubKey);
      }
      return subkey;
    }

    /// <summary>
    /// Gets a user key for the current application.
    /// The Application subkey is build using the company and application name information form assembly info.
    /// </summary>
    /// <returns>Registry key</returns>
    public static RegistryKey GetUserKey() {

      Assembly assembly = Assembly.GetEntryAssembly();
      AssemblyCompanyAttribute attrCompany = (AssemblyCompanyAttribute)assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true)[0];
      AssemblyTitleAttribute attrTitle = (AssemblyTitleAttribute)assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), true)[0];

      RegistryKey keyUser = Registry.CurrentUser;
      RegistryKey keySoftware = keyUser.OpenSubKey("Software", true);
      RegistryKey keyCompany = keySoftware.OpenSubKey(attrCompany.Company, true);
      if (keyCompany == null) {
        keyCompany = keySoftware.CreateSubKey(attrCompany.Company);
      }
      RegistryKey keyApplication = keyCompany.OpenSubKey(attrTitle.Title, true);
      if (keyApplication == null) {
        keyApplication = keyCompany.CreateSubKey(attrTitle.Title);
      }
      return keyApplication;
    }

  }

}
