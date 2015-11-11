using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using AEMManager.Util;

namespace AEMManager {

  public class AemInstanceList : List<AemInstance> {

    public void LoadFromRegistry() {
      RegistryKey instancesKey = RegistryUtil.GetUserKey("Instances");

      string[] subKeys = instancesKey.GetSubKeyNames();
      foreach (string subKey in subKeys) {
        RegistryKey key = instancesKey.OpenSubKey(subKey, false);
        this.Add(new AemInstance(key));
      }

      this.SortByName();
    }

    public void SortByName() {
      this.Sort(new AemInstanceComparer());
    }

    private class AemInstanceComparer : Comparer<AemInstance> {

      public override int Compare(AemInstance x, AemInstance y) {
        if (x.Name == null || y.Name == null) {
          return x.Id.CompareTo(y.Id);
        }
        else {
          return x.Name.CompareTo(y.Name);
        }
      }

    }

  }

}
