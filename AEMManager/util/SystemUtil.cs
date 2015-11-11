using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;

namespace AEMManager.Util {

  static class SystemUtil {

    /// <summary>
    /// Saved current position/state of given form in registry.
    /// </summary>
    /// <param name="pfrm">Form instance</param>
    public static void SaveWindowPos(Form pfrm) {
      RegistryKey key = RegistryUtil.GetUserKey(pfrm);

      if (pfrm.WindowState != FormWindowState.Minimized) {
        key.SetValue("WindowPos_WindowState", (int)pfrm.WindowState);
      }
      pfrm.WindowState = FormWindowState.Normal;
      key.SetValue("WindowPos_WindowWidth", pfrm.Size.Width);
      key.SetValue("WindowPos_WindowHeight", pfrm.Size.Height);
      key.SetValue("WindowPos_WindowX", pfrm.Location.X);
      key.SetValue("WindowPos_WindowY", pfrm.Location.Y);

      key.Close();
    }

    /// <summary>
    /// Restores the last saved position/state of given form from the registry.
    /// </summary>
    /// <param name="pfrm">Form instance</param>
    public static void RestoreWindowPos(Form pfrm) {
      RegistryKey key = RegistryUtil.GetUserKey(pfrm);
      try {
        pfrm.Size = new Size((int)key.GetValue("WindowPos_WindowWidth"), (int)key.GetValue("WindowPos_WindowHeight"));
        pfrm.Location = new Point((int)key.GetValue("WindowPos_WindowX"), (int)key.GetValue("WindowPos_WindowY"));
        pfrm.WindowState = (FormWindowState)key.GetValue("WindowPos_WindowState");
      }
      catch (Exception) { }
      finally {
        key.Close();
      }
    }

  }

}
