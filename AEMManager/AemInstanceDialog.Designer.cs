namespace AEMManager {
  partial class AemInstanceDialog {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.cmOK = new System.Windows.Forms.Button();
      this.cmdCancel = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblName = new System.Windows.Forms.Label();
      this.lblPath = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.txtHostname = new System.Windows.Forms.TextBox();
      this.lblHostname = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.lblPort = new System.Windows.Forms.Label();
      this.txtContextPath = new System.Windows.Forms.TextBox();
      this.lblContextPath = new System.Windows.Forms.Label();
      this.openFileDialogJar = new System.Windows.Forms.OpenFileDialog();
      this.cmdBrowsePath = new System.Windows.Forms.Button();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.grpJVMSettings = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtJConsolePort = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.chkJVMDebug = new System.Windows.Forms.CheckBox();
      this.txtJProfilerPort = new System.Windows.Forms.TextBox();
      this.lblJProfilerPort = new System.Windows.Forms.Label();
      this.chkJProfiler = new System.Windows.Forms.CheckBox();
      this.chkJConsole = new System.Windows.Forms.CheckBox();
      this.chkRemoteProcess = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblMB = new System.Windows.Forms.Label();
      this.chkHideConfigWizards = new System.Windows.Forms.CheckBox();
      this.txtHeapMaxSizeMb = new System.Windows.Forms.TextBox();
      this.lblHeapMaxSizeMb = new System.Windows.Forms.Label();
      this.txtDebugPort = new System.Windows.Forms.TextBox();
      this.lblDebugPort = new System.Windows.Forms.Label();
      this.txtHeapMinSizeMb = new System.Windows.Forms.TextBox();
      this.lblHeapMinSizeMb = new System.Windows.Forms.Label();
      this.chkOpenBrowser = new System.Windows.Forms.CheckBox();
      this.chkRunmodeAuthor = new System.Windows.Forms.RadioButton();
      this.chkRunmodePublish = new System.Windows.Forms.RadioButton();
      this.lblRunmode = new System.Windows.Forms.Label();
      this.chkShowInstanceWindow = new System.Windows.Forms.CheckBox();
      this.grpTaskbar = new System.Windows.Forms.GroupBox();
      this.cmdCustomIconPath = new System.Windows.Forms.Button();
      this.txtCustomIconPath = new System.Windows.Forms.TextBox();
      this.lblCustomIconPath = new System.Windows.Forms.Label();
      this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
      this.lblIconSet = new System.Windows.Forms.Label();
      this.cboIconSet = new System.Windows.Forms.ComboBox();
      this.grpCustomJVMSettings = new System.Windows.Forms.GroupBox();
      this.chkCustomJVMParam3Active = new System.Windows.Forms.CheckBox();
      this.txtCustomJVMParam3 = new System.Windows.Forms.TextBox();
      this.chkCustomJVMParam2Active = new System.Windows.Forms.CheckBox();
      this.txtCustomJVMParam2 = new System.Windows.Forms.TextBox();
      this.chkCustomJVMParam1Active = new System.Windows.Forms.CheckBox();
      this.txtCustomJVMParam1 = new System.Windows.Forms.TextBox();
      this.openFileDialogIcon = new System.Windows.Forms.OpenFileDialog();
      this.txtAdditionalRunmodes = new System.Windows.Forms.TextBox();
      this.lblAdditionalRunmodes = new System.Windows.Forms.Label();
      this.lblAemInstanceType = new System.Windows.Forms.Label();
      this.cboAemInstanceType = new System.Windows.Forms.ComboBox();
      this.cmdBrowseJavaExecutable = new System.Windows.Forms.Button();
      this.txtJavaExecutable = new System.Windows.Forms.TextBox();
      this.lblJavaExecutable = new System.Windows.Forms.Label();
      this.openFileDialogJavaExecutable = new System.Windows.Forms.OpenFileDialog();
      this.cmdBrowseBrowserExecutable = new System.Windows.Forms.Button();
      this.txtBrowserExecutable = new System.Windows.Forms.TextBox();
      this.lblBrowserExecutable = new System.Windows.Forms.Label();
      this.openFileDialogBrowser = new System.Windows.Forms.OpenFileDialog();
      this.chkRunmodeSampleContent = new System.Windows.Forms.CheckBox();
      this.grpJVMSettings.SuspendLayout();
      this.grpTaskbar.SuspendLayout();
      this.grpCustomJVMSettings.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmOK
      // 
      this.cmOK.Location = new System.Drawing.Point(922, 18);
      this.cmOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmOK.Name = "cmOK";
      this.cmOK.Size = new System.Drawing.Size(132, 37);
      this.cmOK.TabIndex = 34;
      this.cmOK.Text = "OK";
      this.cmOK.UseVisualStyleBackColor = true;
      this.cmOK.Click += new System.EventHandler(this.cmOK_Click);
      // 
      // cmdCancel
      // 
      this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdCancel.Location = new System.Drawing.Point(922, 68);
      this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new System.Drawing.Size(132, 35);
      this.cmdCancel.TabIndex = 35;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(120, 18);
      this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(382, 26);
      this.txtName.TabIndex = 1;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(12, 25);
      this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(51, 20);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Name";
      // 
      // lblPath
      // 
      this.lblPath.AutoSize = true;
      this.lblPath.Location = new System.Drawing.Point(12, 215);
      this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(99, 20);
      this.lblPath.TabIndex = 16;
      this.lblPath.Text = "AEM Jar File";
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(120, 209);
      this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(562, 26);
      this.txtPath.TabIndex = 17;
      // 
      // txtHostname
      // 
      this.txtHostname.Location = new System.Drawing.Point(120, 57);
      this.txtHostname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtHostname.Name = "txtHostname";
      this.txtHostname.Size = new System.Drawing.Size(190, 26);
      this.txtHostname.TabIndex = 3;
      // 
      // lblHostname
      // 
      this.lblHostname.AutoSize = true;
      this.lblHostname.Location = new System.Drawing.Point(12, 63);
      this.lblHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblHostname.Name = "lblHostname";
      this.lblHostname.Size = new System.Drawing.Size(83, 20);
      this.lblHostname.TabIndex = 2;
      this.lblHostname.Text = "Hostname";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(426, 57);
      this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(76, 26);
      this.txtPort.TabIndex = 5;
      this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.validate_EnsureNumber);
      // 
      // lblPort
      // 
      this.lblPort.AutoSize = true;
      this.lblPort.Location = new System.Drawing.Point(378, 62);
      this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblPort.Name = "lblPort";
      this.lblPort.Size = new System.Drawing.Size(38, 20);
      this.lblPort.TabIndex = 4;
      this.lblPort.Text = "Port";
      // 
      // txtContextPath
      // 
      this.txtContextPath.Location = new System.Drawing.Point(120, 97);
      this.txtContextPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtContextPath.Name = "txtContextPath";
      this.txtContextPath.Size = new System.Drawing.Size(190, 26);
      this.txtContextPath.TabIndex = 7;
      // 
      // lblContextPath
      // 
      this.lblContextPath.AutoSize = true;
      this.lblContextPath.Location = new System.Drawing.Point(12, 103);
      this.lblContextPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblContextPath.Name = "lblContextPath";
      this.lblContextPath.Size = new System.Drawing.Size(101, 20);
      this.lblContextPath.TabIndex = 6;
      this.lblContextPath.Text = "Context Path";
      // 
      // openFileDialogJar
      // 
      this.openFileDialogJar.Filter = "JAR Files|*.jar|All files|*.*";
      this.openFileDialogJar.Title = "Select AEM JAR File";
      // 
      // cmdBrowsePath
      // 
      this.cmdBrowsePath.Location = new System.Drawing.Point(690, 209);
      this.cmdBrowsePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdBrowsePath.Name = "cmdBrowsePath";
      this.cmdBrowsePath.Size = new System.Drawing.Size(36, 31);
      this.cmdBrowsePath.TabIndex = 18;
      this.cmdBrowsePath.TabStop = false;
      this.cmdBrowsePath.Text = "...";
      this.cmdBrowsePath.UseVisualStyleBackColor = true;
      this.cmdBrowsePath.Click += new System.EventHandler(this.cmdBrowsePath_Click);
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(120, 286);
      this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(190, 26);
      this.txtUsername.TabIndex = 23;
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new System.Drawing.Point(12, 292);
      this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(83, 20);
      this.lblUsername.TabIndex = 22;
      this.lblUsername.Text = "Username";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(120, 323);
      this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(190, 26);
      this.txtPassword.TabIndex = 26;
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(12, 329);
      this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(78, 20);
      this.lblPassword.TabIndex = 25;
      this.lblPassword.Text = "Password";
      // 
      // grpJVMSettings
      // 
      this.grpJVMSettings.Controls.Add(this.label4);
      this.grpJVMSettings.Controls.Add(this.txtJConsolePort);
      this.grpJVMSettings.Controls.Add(this.label3);
      this.grpJVMSettings.Controls.Add(this.chkJVMDebug);
      this.grpJVMSettings.Controls.Add(this.txtJProfilerPort);
      this.grpJVMSettings.Controls.Add(this.lblJProfilerPort);
      this.grpJVMSettings.Controls.Add(this.chkJProfiler);
      this.grpJVMSettings.Controls.Add(this.chkJConsole);
      this.grpJVMSettings.Controls.Add(this.chkRemoteProcess);
      this.grpJVMSettings.Controls.Add(this.label1);
      this.grpJVMSettings.Controls.Add(this.lblMB);
      this.grpJVMSettings.Controls.Add(this.chkHideConfigWizards);
      this.grpJVMSettings.Controls.Add(this.txtHeapMaxSizeMb);
      this.grpJVMSettings.Controls.Add(this.lblHeapMaxSizeMb);
      this.grpJVMSettings.Controls.Add(this.txtDebugPort);
      this.grpJVMSettings.Controls.Add(this.lblDebugPort);
      this.grpJVMSettings.Controls.Add(this.txtHeapMinSizeMb);
      this.grpJVMSettings.Controls.Add(this.lblHeapMinSizeMb);
      this.grpJVMSettings.Location = new System.Drawing.Point(748, 192);
      this.grpJVMSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpJVMSettings.Name = "grpJVMSettings";
      this.grpJVMSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpJVMSettings.Size = new System.Drawing.Size(304, 495);
      this.grpJVMSettings.TabIndex = 33;
      this.grpJVMSettings.TabStop = false;
      this.grpJVMSettings.Text = "JVM Settings";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(46, 462);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(229, 20);
      this.label4.TabIndex = 20;
      this.label4.Text = "(do not check for local process)";
      // 
      // txtJConsolePort
      // 
      this.txtJConsolePort.Location = new System.Drawing.Point(126, 349);
      this.txtJConsolePort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtJConsolePort.Name = "txtJConsolePort";
      this.txtJConsolePort.Size = new System.Drawing.Size(76, 26);
      this.txtJConsolePort.TabIndex = 17;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 354);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 20);
      this.label3.TabIndex = 16;
      this.label3.Text = "JConsole Port";
      // 
      // chkJVMDebug
      // 
      this.chkJVMDebug.AutoSize = true;
      this.chkJVMDebug.Location = new System.Drawing.Point(22, 160);
      this.chkJVMDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkJVMDebug.Name = "chkJVMDebug";
      this.chkJVMDebug.Size = new System.Drawing.Size(203, 24);
      this.chkJVMDebug.TabIndex = 9;
      this.chkJVMDebug.Text = "Enable JVM Debugging";
      this.chkJVMDebug.UseVisualStyleBackColor = true;
      this.chkJVMDebug.CheckedChanged += new System.EventHandler(this.chkJVMDebug_CheckedChanged);
      // 
      // txtJProfilerPort
      // 
      this.txtJProfilerPort.Location = new System.Drawing.Point(126, 268);
      this.txtJProfilerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtJProfilerPort.Name = "txtJProfilerPort";
      this.txtJProfilerPort.Size = new System.Drawing.Size(76, 26);
      this.txtJProfilerPort.TabIndex = 14;
      // 
      // lblJProfilerPort
      // 
      this.lblJProfilerPort.AutoSize = true;
      this.lblJProfilerPort.Location = new System.Drawing.Point(18, 271);
      this.lblJProfilerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblJProfilerPort.Name = "lblJProfilerPort";
      this.lblJProfilerPort.Size = new System.Drawing.Size(99, 20);
      this.lblJProfilerPort.TabIndex = 13;
      this.lblJProfilerPort.Text = "JProfiler Port";
      // 
      // chkJProfiler
      // 
      this.chkJProfiler.AutoSize = true;
      this.chkJProfiler.Location = new System.Drawing.Point(22, 238);
      this.chkJProfiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkJProfiler.Name = "chkJProfiler";
      this.chkJProfiler.Size = new System.Drawing.Size(260, 24);
      this.chkJProfiler.TabIndex = 12;
      this.chkJProfiler.Text = "Enable JProfiler instrumentation";
      this.chkJProfiler.UseVisualStyleBackColor = true;
      this.chkJProfiler.CheckedChanged += new System.EventHandler(this.chkJProfiler_CheckedChanged);
      // 
      // chkJConsole
      // 
      this.chkJConsole.AutoSize = true;
      this.chkJConsole.Location = new System.Drawing.Point(22, 314);
      this.chkJConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkJConsole.Name = "chkJConsole";
      this.chkJConsole.Size = new System.Drawing.Size(241, 24);
      this.chkJConsole.TabIndex = 15;
      this.chkJConsole.Text = "JConsole/JVisualVM Support";
      this.chkJConsole.UseVisualStyleBackColor = true;
      this.chkJConsole.CheckedChanged += new System.EventHandler(this.chkJConsole_CheckedChanged);
      // 
      // chkRemoteProcess
      // 
      this.chkRemoteProcess.AutoSize = true;
      this.chkRemoteProcess.Location = new System.Drawing.Point(22, 437);
      this.chkRemoteProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkRemoteProcess.Name = "chkRemoteProcess";
      this.chkRemoteProcess.Size = new System.Drawing.Size(156, 24);
      this.chkRemoteProcess.TabIndex = 19;
      this.chkRemoteProcess.Text = "Remote instance";
      this.chkRemoteProcess.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(207, 83);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 20);
      this.label1.TabIndex = 5;
      this.label1.Text = "MB";
      // 
      // lblMB
      // 
      this.lblMB.AutoSize = true;
      this.lblMB.Location = new System.Drawing.Point(207, 43);
      this.lblMB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMB.Name = "lblMB";
      this.lblMB.Size = new System.Drawing.Size(33, 20);
      this.lblMB.TabIndex = 2;
      this.lblMB.Text = "MB";
      // 
      // chkHideConfigWizards
      // 
      this.chkHideConfigWizards.AutoSize = true;
      this.chkHideConfigWizards.Location = new System.Drawing.Point(22, 402);
      this.chkHideConfigWizards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkHideConfigWizards.Name = "chkHideConfigWizards";
      this.chkHideConfigWizards.Size = new System.Drawing.Size(218, 24);
      this.chkHideConfigWizards.TabIndex = 18;
      this.chkHideConfigWizards.Text = "Hide AEM Config Wizards";
      this.chkHideConfigWizards.UseVisualStyleBackColor = true;
      // 
      // txtHeapMaxSizeMb
      // 
      this.txtHeapMaxSizeMb.Location = new System.Drawing.Point(126, 77);
      this.txtHeapMaxSizeMb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtHeapMaxSizeMb.Name = "txtHeapMaxSizeMb";
      this.txtHeapMaxSizeMb.Size = new System.Drawing.Size(76, 26);
      this.txtHeapMaxSizeMb.TabIndex = 4;
      // 
      // lblHeapMaxSizeMb
      // 
      this.lblHeapMaxSizeMb.AutoSize = true;
      this.lblHeapMaxSizeMb.Location = new System.Drawing.Point(18, 83);
      this.lblHeapMaxSizeMb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblHeapMaxSizeMb.Name = "lblHeapMaxSizeMb";
      this.lblHeapMaxSizeMb.Size = new System.Drawing.Size(81, 20);
      this.lblHeapMaxSizeMb.TabIndex = 3;
      this.lblHeapMaxSizeMb.Text = "Heap Max";
      // 
      // txtDebugPort
      // 
      this.txtDebugPort.Location = new System.Drawing.Point(126, 191);
      this.txtDebugPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtDebugPort.Name = "txtDebugPort";
      this.txtDebugPort.Size = new System.Drawing.Size(76, 26);
      this.txtDebugPort.TabIndex = 11;
      // 
      // lblDebugPort
      // 
      this.lblDebugPort.AutoSize = true;
      this.lblDebugPort.Location = new System.Drawing.Point(18, 197);
      this.lblDebugPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDebugPort.Name = "lblDebugPort";
      this.lblDebugPort.Size = new System.Drawing.Size(90, 20);
      this.lblDebugPort.TabIndex = 10;
      this.lblDebugPort.Text = "Debug Port";
      // 
      // txtHeapMinSizeMb
      // 
      this.txtHeapMinSizeMb.Location = new System.Drawing.Point(126, 37);
      this.txtHeapMinSizeMb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtHeapMinSizeMb.Name = "txtHeapMinSizeMb";
      this.txtHeapMinSizeMb.Size = new System.Drawing.Size(76, 26);
      this.txtHeapMinSizeMb.TabIndex = 1;
      // 
      // lblHeapMinSizeMb
      // 
      this.lblHeapMinSizeMb.AutoSize = true;
      this.lblHeapMinSizeMb.Location = new System.Drawing.Point(18, 43);
      this.lblHeapMinSizeMb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblHeapMinSizeMb.Name = "lblHeapMinSizeMb";
      this.lblHeapMinSizeMb.Size = new System.Drawing.Size(77, 20);
      this.lblHeapMinSizeMb.TabIndex = 0;
      this.lblHeapMinSizeMb.Text = "Heap Min";
      // 
      // chkOpenBrowser
      // 
      this.chkOpenBrowser.AutoSize = true;
      this.chkOpenBrowser.Location = new System.Drawing.Point(366, 329);
      this.chkOpenBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkOpenBrowser.Name = "chkOpenBrowser";
      this.chkOpenBrowser.Size = new System.Drawing.Size(352, 24);
      this.chkOpenBrowser.TabIndex = 27;
      this.chkOpenBrowser.Text = "Open (default) browser after instance startup";
      this.chkOpenBrowser.UseVisualStyleBackColor = true;
      // 
      // chkRunmodeAuthor
      // 
      this.chkRunmodeAuthor.AutoSize = true;
      this.chkRunmodeAuthor.Location = new System.Drawing.Point(122, 137);
      this.chkRunmodeAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkRunmodeAuthor.Name = "chkRunmodeAuthor";
      this.chkRunmodeAuthor.Size = new System.Drawing.Size(82, 24);
      this.chkRunmodeAuthor.TabIndex = 11;
      this.chkRunmodeAuthor.TabStop = true;
      this.chkRunmodeAuthor.Text = "Author";
      this.chkRunmodeAuthor.UseVisualStyleBackColor = true;
      // 
      // chkRunmodePublish
      // 
      this.chkRunmodePublish.AutoSize = true;
      this.chkRunmodePublish.Location = new System.Drawing.Point(216, 137);
      this.chkRunmodePublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkRunmodePublish.Name = "chkRunmodePublish";
      this.chkRunmodePublish.Size = new System.Drawing.Size(85, 24);
      this.chkRunmodePublish.TabIndex = 12;
      this.chkRunmodePublish.TabStop = true;
      this.chkRunmodePublish.Text = "Publish";
      this.chkRunmodePublish.UseVisualStyleBackColor = true;
      // 
      // lblRunmode
      // 
      this.lblRunmode.AutoSize = true;
      this.lblRunmode.Location = new System.Drawing.Point(12, 140);
      this.lblRunmode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblRunmode.Name = "lblRunmode";
      this.lblRunmode.Size = new System.Drawing.Size(83, 20);
      this.lblRunmode.TabIndex = 10;
      this.lblRunmode.Text = "Run Mode";
      // 
      // chkShowInstanceWindow
      // 
      this.chkShowInstanceWindow.AutoSize = true;
      this.chkShowInstanceWindow.Location = new System.Drawing.Point(366, 292);
      this.chkShowInstanceWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkShowInstanceWindow.Name = "chkShowInstanceWindow";
      this.chkShowInstanceWindow.Size = new System.Drawing.Size(314, 24);
      this.chkShowInstanceWindow.TabIndex = 24;
      this.chkShowInstanceWindow.Text = "Show Process Window for this Instance";
      this.chkShowInstanceWindow.UseVisualStyleBackColor = true;
      // 
      // grpTaskbar
      // 
      this.grpTaskbar.Controls.Add(this.cmdCustomIconPath);
      this.grpTaskbar.Controls.Add(this.txtCustomIconPath);
      this.grpTaskbar.Controls.Add(this.lblCustomIconPath);
      this.grpTaskbar.Controls.Add(this.chkShowInTaskbar);
      this.grpTaskbar.Controls.Add(this.lblIconSet);
      this.grpTaskbar.Controls.Add(this.cboIconSet);
      this.grpTaskbar.Location = new System.Drawing.Point(12, 366);
      this.grpTaskbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpTaskbar.Name = "grpTaskbar";
      this.grpTaskbar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpTaskbar.Size = new System.Drawing.Size(714, 117);
      this.grpTaskbar.TabIndex = 28;
      this.grpTaskbar.TabStop = false;
      this.grpTaskbar.Text = "Taskbar";
      // 
      // cmdCustomIconPath
      // 
      this.cmdCustomIconPath.Location = new System.Drawing.Point(666, 74);
      this.cmdCustomIconPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdCustomIconPath.Name = "cmdCustomIconPath";
      this.cmdCustomIconPath.Size = new System.Drawing.Size(36, 31);
      this.cmdCustomIconPath.TabIndex = 5;
      this.cmdCustomIconPath.TabStop = false;
      this.cmdCustomIconPath.Text = "...";
      this.cmdCustomIconPath.UseVisualStyleBackColor = true;
      this.cmdCustomIconPath.Click += new System.EventHandler(this.cmdCustomIconPath_Click);
      // 
      // txtCustomIconPath
      // 
      this.txtCustomIconPath.Location = new System.Drawing.Point(108, 74);
      this.txtCustomIconPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtCustomIconPath.Name = "txtCustomIconPath";
      this.txtCustomIconPath.Size = new System.Drawing.Size(550, 26);
      this.txtCustomIconPath.TabIndex = 4;
      // 
      // lblCustomIconPath
      // 
      this.lblCustomIconPath.AutoSize = true;
      this.lblCustomIconPath.Location = new System.Drawing.Point(18, 80);
      this.lblCustomIconPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblCustomIconPath.Name = "lblCustomIconPath";
      this.lblCustomIconPath.Size = new System.Drawing.Size(69, 20);
      this.lblCustomIconPath.TabIndex = 3;
      this.lblCustomIconPath.Text = "Icon File";
      // 
      // chkShowInTaskbar
      // 
      this.chkShowInTaskbar.AutoSize = true;
      this.chkShowInTaskbar.Location = new System.Drawing.Point(354, 37);
      this.chkShowInTaskbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkShowInTaskbar.Name = "chkShowInTaskbar";
      this.chkShowInTaskbar.Size = new System.Drawing.Size(152, 24);
      this.chkShowInTaskbar.TabIndex = 2;
      this.chkShowInTaskbar.Text = "Show in Taskbar";
      this.chkShowInTaskbar.UseVisualStyleBackColor = true;
      // 
      // lblIconSet
      // 
      this.lblIconSet.AutoSize = true;
      this.lblIconSet.Location = new System.Drawing.Point(18, 35);
      this.lblIconSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblIconSet.Name = "lblIconSet";
      this.lblIconSet.Size = new System.Drawing.Size(69, 20);
      this.lblIconSet.TabIndex = 0;
      this.lblIconSet.Text = "Icon Set";
      // 
      // cboIconSet
      // 
      this.cboIconSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboIconSet.FormattingEnabled = true;
      this.cboIconSet.Location = new System.Drawing.Point(108, 31);
      this.cboIconSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cboIconSet.Name = "cboIconSet";
      this.cboIconSet.Size = new System.Drawing.Size(190, 28);
      this.cboIconSet.TabIndex = 1;
      // 
      // grpCustomJVMSettings
      // 
      this.grpCustomJVMSettings.Controls.Add(this.chkCustomJVMParam3Active);
      this.grpCustomJVMSettings.Controls.Add(this.txtCustomJVMParam3);
      this.grpCustomJVMSettings.Controls.Add(this.chkCustomJVMParam2Active);
      this.grpCustomJVMSettings.Controls.Add(this.txtCustomJVMParam2);
      this.grpCustomJVMSettings.Controls.Add(this.chkCustomJVMParam1Active);
      this.grpCustomJVMSettings.Controls.Add(this.txtCustomJVMParam1);
      this.grpCustomJVMSettings.Location = new System.Drawing.Point(12, 492);
      this.grpCustomJVMSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpCustomJVMSettings.Name = "grpCustomJVMSettings";
      this.grpCustomJVMSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpCustomJVMSettings.Size = new System.Drawing.Size(714, 148);
      this.grpCustomJVMSettings.TabIndex = 29;
      this.grpCustomJVMSettings.TabStop = false;
      this.grpCustomJVMSettings.Text = "Custom JVM Settings";
      // 
      // chkCustomJVMParam3Active
      // 
      this.chkCustomJVMParam3Active.AutoSize = true;
      this.chkCustomJVMParam3Active.Location = new System.Drawing.Point(18, 105);
      this.chkCustomJVMParam3Active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkCustomJVMParam3Active.Name = "chkCustomJVMParam3Active";
      this.chkCustomJVMParam3Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.chkCustomJVMParam3Active.Size = new System.Drawing.Size(99, 24);
      this.chkCustomJVMParam3Active.TabIndex = 4;
      this.chkCustomJVMParam3Active.Text = "Setting 3";
      this.chkCustomJVMParam3Active.UseVisualStyleBackColor = true;
      this.chkCustomJVMParam3Active.CheckedChanged += new System.EventHandler(this.chkCustomJVMParam3Active_CheckedChanged);
      // 
      // txtCustomJVMParam3
      // 
      this.txtCustomJVMParam3.Location = new System.Drawing.Point(132, 102);
      this.txtCustomJVMParam3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtCustomJVMParam3.Name = "txtCustomJVMParam3";
      this.txtCustomJVMParam3.Size = new System.Drawing.Size(538, 26);
      this.txtCustomJVMParam3.TabIndex = 5;
      // 
      // chkCustomJVMParam2Active
      // 
      this.chkCustomJVMParam2Active.AutoSize = true;
      this.chkCustomJVMParam2Active.Location = new System.Drawing.Point(18, 68);
      this.chkCustomJVMParam2Active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkCustomJVMParam2Active.Name = "chkCustomJVMParam2Active";
      this.chkCustomJVMParam2Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.chkCustomJVMParam2Active.Size = new System.Drawing.Size(99, 24);
      this.chkCustomJVMParam2Active.TabIndex = 2;
      this.chkCustomJVMParam2Active.Text = "Setting 2";
      this.chkCustomJVMParam2Active.UseVisualStyleBackColor = true;
      this.chkCustomJVMParam2Active.CheckedChanged += new System.EventHandler(this.chkCustomJVMParam2Active_CheckedChanged);
      // 
      // txtCustomJVMParam2
      // 
      this.txtCustomJVMParam2.Location = new System.Drawing.Point(132, 65);
      this.txtCustomJVMParam2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtCustomJVMParam2.Name = "txtCustomJVMParam2";
      this.txtCustomJVMParam2.Size = new System.Drawing.Size(538, 26);
      this.txtCustomJVMParam2.TabIndex = 3;
      // 
      // chkCustomJVMParam1Active
      // 
      this.chkCustomJVMParam1Active.AutoSize = true;
      this.chkCustomJVMParam1Active.Location = new System.Drawing.Point(18, 31);
      this.chkCustomJVMParam1Active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkCustomJVMParam1Active.Name = "chkCustomJVMParam1Active";
      this.chkCustomJVMParam1Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.chkCustomJVMParam1Active.Size = new System.Drawing.Size(99, 24);
      this.chkCustomJVMParam1Active.TabIndex = 0;
      this.chkCustomJVMParam1Active.Text = "Setting 1";
      this.chkCustomJVMParam1Active.UseVisualStyleBackColor = true;
      this.chkCustomJVMParam1Active.CheckedChanged += new System.EventHandler(this.chkCustomJVMParam1Active_CheckedChanged);
      // 
      // txtCustomJVMParam1
      // 
      this.txtCustomJVMParam1.Location = new System.Drawing.Point(132, 28);
      this.txtCustomJVMParam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtCustomJVMParam1.Name = "txtCustomJVMParam1";
      this.txtCustomJVMParam1.Size = new System.Drawing.Size(538, 26);
      this.txtCustomJVMParam1.TabIndex = 1;
      // 
      // openFileDialogIcon
      // 
      this.openFileDialogIcon.Filter = "Icon Files|*.ico|All files|*.*";
      this.openFileDialogIcon.Title = "Select Icon File";
      // 
      // txtAdditionalRunmodes
      // 
      this.txtAdditionalRunmodes.Location = new System.Drawing.Point(504, 134);
      this.txtAdditionalRunmodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtAdditionalRunmodes.Name = "txtAdditionalRunmodes";
      this.txtAdditionalRunmodes.Size = new System.Drawing.Size(320, 26);
      this.txtAdditionalRunmodes.TabIndex = 14;
      // 
      // lblAdditionalRunmodes
      // 
      this.lblAdditionalRunmodes.AutoSize = true;
      this.lblAdditionalRunmodes.Location = new System.Drawing.Point(324, 140);
      this.lblAdditionalRunmodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblAdditionalRunmodes.Name = "lblAdditionalRunmodes";
      this.lblAdditionalRunmodes.Size = new System.Drawing.Size(175, 20);
      this.lblAdditionalRunmodes.TabIndex = 13;
      this.lblAdditionalRunmodes.Text = "Additional Run Mode(s)";
      // 
      // lblAemInstanceType
      // 
      this.lblAemInstanceType.AutoSize = true;
      this.lblAemInstanceType.Location = new System.Drawing.Point(324, 103);
      this.lblAemInstanceType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblAemInstanceType.Name = "lblAemInstanceType";
      this.lblAemInstanceType.Size = new System.Drawing.Size(148, 20);
      this.lblAemInstanceType.TabIndex = 8;
      this.lblAemInstanceType.Text = "AEM Instance Type";
      // 
      // cboAemInstanceType
      // 
      this.cboAemInstanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboAemInstanceType.FormattingEnabled = true;
      this.cboAemInstanceType.Location = new System.Drawing.Point(504, 95);
      this.cboAemInstanceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cboAemInstanceType.Name = "cboAemInstanceType";
      this.cboAemInstanceType.Size = new System.Drawing.Size(320, 28);
      this.cboAemInstanceType.TabIndex = 9;
      // 
      // cmdBrowseJavaExecutable
      // 
      this.cmdBrowseJavaExecutable.Location = new System.Drawing.Point(690, 248);
      this.cmdBrowseJavaExecutable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdBrowseJavaExecutable.Name = "cmdBrowseJavaExecutable";
      this.cmdBrowseJavaExecutable.Size = new System.Drawing.Size(36, 31);
      this.cmdBrowseJavaExecutable.TabIndex = 21;
      this.cmdBrowseJavaExecutable.TabStop = false;
      this.cmdBrowseJavaExecutable.Text = "...";
      this.cmdBrowseJavaExecutable.UseVisualStyleBackColor = true;
      this.cmdBrowseJavaExecutable.Click += new System.EventHandler(this.cmdBrowseJavaExecutable_Click);
      // 
      // txtJavaExecutable
      // 
      this.txtJavaExecutable.Location = new System.Drawing.Point(120, 248);
      this.txtJavaExecutable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtJavaExecutable.Name = "txtJavaExecutable";
      this.txtJavaExecutable.Size = new System.Drawing.Size(562, 26);
      this.txtJavaExecutable.TabIndex = 20;
      // 
      // lblJavaExecutable
      // 
      this.lblJavaExecutable.AutoSize = true;
      this.lblJavaExecutable.Location = new System.Drawing.Point(12, 254);
      this.lblJavaExecutable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblJavaExecutable.Name = "lblJavaExecutable";
      this.lblJavaExecutable.Size = new System.Drawing.Size(81, 20);
      this.lblJavaExecutable.TabIndex = 19;
      this.lblJavaExecutable.Text = "Java Exec";
      // 
      // openFileDialogJavaExecutable
      // 
      this.openFileDialogJavaExecutable.Filter = "Java Executables|java.exe;javaw.exe|All files|*.*";
      this.openFileDialogJavaExecutable.Title = "Select Java Executable";
      // 
      // cmdBrowseBrowserExecutable
      // 
      this.cmdBrowseBrowserExecutable.Location = new System.Drawing.Point(690, 657);
      this.cmdBrowseBrowserExecutable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdBrowseBrowserExecutable.Name = "cmdBrowseBrowserExecutable";
      this.cmdBrowseBrowserExecutable.Size = new System.Drawing.Size(36, 31);
      this.cmdBrowseBrowserExecutable.TabIndex = 32;
      this.cmdBrowseBrowserExecutable.TabStop = false;
      this.cmdBrowseBrowserExecutable.Text = "...";
      this.cmdBrowseBrowserExecutable.UseVisualStyleBackColor = true;
      this.cmdBrowseBrowserExecutable.Click += new System.EventHandler(this.cmdBrowseBrowser_Click);
      // 
      // txtBrowserExecutable
      // 
      this.txtBrowserExecutable.Location = new System.Drawing.Point(120, 657);
      this.txtBrowserExecutable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtBrowserExecutable.Name = "txtBrowserExecutable";
      this.txtBrowserExecutable.Size = new System.Drawing.Size(562, 26);
      this.txtBrowserExecutable.TabIndex = 31;
      // 
      // lblBrowserExecutable
      // 
      this.lblBrowserExecutable.AutoSize = true;
      this.lblBrowserExecutable.Location = new System.Drawing.Point(12, 663);
      this.lblBrowserExecutable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblBrowserExecutable.Name = "lblBrowserExecutable";
      this.lblBrowserExecutable.Size = new System.Drawing.Size(67, 20);
      this.lblBrowserExecutable.TabIndex = 30;
      this.lblBrowserExecutable.Text = "Browser";
      // 
      // openFileDialogBrowser
      // 
      this.openFileDialogBrowser.Filter = "Executables (*.exe)|*.exe|All files|*.*";
      this.openFileDialogBrowser.Title = "Select AEM JAR File";
      // 
      // chkRunmodeSampleContent
      // 
      this.chkRunmodeSampleContent.AutoSize = true;
      this.chkRunmodeSampleContent.Location = new System.Drawing.Point(120, 172);
      this.chkRunmodeSampleContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkRunmodeSampleContent.Name = "chkRunmodeSampleContent";
      this.chkRunmodeSampleContent.Size = new System.Drawing.Size(341, 24);
      this.chkRunmodeSampleContent.TabIndex = 15;
      this.chkRunmodeSampleContent.Text = "Install AEM Sample Content on first startup";
      this.chkRunmodeSampleContent.UseVisualStyleBackColor = true;
      // 
      // AemInstanceDialog
      // 
      this.AcceptButton = this.cmOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdCancel;
      this.ClientSize = new System.Drawing.Size(1072, 732);
      this.Controls.Add(this.chkRunmodeSampleContent);
      this.Controls.Add(this.cmdBrowseBrowserExecutable);
      this.Controls.Add(this.txtBrowserExecutable);
      this.Controls.Add(this.lblBrowserExecutable);
      this.Controls.Add(this.cmdBrowseJavaExecutable);
      this.Controls.Add(this.txtJavaExecutable);
      this.Controls.Add(this.lblJavaExecutable);
      this.Controls.Add(this.lblAemInstanceType);
      this.Controls.Add(this.cboAemInstanceType);
      this.Controls.Add(this.txtAdditionalRunmodes);
      this.Controls.Add(this.lblAdditionalRunmodes);
      this.Controls.Add(this.grpCustomJVMSettings);
      this.Controls.Add(this.grpTaskbar);
      this.Controls.Add(this.chkShowInstanceWindow);
      this.Controls.Add(this.lblRunmode);
      this.Controls.Add(this.chkRunmodePublish);
      this.Controls.Add(this.chkRunmodeAuthor);
      this.Controls.Add(this.chkOpenBrowser);
      this.Controls.Add(this.grpJVMSettings);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.lblUsername);
      this.Controls.Add(this.cmdBrowsePath);
      this.Controls.Add(this.txtContextPath);
      this.Controls.Add(this.lblContextPath);
      this.Controls.Add(this.txtPort);
      this.Controls.Add(this.lblPort);
      this.Controls.Add(this.txtHostname);
      this.Controls.Add(this.lblHostname);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.cmdCancel);
      this.Controls.Add(this.cmOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AemInstanceDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "AEM Instance";
      this.Load += new System.EventHandler(this.AemInstanceDialog_Load);
      this.grpJVMSettings.ResumeLayout(false);
      this.grpJVMSettings.PerformLayout();
      this.grpTaskbar.ResumeLayout(false);
      this.grpTaskbar.PerformLayout();
      this.grpCustomJVMSettings.ResumeLayout(false);
      this.grpCustomJVMSettings.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmOK;
    private System.Windows.Forms.Button cmdCancel;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblPath;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.TextBox txtHostname;
    private System.Windows.Forms.Label lblHostname;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.Label lblPort;
    private System.Windows.Forms.TextBox txtContextPath;
    private System.Windows.Forms.Label lblContextPath;
    private System.Windows.Forms.OpenFileDialog openFileDialogJar;
    private System.Windows.Forms.Button cmdBrowsePath;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.GroupBox grpJVMSettings;
    private System.Windows.Forms.CheckBox chkHideConfigWizards;
    private System.Windows.Forms.TextBox txtHeapMaxSizeMb;
    private System.Windows.Forms.Label lblHeapMaxSizeMb;
    private System.Windows.Forms.TextBox txtDebugPort;
    private System.Windows.Forms.Label lblDebugPort;
    private System.Windows.Forms.TextBox txtHeapMinSizeMb;
    private System.Windows.Forms.Label lblHeapMinSizeMb;
    private System.Windows.Forms.CheckBox chkOpenBrowser;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblMB;
    private System.Windows.Forms.RadioButton chkRunmodeAuthor;
    private System.Windows.Forms.RadioButton chkRunmodePublish;
    private System.Windows.Forms.Label lblRunmode;
    private System.Windows.Forms.CheckBox chkShowInstanceWindow;
    private System.Windows.Forms.CheckBox chkRemoteProcess;
    private System.Windows.Forms.GroupBox grpTaskbar;
    private System.Windows.Forms.CheckBox chkShowInTaskbar;
    private System.Windows.Forms.Label lblIconSet;
    private System.Windows.Forms.ComboBox cboIconSet;
    private System.Windows.Forms.GroupBox grpCustomJVMSettings;
    private System.Windows.Forms.CheckBox chkCustomJVMParam3Active;
    private System.Windows.Forms.TextBox txtCustomJVMParam3;
    private System.Windows.Forms.CheckBox chkCustomJVMParam2Active;
    private System.Windows.Forms.TextBox txtCustomJVMParam2;
    private System.Windows.Forms.CheckBox chkCustomJVMParam1Active;
    private System.Windows.Forms.TextBox txtCustomJVMParam1;
    private System.Windows.Forms.Button cmdCustomIconPath;
    private System.Windows.Forms.TextBox txtCustomIconPath;
    private System.Windows.Forms.Label lblCustomIconPath;
    private System.Windows.Forms.OpenFileDialog openFileDialogIcon;
    private System.Windows.Forms.TextBox txtAdditionalRunmodes;
    private System.Windows.Forms.Label lblAdditionalRunmodes;
    private System.Windows.Forms.CheckBox chkJConsole;
    private System.Windows.Forms.CheckBox chkJVMDebug;
    private System.Windows.Forms.TextBox txtJProfilerPort;
    private System.Windows.Forms.Label lblJProfilerPort;
    private System.Windows.Forms.CheckBox chkJProfiler;
    private System.Windows.Forms.TextBox txtJConsolePort;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblAemInstanceType;
    private System.Windows.Forms.ComboBox cboAemInstanceType;
    private System.Windows.Forms.Button cmdBrowseJavaExecutable;
    private System.Windows.Forms.TextBox txtJavaExecutable;
    private System.Windows.Forms.Label lblJavaExecutable;
    private System.Windows.Forms.OpenFileDialog openFileDialogJavaExecutable;
    private System.Windows.Forms.Button cmdBrowseBrowserExecutable;
    private System.Windows.Forms.TextBox txtBrowserExecutable;
    private System.Windows.Forms.Label lblBrowserExecutable;
    private System.Windows.Forms.OpenFileDialog openFileDialogBrowser;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkRunmodeSampleContent;
  }
}