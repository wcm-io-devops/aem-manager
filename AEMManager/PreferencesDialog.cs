using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using AEMManager.Util;

namespace AEMManager {

  public partial class PreferencesDialog : Form {

    public PreferencesDialog() {
      InitializeComponent();
    }

    private void PreferencesDialog_Load(object sender, EventArgs e) {
      RegistryKey preferencesKey = RegistryUtil.GetUserKey("Preferences");
      txtLogViewer.Text = (string)preferencesKey.GetValue("LogViewer", "notepad.exe");
    }

    private void cmOK_Click(object sender, EventArgs e) {

      RegistryKey preferencesKey = RegistryUtil.GetUserKey("Preferences");
      preferencesKey.SetValue("LogViewer", txtLogViewer.Text);

      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void cmdCancel_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

  }

}
