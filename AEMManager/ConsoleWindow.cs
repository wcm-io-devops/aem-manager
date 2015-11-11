using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AEMManager {
  public partial class ConsoleWindow : Form {

    private readonly AemInstance mAemInstance;

    public ConsoleWindow(AemInstance pAemInstance) {
      InitializeComponent();
      mAemInstance = pAemInstance;
    }

    private void ConsoleOutputWindow_FormClosing(object sender, FormClosingEventArgs e) {
      if (e.CloseReason == CloseReason.UserClosing) {
        e.Cancel = true;
        this.Hide();
      }
    }

    public void InitStartProcess(string pWorkDir, string pExecutable, string pArguments) {
      txtWorkDir.Text = pWorkDir;
      txtExecutable.Text = pExecutable;
      txtArguments.Text = pArguments;
      txtConsoleOutput.Clear();
    }

    public void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
      if (string.IsNullOrEmpty(e.Data)) {
        return;
      }
      txtConsoleOutput.AppendText(e.Data + "\n");
    }

    public void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e) {
      if (string.IsNullOrEmpty(e.Data)) {
        return;
      }
      int selStart = txtConsoleOutput.TextLength;
      txtConsoleOutput.AppendText(e.Data);
      txtConsoleOutput.Select(selStart, txtConsoleOutput.TextLength);
      txtConsoleOutput.SelectionColor = Color.Red;
      txtConsoleOutput.AppendText("\n");
    }

    private void cmClose_Click(object sender, EventArgs e) {
      this.Hide();
    }

    private void ConsoleOutputWindow_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.C && e.Control) {
        AemActions.StopInstance(mAemInstance);
      }
    }

    public void AppendConsoleLog(string pText) {
      txtConsoleOutput.AppendText(pText + "\n");
    }

  }
}
