using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace AEMManager {

  public partial class InfoDialog : Form {

    public InfoDialog() {
      InitializeComponent();
    }

    private void OKButton_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void InfoDialog_Load(object sender, EventArgs e) {
      Assembly assembly = Assembly.GetExecutingAssembly();
      lblVersion.Text = "Version " + assembly.GetName().Version.ToString();
      AssemblyCopyrightAttribute copyright = (AssemblyCopyrightAttribute)assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), true)[0];
      lblCopyright.Text = copyright.Copyright;
    }

    private void lblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      System.Diagnostics.Process p = new System.Diagnostics.Process();
      p.StartInfo.FileName = lblWebsite.Text;
      p.Start(); 
    }

    private void lblLicenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      System.Diagnostics.Process p = new System.Diagnostics.Process();
      p.StartInfo.FileName = "http://www.apache.org/licenses/LICENSE-2.0";
      p.Start();
    }

  }

}
