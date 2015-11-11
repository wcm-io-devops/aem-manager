using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace AEMManager {

  class IconCache {

    private static Dictionary<string, Icon> mIconCache = new Dictionary<string, Icon>();

    public static Icon GetIcon(IconSet pIconSet, string pCustomIconPath, string pState) {
      string key = pIconSet.ToString() + "#" + pCustomIconPath + "#" + pState;

      Icon icon = null;
      if (mIconCache.ContainsKey(key)) {
        icon = mIconCache[key];
      }
      else {
        icon = GetIcon_Interal(pIconSet, pCustomIconPath, pState);
        mIconCache[key] = icon;
      }

      return icon;
    }

    private static Icon GetIcon_Interal(IconSet pIconSet, string pCustomIconPath, string pState) {
      string iconSetName = pIconSet.ToString().ToLower();
      if (!string.IsNullOrEmpty(pCustomIconPath) && File.Exists(pCustomIconPath)) {
        if (iconSetName.StartsWith("inv_")) {
          iconSetName = "inv_overlay";
        }
        else {
          iconSetName = "overlay";
        }

        Icon icon = new Icon(pCustomIconPath);
        string overlayIconPath = "AEMManager.resources." + iconSetName + "." + pState + ".ico";
        Icon overlayIcon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(overlayIconPath));

        // overlay custom icon with overlay icon
        Bitmap iconBitmap = icon.ToBitmap();
        Graphics graphics = Graphics.FromImage(iconBitmap);
        graphics.DrawIcon(overlayIcon, new Rectangle(0, 0, 16, 16));
        graphics.Save();

        return Icon.FromHandle(iconBitmap.GetHicon());
      }
      else {
        string iconPath = "AEMManager.resources." + iconSetName + "." + pState + ".ico";
        return new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(iconPath));
      }
    }

  }

}
