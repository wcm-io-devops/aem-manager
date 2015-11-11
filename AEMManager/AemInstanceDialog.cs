using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AEMManager {

  public partial class AemInstanceDialog : Form {

    private AemInstance mInstance;

    public AemInstanceDialog(AemInstance pInstance) {
      InitializeComponent();
      mInstance = pInstance;
    }

    private void AemInstanceDialog_Load(object sender, EventArgs e) {

      // init instance type selectbox
      int selectedAemInstanceType = 0;
      cboAemInstanceType.DisplayMember = "Key";
      cboAemInstanceType.ValueMember = "Value";
      int i = 0;
      foreach (AemInstanceType aemInstanceType in Enum.GetValues(typeof(AemInstanceType))) {
        string name = AemInstanceTypeUtil.GetLabel(aemInstanceType);
        cboAemInstanceType.Items.Add(new KeyValuePair<string, AemInstanceType>(name, aemInstanceType));
        if (aemInstanceType == mInstance.AemInstanceType) {
          selectedAemInstanceType = i;
        }
        i++;
      }

      // init iconset selectbox
      int selectedIconSet = 0;
      cboIconSet.DisplayMember = "Key";
      cboIconSet.ValueMember = "Value";
      i = 0;
      foreach (IconSet iconset in Enum.GetValues(typeof(IconSet))) {
        string name = iconset.ToString().ToLower();
        if (iconset == IconSet.DEFAULT) {
          name = "Default";
        }
        else if (iconset.ToString().StartsWith("NUM")) {
          name = "Number #" + iconset.ToString().Substring(3);
        }
        else if (iconset.ToString().StartsWith("INV_NUM")) {
          name = "Number #" + iconset.ToString().Substring(7) + " (inverted)";
        }
        cboIconSet.Items.Add(new KeyValuePair<string, IconSet>(name, iconset));
        if (iconset == mInstance.IconSet) {
          selectedIconSet = i;
        }
        i++;
      }

      cboAemInstanceType.SelectedIndex = selectedAemInstanceType;
      txtName.Text = mInstance.Name;
      txtHostname.Text = mInstance.Hostname;
      txtPort.Text = mInstance.Port.ToString();
      txtContextPath.Text = mInstance.ContextPath;
      txtPath.Text = mInstance.Path;
      txtJavaExecutable.Text = mInstance.JavaExecutable;
      txtUsername.Text = mInstance.Username;
      txtPassword.Text = mInstance.Password;
      chkRunmodeAuthor.Checked = (mInstance.Runmode == Runmode.AUTHOR);
      chkRunmodePublish.Checked = (mInstance.Runmode == Runmode.PUBLISH);
      txtAdditionalRunmodes.Text = mInstance.AdditionalRunmodes;
      chkRunmodeSampleContent.Checked = mInstance.RunmodeSampleContent;
      cboIconSet.SelectedIndex = selectedIconSet;
      txtCustomIconPath.Text = mInstance.CustomIconPath;
      txtHeapMinSizeMb.Text = mInstance.HeapMinSizeMb.ToString();
      txtHeapMaxSizeMb.Text = mInstance.HeapMaxSizeMb.ToString();
      txtMaxPermSizeMb.Text = mInstance.MaxPermSizeMb.ToString();
      chkJVMDebug.Checked = mInstance.JVMDebug;
      txtDebugPort.Text = mInstance.DebugPort.ToString();
      txtDebugPort.Enabled = chkJVMDebug.Checked;
      chkJProfiler.Checked = mInstance.JProfiler;
      txtJProfilerPort.Text = mInstance.JProfilerPort.ToString();
      txtJProfilerPort.Enabled = chkJProfiler.Checked;
      chkJConsole.Checked = mInstance.JConsole;
      txtJConsolePort.Text = mInstance.JConsolePort.ToString();
      txtJConsolePort.Enabled = chkJConsole.Checked;
      chkWicketDevelopmentMode.Checked = mInstance.WicketDevelopmentMode;
      chkShowInstanceWindow.Checked = mInstance.ShowInstanceWindow;
      chkOpenBrowser.Checked = mInstance.OpenBrowser;
      chkRemoteProcess.Checked = mInstance.RemoteProcess;
      chkShowInTaskbar.Checked = mInstance.ShowInTaskbar;

      chkCustomJVMParam1Active.Checked = mInstance.CustomJVMParam1Active;
      txtCustomJVMParam1.Text = mInstance.CustomJVMParam1;
      txtCustomJVMParam1.Enabled = chkCustomJVMParam1Active.Checked;
      chkCustomJVMParam2Active.Checked = mInstance.CustomJVMParam2Active;
      txtCustomJVMParam2.Text = mInstance.CustomJVMParam2;
      txtCustomJVMParam2.Enabled = chkCustomJVMParam2Active.Checked;
      chkCustomJVMParam3Active.Checked = mInstance.CustomJVMParam3Active;
      txtCustomJVMParam3.Text = mInstance.CustomJVMParam3;
      txtCustomJVMParam3.Enabled = chkCustomJVMParam3Active.Checked;

      txtBrowserExecutable.Text = mInstance.BrowserExecutable;

    }

    private void cmOK_Click(object sender, EventArgs e) {

      mInstance.AemInstanceType = (AemInstanceType)Enum.GetValues(typeof(AemInstanceType)).GetValue(cboAemInstanceType.SelectedIndex);
      mInstance.Name = txtName.Text.Trim();
      mInstance.Hostname = txtHostname.Text.Trim();
      mInstance.Port = ParseWithDefault(txtPort.Text, AemInstance.DEFAULT_PORT);
      mInstance.ContextPath = txtContextPath.Text.Trim();
      mInstance.Path = txtPath.Text.Trim();
      mInstance.JavaExecutable = txtJavaExecutable.Text.Trim();
      mInstance.Username = txtUsername.Text.Trim();
      mInstance.Password = txtPassword.Text.Trim();
      if (chkRunmodePublish.Checked) {
        mInstance.Runmode = Runmode.PUBLISH;
      }
      else {
        mInstance.Runmode = Runmode.AUTHOR;
      }
      mInstance.AdditionalRunmodes = txtAdditionalRunmodes.Text;
      mInstance.RunmodeSampleContent = chkRunmodeSampleContent.Checked;
      mInstance.IconSet = (IconSet)Enum.GetValues(typeof(IconSet)).GetValue(cboIconSet.SelectedIndex);
      mInstance.CustomIconPath = txtCustomIconPath.Text;
      mInstance.Password = txtPassword.Text.Trim();
      mInstance.HeapMinSizeMb = ParseWithDefault(txtHeapMinSizeMb.Text, AemInstance.DEFAULT_HEAP_MIN_MB);
      mInstance.HeapMaxSizeMb = ParseWithDefault(txtHeapMaxSizeMb.Text, AemInstance.DEFAULT_HEAP_MAX_MB);
      mInstance.MaxPermSizeMb = ParseWithDefault(txtMaxPermSizeMb.Text, AemInstance.DEFAULT_PERMSIZE_MB);
      mInstance.JVMDebug = chkJVMDebug.Checked;
      mInstance.DebugPort = ParseWithDefault(txtDebugPort.Text, 0);
      mInstance.JProfiler = chkJProfiler.Checked;
      mInstance.JProfilerPort = ParseWithDefault(txtJProfilerPort.Text, AemInstance.DEFAULT_JPROFILER_PORT);
      mInstance.JConsole = chkJConsole.Checked;
      mInstance.JConsolePort = ParseWithDefault(txtJConsolePort.Text, AemInstance.DEFAULT_JCONSOLE_PORT);
      mInstance.WicketDevelopmentMode = chkWicketDevelopmentMode.Checked;
      mInstance.ShowInstanceWindow = chkShowInstanceWindow.Checked;
      mInstance.OpenBrowser = chkOpenBrowser.Checked;
      mInstance.RemoteProcess = chkRemoteProcess.Checked;
      mInstance.ShowInTaskbar = chkShowInTaskbar.Checked;

      mInstance.CustomJVMParam1Active = chkCustomJVMParam1Active.Checked;
      mInstance.CustomJVMParam1 = txtCustomJVMParam1.Text;
      mInstance.CustomJVMParam2Active = chkCustomJVMParam2Active.Checked;
      mInstance.CustomJVMParam2 = txtCustomJVMParam2.Text;
      mInstance.CustomJVMParam3Active = chkCustomJVMParam3Active.Checked;
      mInstance.CustomJVMParam3 = txtCustomJVMParam3.Text;
      mInstance.BrowserExecutable = txtBrowserExecutable.Text;

      string errorMessage = mInstance.Validate();
      if (errorMessage != null) {
        MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      mInstance.Save();

      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private int ParseWithDefault(string pText, int pDefaultValue) {
      try {
        return int.Parse(pText);
      }
      catch (Exception) {
        return pDefaultValue;
      }
    }

    private void cmdCancel_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    public AemInstance Instance {
      get {
        return mInstance;
      }
    }

    private void validate_EnsureNumber(object sender, CancelEventArgs e) {
      int outValue;
      TextBox text = (TextBox)sender;
      if (!int.TryParse(text.Text, out outValue)) {
        MessageBox.Show(this, "Invalid number: " + text.Text, "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
    }

    private void cmdBrowsePath_Click(object sender, EventArgs e) {
      openFileDialogJar.InitialDirectory = GetDirectory(txtPath.Text);
      if (openFileDialogJar.ShowDialog(this) == DialogResult.OK) {
        txtPath.Text = openFileDialogJar.FileName;
      }
    }

    private void chkCustomJVMParam1Active_CheckedChanged(object sender, EventArgs e) {
      txtCustomJVMParam1.Enabled = chkCustomJVMParam1Active.Checked;
      if (txtCustomJVMParam1.Enabled) {
        txtCustomJVMParam1.Focus();
        txtCustomJVMParam1.SelectAll();
      }
    }

    private void chkCustomJVMParam2Active_CheckedChanged(object sender, EventArgs e) {
      txtCustomJVMParam2.Enabled = chkCustomJVMParam2Active.Checked;
      if (txtCustomJVMParam2.Enabled) {
        txtCustomJVMParam2.Focus();
        txtCustomJVMParam2.SelectAll();
      }
    }

    private void chkCustomJVMParam3Active_CheckedChanged(object sender, EventArgs e) {
      txtCustomJVMParam3.Enabled = chkCustomJVMParam3Active.Checked;
      if (txtCustomJVMParam3.Enabled) {
        txtCustomJVMParam3.Focus();
        txtCustomJVMParam3.SelectAll();
      }
    }

    private void cmdCustomIconPath_Click(object sender, EventArgs e) {
      openFileDialogIcon.InitialDirectory = GetDirectory(txtCustomIconPath.Text);
      if (openFileDialogIcon.ShowDialog(this) == DialogResult.OK) {
        txtCustomIconPath.Text = openFileDialogIcon.FileName;
      }
    }

    private void chkJVMDebug_CheckedChanged(object sender, EventArgs e) {
      txtDebugPort.Enabled = chkJVMDebug.Checked;
      if (txtDebugPort.Enabled) {
        txtDebugPort.Focus();
        txtDebugPort.SelectAll();
      }
    }

    private void chkJProfiler_CheckedChanged(object sender, EventArgs e) {
      txtJProfilerPort.Enabled = chkJProfiler.Checked;
      if (txtJProfilerPort.Enabled) {
        txtJProfilerPort.Focus();
        txtJProfilerPort.SelectAll();
      }
    }

    private void chkJConsole_CheckedChanged(object sender, EventArgs e) {
      txtJConsolePort.Enabled = chkJConsole.Checked;
      if (txtJConsolePort.Enabled) {
        txtJConsolePort.Focus();
        txtJConsolePort.SelectAll();
      }
    }

    private void cmdBrowseJavaExecutable_Click(object sender, EventArgs e) {
      openFileDialogJavaExecutable.InitialDirectory = GetDirectory(txtJavaExecutable.Text);
      if (openFileDialogJavaExecutable.ShowDialog(this) == DialogResult.OK) {
        txtJavaExecutable.Text = openFileDialogJavaExecutable.FileName;
      }
    }

    private string GetDirectory(string pFileName) {
      if (pFileName != null) {
        int index = pFileName .LastIndexOf("\\");
        if (index >= 0) {
          return pFileName.Substring(0, index);
        }
      }
      return "";
    }

    private void cmdBrowseBrowser_Click(object sender, EventArgs e) {
      openFileDialogBrowser.InitialDirectory = GetDirectory(txtBrowserExecutable.Text);
      if (openFileDialogBrowser.ShowDialog(this) == DialogResult.OK) {
        txtBrowserExecutable.Text = openFileDialogBrowser.FileName;
      }
    }

  }

}
