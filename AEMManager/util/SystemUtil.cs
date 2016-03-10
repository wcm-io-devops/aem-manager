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

      if (pfrm.MaximizeBox) {
        if (pfrm.WindowState != FormWindowState.Minimized) {
          key.SetValue("WindowPos_WindowState", (int)pfrm.WindowState);
        }
        pfrm.WindowState = FormWindowState.Normal;
      }

      key.SetValue("WindowPos_WindowX", pfrm.Location.X);
      key.SetValue("WindowPos_WindowY", pfrm.Location.Y);

      if (pfrm.FormBorderStyle == FormBorderStyle.Sizable || pfrm.FormBorderStyle == FormBorderStyle.SizableToolWindow) {
        key.SetValue("WindowPos_WindowWidth", pfrm.Size.Width);
        key.SetValue("WindowPos_WindowHeight", pfrm.Size.Height);
      }

      key.Close();
    }

    /// <summary>
    /// Restores the last saved position/state of given form from the registry.
    /// </summary>
    /// <param name="pfrm">Form instance</param>
    public static void RestoreWindowPos(Form pfrm, int left = 0, int top = 0, int width = 0, int height = 0, FormWindowState windowState = FormWindowState.Normal) {
      RegistryKey key = RegistryUtil.GetUserKey(pfrm);
      try {
        pfrm.Location = new Point((int)key.GetValue("WindowPos_WindowX", left), (int)key.GetValue("WindowPos_WindowY", top));
        if (pfrm.FormBorderStyle == FormBorderStyle.Sizable || pfrm.FormBorderStyle == FormBorderStyle.SizableToolWindow) {
          pfrm.Size = new Size((int)key.GetValue("WindowPos_WindowWidth", width), (int)key.GetValue("WindowPos_WindowHeight", height));
        }
        if (pfrm.MaximizeBox) {
          pfrm.WindowState = (FormWindowState)key.GetValue("WindowPos_WindowState", windowState);
        }
      }
      catch (Exception) {
        if (left > 0 && top > 0) {
          pfrm.Location = new Point(left, top);
        }
        if (pfrm.FormBorderStyle == FormBorderStyle.Sizable || pfrm.FormBorderStyle == FormBorderStyle.SizableToolWindow) {
          if (width > 0 && height > 0) {
            pfrm.Size = new Size(width, height);
          }
        }
        if (pfrm.MaximizeBox) {
          pfrm.WindowState = windowState;
        }
      }
      finally {
        key.Close();
      }

      if (pfrm.Left > SystemInformation.VirtualScreen.Width - 50) {
        pfrm.Left = left > 0 ? left : 10;
      }
      if (pfrm.Top > SystemInformation.VirtualScreen.Height - 50) {
        pfrm.Top = top > 0 ? top : 10;
      }

    }

  }

}
