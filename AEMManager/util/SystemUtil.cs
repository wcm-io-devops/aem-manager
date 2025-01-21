using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;

namespace AEMManager.Util
{

  static class SystemUtil
  {

    /// <summary>
    /// Saved current position/state of given form in registry.
    /// </summary>
    /// <param name="pfrm">Form instance</param>
    public static void SaveWindowPos(Form pfrm)
    {
      RegistryKey key = RegistryUtil.GetUserKey(pfrm);

      if (IsMaximizable(pfrm))
      {
        if (pfrm.WindowState != FormWindowState.Minimized)
        {
          key.SetValue("WindowPos_WindowState", (int)pfrm.WindowState);
        }
        pfrm.WindowState = FormWindowState.Normal;
      }

      key.SetValue("WindowPos_WindowX", pfrm.Location.X);
      key.SetValue("WindowPos_WindowY", pfrm.Location.Y);

      if (IsSizable(pfrm))
      {
        key.SetValue("WindowPos_WindowWidth", pfrm.Size.Width);
        key.SetValue("WindowPos_WindowHeight", pfrm.Size.Height);
      }

      key.Close();
    }

    /// <summary>
    /// Restores the last saved position/state of given form from the registry.
    /// </summary>
    /// <param name="pfrm">Form instance</param>
    public static void RestoreWindowPos(Form pfrm)
    {
      int screenWidth = SystemInformation.WorkingArea.Width;
      int screenHeight = SystemInformation.WorkingArea.Height;
      int left = 0;
      int top = 0;
      int width = 0;
      int height = 0;
      FormWindowState windowState = FormWindowState.Normal;

      // read saved values from registry
      RegistryKey key = RegistryUtil.GetUserKey(pfrm);
      try
      {
        left = (int)key.GetValue("WindowPos_WindowX", 0);
        top = (int)key.GetValue("WindowPos_WindowY", 0);
        if (IsSizable(pfrm))
        {
          width = (int)key.GetValue("WindowPos_WindowWidth", width);
          height = (int)key.GetValue("WindowPos_WindowHeight", height);
        }
        if (IsMaximizable(pfrm))
        {
          windowState = (FormWindowState)key.GetValue("WindowPos_WindowState", windowState);
        }
      }
      catch (Exception)
      {
        // ignore
      }
      finally
      {
        key.Close();
      }

      // restore window position (with ensuring window stays in virtual screen size)
      if (IsSizable(pfrm) && width > 0 && height > 0)
      {
        if (width > screenWidth)
        {
          width = screenWidth - 20;
        }
        if (height > screenHeight)
        {
          height = screenHeight - 20;
        }
        pfrm.Size = new Size(width, height);
      }
      if (left > 0 && top > 0)
      {
        if (left + pfrm.Width > screenWidth)
        {
          left = 10;
        }
        if (top + pfrm.Height > screenHeight)
        {
          top = 10;
        }
        pfrm.Location = new Point(left, top);
      }
      if (IsMaximizable(pfrm))
      {
        pfrm.WindowState = windowState;
      }
    }

    private static bool IsSizable(Form pfrm)
    {
      return pfrm.FormBorderStyle == FormBorderStyle.Sizable || pfrm.FormBorderStyle == FormBorderStyle.SizableToolWindow;
    }

    private static bool IsMaximizable(Form pfrm)
    {
      return pfrm.MaximizeBox;
    }

  }
}
