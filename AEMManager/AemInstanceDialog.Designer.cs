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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.txtMaxPermSizeMb = new System.Windows.Forms.TextBox();
            this.chkWicketDevelopmentMode = new System.Windows.Forms.CheckBox();
            this.lblMaxPermSizeMb = new System.Windows.Forms.Label();
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
            this.cmOK.Location = new System.Drawing.Point(615, 12);
            this.cmOK.Name = "cmOK";
            this.cmOK.Size = new System.Drawing.Size(88, 24);
            this.cmOK.TabIndex = 34;
            this.cmOK.Text = "OK";
            this.cmOK.UseVisualStyleBackColor = true;
            this.cmOK.Click += new System.EventHandler(this.cmOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(615, 44);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 23);
            this.cmdCancel.TabIndex = 35;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(8, 140);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(66, 13);
            this.lblPath.TabIndex = 16;
            this.lblPath.Text = "AEM Jar File";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(80, 136);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(376, 20);
            this.txtPath.TabIndex = 17;
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(80, 37);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(128, 20);
            this.txtHostname.TabIndex = 3;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(8, 41);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(55, 13);
            this.lblHostname.TabIndex = 2;
            this.lblHostname.Text = "Hostname";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(284, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.validate_EnsureNumber);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(252, 40);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // txtContextPath
            // 
            this.txtContextPath.Location = new System.Drawing.Point(80, 63);
            this.txtContextPath.Name = "txtContextPath";
            this.txtContextPath.Size = new System.Drawing.Size(128, 20);
            this.txtContextPath.TabIndex = 7;
            // 
            // lblContextPath
            // 
            this.lblContextPath.AutoSize = true;
            this.lblContextPath.Location = new System.Drawing.Point(8, 67);
            this.lblContextPath.Name = "lblContextPath";
            this.lblContextPath.Size = new System.Drawing.Size(68, 13);
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
            this.cmdBrowsePath.Location = new System.Drawing.Point(460, 136);
            this.cmdBrowsePath.Name = "cmdBrowsePath";
            this.cmdBrowsePath.Size = new System.Drawing.Size(24, 20);
            this.cmdBrowsePath.TabIndex = 18;
            this.cmdBrowsePath.TabStop = false;
            this.cmdBrowsePath.Text = "...";
            this.cmdBrowsePath.UseVisualStyleBackColor = true;
            this.cmdBrowsePath.Click += new System.EventHandler(this.cmdBrowsePath_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(80, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 20);
            this.txtUsername.TabIndex = 23;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 190);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(80, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 26;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 214);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
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
            this.grpJVMSettings.Controls.Add(this.label2);
            this.grpJVMSettings.Controls.Add(this.label1);
            this.grpJVMSettings.Controls.Add(this.lblMB);
            this.grpJVMSettings.Controls.Add(this.txtMaxPermSizeMb);
            this.grpJVMSettings.Controls.Add(this.chkWicketDevelopmentMode);
            this.grpJVMSettings.Controls.Add(this.lblMaxPermSizeMb);
            this.grpJVMSettings.Controls.Add(this.txtHeapMaxSizeMb);
            this.grpJVMSettings.Controls.Add(this.lblHeapMaxSizeMb);
            this.grpJVMSettings.Controls.Add(this.txtDebugPort);
            this.grpJVMSettings.Controls.Add(this.lblDebugPort);
            this.grpJVMSettings.Controls.Add(this.txtHeapMinSizeMb);
            this.grpJVMSettings.Controls.Add(this.lblHeapMinSizeMb);
            this.grpJVMSettings.Location = new System.Drawing.Point(499, 125);
            this.grpJVMSettings.Name = "grpJVMSettings";
            this.grpJVMSettings.Size = new System.Drawing.Size(203, 322);
            this.grpJVMSettings.TabIndex = 33;
            this.grpJVMSettings.TabStop = false;
            this.grpJVMSettings.Text = "JVM Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "(do not check for local process)";
            // 
            // txtJConsolePort
            // 
            this.txtJConsolePort.Location = new System.Drawing.Point(84, 227);
            this.txtJConsolePort.Name = "txtJConsolePort";
            this.txtJConsolePort.Size = new System.Drawing.Size(52, 20);
            this.txtJConsolePort.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "JConsole Port";
            // 
            // chkJVMDebug
            // 
            this.chkJVMDebug.AutoSize = true;
            this.chkJVMDebug.Location = new System.Drawing.Point(15, 104);
            this.chkJVMDebug.Name = "chkJVMDebug";
            this.chkJVMDebug.Size = new System.Drawing.Size(138, 17);
            this.chkJVMDebug.TabIndex = 9;
            this.chkJVMDebug.Text = "Enable JVM Debugging";
            this.chkJVMDebug.UseVisualStyleBackColor = true;
            this.chkJVMDebug.CheckedChanged += new System.EventHandler(this.chkJVMDebug_CheckedChanged);
            // 
            // txtJProfilerPort
            // 
            this.txtJProfilerPort.Location = new System.Drawing.Point(84, 174);
            this.txtJProfilerPort.Name = "txtJProfilerPort";
            this.txtJProfilerPort.Size = new System.Drawing.Size(52, 20);
            this.txtJProfilerPort.TabIndex = 14;
            // 
            // lblJProfilerPort
            // 
            this.lblJProfilerPort.AutoSize = true;
            this.lblJProfilerPort.Location = new System.Drawing.Point(12, 176);
            this.lblJProfilerPort.Name = "lblJProfilerPort";
            this.lblJProfilerPort.Size = new System.Drawing.Size(66, 13);
            this.lblJProfilerPort.TabIndex = 13;
            this.lblJProfilerPort.Text = "JProfiler Port";
            // 
            // chkJProfiler
            // 
            this.chkJProfiler.AutoSize = true;
            this.chkJProfiler.Location = new System.Drawing.Point(15, 155);
            this.chkJProfiler.Name = "chkJProfiler";
            this.chkJProfiler.Size = new System.Drawing.Size(173, 17);
            this.chkJProfiler.TabIndex = 12;
            this.chkJProfiler.Text = "Enable JProfiler instrumentation";
            this.chkJProfiler.UseVisualStyleBackColor = true;
            this.chkJProfiler.CheckedChanged += new System.EventHandler(this.chkJProfiler_CheckedChanged);
            // 
            // chkJConsole
            // 
            this.chkJConsole.AutoSize = true;
            this.chkJConsole.Location = new System.Drawing.Point(15, 204);
            this.chkJConsole.Name = "chkJConsole";
            this.chkJConsole.Size = new System.Drawing.Size(163, 17);
            this.chkJConsole.TabIndex = 15;
            this.chkJConsole.Text = "JConsole/JVisualVM Support";
            this.chkJConsole.UseVisualStyleBackColor = true;
            this.chkJConsole.CheckedChanged += new System.EventHandler(this.chkJConsole_CheckedChanged);
            // 
            // chkRemoteProcess
            // 
            this.chkRemoteProcess.AutoSize = true;
            this.chkRemoteProcess.Location = new System.Drawing.Point(15, 284);
            this.chkRemoteProcess.Name = "chkRemoteProcess";
            this.chkRemoteProcess.Size = new System.Drawing.Size(106, 17);
            this.chkRemoteProcess.TabIndex = 19;
            this.chkRemoteProcess.Text = "Remote instance";
            this.chkRemoteProcess.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MB";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(138, 28);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(23, 13);
            this.lblMB.TabIndex = 2;
            this.lblMB.Text = "MB";
            // 
            // txtMaxPermSizeMb
            // 
            this.txtMaxPermSizeMb.Location = new System.Drawing.Point(84, 76);
            this.txtMaxPermSizeMb.Name = "txtMaxPermSizeMb";
            this.txtMaxPermSizeMb.Size = new System.Drawing.Size(52, 20);
            this.txtMaxPermSizeMb.TabIndex = 7;
            // 
            // chkWicketDevelopmentMode
            // 
            this.chkWicketDevelopmentMode.AutoSize = true;
            this.chkWicketDevelopmentMode.Location = new System.Drawing.Point(15, 261);
            this.chkWicketDevelopmentMode.Name = "chkWicketDevelopmentMode";
            this.chkWicketDevelopmentMode.Size = new System.Drawing.Size(156, 17);
            this.chkWicketDevelopmentMode.TabIndex = 18;
            this.chkWicketDevelopmentMode.Text = "Wicket Development Mode";
            this.chkWicketDevelopmentMode.UseVisualStyleBackColor = true;
            // 
            // lblMaxPermSizeMb
            // 
            this.lblMaxPermSizeMb.AutoSize = true;
            this.lblMaxPermSizeMb.Location = new System.Drawing.Point(12, 79);
            this.lblMaxPermSizeMb.Name = "lblMaxPermSizeMb";
            this.lblMaxPermSizeMb.Size = new System.Drawing.Size(54, 13);
            this.lblMaxPermSizeMb.TabIndex = 6;
            this.lblMaxPermSizeMb.Text = "Perm Gen";
            // 
            // txtHeapMaxSizeMb
            // 
            this.txtHeapMaxSizeMb.Location = new System.Drawing.Point(84, 50);
            this.txtHeapMaxSizeMb.Name = "txtHeapMaxSizeMb";
            this.txtHeapMaxSizeMb.Size = new System.Drawing.Size(52, 20);
            this.txtHeapMaxSizeMb.TabIndex = 4;
            // 
            // lblHeapMaxSizeMb
            // 
            this.lblHeapMaxSizeMb.AutoSize = true;
            this.lblHeapMaxSizeMb.Location = new System.Drawing.Point(12, 54);
            this.lblHeapMaxSizeMb.Name = "lblHeapMaxSizeMb";
            this.lblHeapMaxSizeMb.Size = new System.Drawing.Size(56, 13);
            this.lblHeapMaxSizeMb.TabIndex = 3;
            this.lblHeapMaxSizeMb.Text = "Heap Max";
            // 
            // txtDebugPort
            // 
            this.txtDebugPort.Location = new System.Drawing.Point(84, 124);
            this.txtDebugPort.Name = "txtDebugPort";
            this.txtDebugPort.Size = new System.Drawing.Size(52, 20);
            this.txtDebugPort.TabIndex = 11;
            // 
            // lblDebugPort
            // 
            this.lblDebugPort.AutoSize = true;
            this.lblDebugPort.Location = new System.Drawing.Point(12, 128);
            this.lblDebugPort.Name = "lblDebugPort";
            this.lblDebugPort.Size = new System.Drawing.Size(61, 13);
            this.lblDebugPort.TabIndex = 10;
            this.lblDebugPort.Text = "Debug Port";
            // 
            // txtHeapMinSizeMb
            // 
            this.txtHeapMinSizeMb.Location = new System.Drawing.Point(84, 24);
            this.txtHeapMinSizeMb.Name = "txtHeapMinSizeMb";
            this.txtHeapMinSizeMb.Size = new System.Drawing.Size(52, 20);
            this.txtHeapMinSizeMb.TabIndex = 1;
            // 
            // lblHeapMinSizeMb
            // 
            this.lblHeapMinSizeMb.AutoSize = true;
            this.lblHeapMinSizeMb.Location = new System.Drawing.Point(12, 28);
            this.lblHeapMinSizeMb.Name = "lblHeapMinSizeMb";
            this.lblHeapMinSizeMb.Size = new System.Drawing.Size(53, 13);
            this.lblHeapMinSizeMb.TabIndex = 0;
            this.lblHeapMinSizeMb.Text = "Heap Min";
            // 
            // chkOpenBrowser
            // 
            this.chkOpenBrowser.AutoSize = true;
            this.chkOpenBrowser.Location = new System.Drawing.Point(244, 214);
            this.chkOpenBrowser.Name = "chkOpenBrowser";
            this.chkOpenBrowser.Size = new System.Drawing.Size(235, 17);
            this.chkOpenBrowser.TabIndex = 27;
            this.chkOpenBrowser.Text = "Open (default) browser after instance startup";
            this.chkOpenBrowser.UseVisualStyleBackColor = true;
            // 
            // chkRunmodeAuthor
            // 
            this.chkRunmodeAuthor.AutoSize = true;
            this.chkRunmodeAuthor.Location = new System.Drawing.Point(81, 89);
            this.chkRunmodeAuthor.Name = "chkRunmodeAuthor";
            this.chkRunmodeAuthor.Size = new System.Drawing.Size(56, 17);
            this.chkRunmodeAuthor.TabIndex = 11;
            this.chkRunmodeAuthor.TabStop = true;
            this.chkRunmodeAuthor.Text = "Author";
            this.chkRunmodeAuthor.UseVisualStyleBackColor = true;
            // 
            // chkRunmodePublish
            // 
            this.chkRunmodePublish.AutoSize = true;
            this.chkRunmodePublish.Location = new System.Drawing.Point(144, 89);
            this.chkRunmodePublish.Name = "chkRunmodePublish";
            this.chkRunmodePublish.Size = new System.Drawing.Size(59, 17);
            this.chkRunmodePublish.TabIndex = 12;
            this.chkRunmodePublish.TabStop = true;
            this.chkRunmodePublish.Text = "Publish";
            this.chkRunmodePublish.UseVisualStyleBackColor = true;
            // 
            // lblRunmode
            // 
            this.lblRunmode.AutoSize = true;
            this.lblRunmode.Location = new System.Drawing.Point(8, 91);
            this.lblRunmode.Name = "lblRunmode";
            this.lblRunmode.Size = new System.Drawing.Size(57, 13);
            this.lblRunmode.TabIndex = 10;
            this.lblRunmode.Text = "Run Mode";
            // 
            // chkShowInstanceWindow
            // 
            this.chkShowInstanceWindow.AutoSize = true;
            this.chkShowInstanceWindow.Location = new System.Drawing.Point(244, 190);
            this.chkShowInstanceWindow.Name = "chkShowInstanceWindow";
            this.chkShowInstanceWindow.Size = new System.Drawing.Size(214, 17);
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
            this.grpTaskbar.Location = new System.Drawing.Point(8, 238);
            this.grpTaskbar.Name = "grpTaskbar";
            this.grpTaskbar.Size = new System.Drawing.Size(476, 76);
            this.grpTaskbar.TabIndex = 28;
            this.grpTaskbar.TabStop = false;
            this.grpTaskbar.Text = "Taskbar";
            // 
            // cmdCustomIconPath
            // 
            this.cmdCustomIconPath.Location = new System.Drawing.Point(444, 48);
            this.cmdCustomIconPath.Name = "cmdCustomIconPath";
            this.cmdCustomIconPath.Size = new System.Drawing.Size(24, 20);
            this.cmdCustomIconPath.TabIndex = 5;
            this.cmdCustomIconPath.TabStop = false;
            this.cmdCustomIconPath.Text = "...";
            this.cmdCustomIconPath.UseVisualStyleBackColor = true;
            this.cmdCustomIconPath.Click += new System.EventHandler(this.cmdCustomIconPath_Click);
            // 
            // txtCustomIconPath
            // 
            this.txtCustomIconPath.Location = new System.Drawing.Point(72, 48);
            this.txtCustomIconPath.Name = "txtCustomIconPath";
            this.txtCustomIconPath.Size = new System.Drawing.Size(368, 20);
            this.txtCustomIconPath.TabIndex = 4;
            // 
            // lblCustomIconPath
            // 
            this.lblCustomIconPath.AutoSize = true;
            this.lblCustomIconPath.Location = new System.Drawing.Point(12, 52);
            this.lblCustomIconPath.Name = "lblCustomIconPath";
            this.lblCustomIconPath.Size = new System.Drawing.Size(47, 13);
            this.lblCustomIconPath.TabIndex = 3;
            this.lblCustomIconPath.Text = "Icon File";
            // 
            // chkShowInTaskbar
            // 
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(236, 24);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(106, 17);
            this.chkShowInTaskbar.TabIndex = 2;
            this.chkShowInTaskbar.Text = "Show in Taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // lblIconSet
            // 
            this.lblIconSet.AutoSize = true;
            this.lblIconSet.Location = new System.Drawing.Point(12, 23);
            this.lblIconSet.Name = "lblIconSet";
            this.lblIconSet.Size = new System.Drawing.Size(47, 13);
            this.lblIconSet.TabIndex = 0;
            this.lblIconSet.Text = "Icon Set";
            // 
            // cboIconSet
            // 
            this.cboIconSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIconSet.FormattingEnabled = true;
            this.cboIconSet.Location = new System.Drawing.Point(72, 20);
            this.cboIconSet.Name = "cboIconSet";
            this.cboIconSet.Size = new System.Drawing.Size(128, 21);
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
            this.grpCustomJVMSettings.Location = new System.Drawing.Point(8, 320);
            this.grpCustomJVMSettings.Name = "grpCustomJVMSettings";
            this.grpCustomJVMSettings.Size = new System.Drawing.Size(476, 96);
            this.grpCustomJVMSettings.TabIndex = 29;
            this.grpCustomJVMSettings.TabStop = false;
            this.grpCustomJVMSettings.Text = "Custom JVM Settings";
            // 
            // chkCustomJVMParam3Active
            // 
            this.chkCustomJVMParam3Active.AutoSize = true;
            this.chkCustomJVMParam3Active.Location = new System.Drawing.Point(12, 68);
            this.chkCustomJVMParam3Active.Name = "chkCustomJVMParam3Active";
            this.chkCustomJVMParam3Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCustomJVMParam3Active.Size = new System.Drawing.Size(68, 17);
            this.chkCustomJVMParam3Active.TabIndex = 4;
            this.chkCustomJVMParam3Active.Text = "Setting 3";
            this.chkCustomJVMParam3Active.UseVisualStyleBackColor = true;
            this.chkCustomJVMParam3Active.CheckedChanged += new System.EventHandler(this.chkCustomJVMParam3Active_CheckedChanged);
            // 
            // txtCustomJVMParam3
            // 
            this.txtCustomJVMParam3.Location = new System.Drawing.Point(88, 66);
            this.txtCustomJVMParam3.Name = "txtCustomJVMParam3";
            this.txtCustomJVMParam3.Size = new System.Drawing.Size(360, 20);
            this.txtCustomJVMParam3.TabIndex = 5;
            // 
            // chkCustomJVMParam2Active
            // 
            this.chkCustomJVMParam2Active.AutoSize = true;
            this.chkCustomJVMParam2Active.Location = new System.Drawing.Point(12, 44);
            this.chkCustomJVMParam2Active.Name = "chkCustomJVMParam2Active";
            this.chkCustomJVMParam2Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCustomJVMParam2Active.Size = new System.Drawing.Size(68, 17);
            this.chkCustomJVMParam2Active.TabIndex = 2;
            this.chkCustomJVMParam2Active.Text = "Setting 2";
            this.chkCustomJVMParam2Active.UseVisualStyleBackColor = true;
            this.chkCustomJVMParam2Active.CheckedChanged += new System.EventHandler(this.chkCustomJVMParam2Active_CheckedChanged);
            // 
            // txtCustomJVMParam2
            // 
            this.txtCustomJVMParam2.Location = new System.Drawing.Point(88, 42);
            this.txtCustomJVMParam2.Name = "txtCustomJVMParam2";
            this.txtCustomJVMParam2.Size = new System.Drawing.Size(360, 20);
            this.txtCustomJVMParam2.TabIndex = 3;
            // 
            // chkCustomJVMParam1Active
            // 
            this.chkCustomJVMParam1Active.AutoSize = true;
            this.chkCustomJVMParam1Active.Location = new System.Drawing.Point(12, 20);
            this.chkCustomJVMParam1Active.Name = "chkCustomJVMParam1Active";
            this.chkCustomJVMParam1Active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCustomJVMParam1Active.Size = new System.Drawing.Size(68, 17);
            this.chkCustomJVMParam1Active.TabIndex = 0;
            this.chkCustomJVMParam1Active.Text = "Setting 1";
            this.chkCustomJVMParam1Active.UseVisualStyleBackColor = true;
            this.chkCustomJVMParam1Active.CheckedChanged += new System.EventHandler(this.chkCustomJVMParam1Active_CheckedChanged);
            // 
            // txtCustomJVMParam1
            // 
            this.txtCustomJVMParam1.Location = new System.Drawing.Point(88, 18);
            this.txtCustomJVMParam1.Name = "txtCustomJVMParam1";
            this.txtCustomJVMParam1.Size = new System.Drawing.Size(360, 20);
            this.txtCustomJVMParam1.TabIndex = 1;
            // 
            // openFileDialogIcon
            // 
            this.openFileDialogIcon.Filter = "Icon Files|*.ico|All files|*.*";
            this.openFileDialogIcon.Title = "Select Icon File";
            // 
            // txtAdditionalRunmodes
            // 
            this.txtAdditionalRunmodes.Location = new System.Drawing.Point(336, 87);
            this.txtAdditionalRunmodes.Name = "txtAdditionalRunmodes";
            this.txtAdditionalRunmodes.Size = new System.Drawing.Size(120, 20);
            this.txtAdditionalRunmodes.TabIndex = 14;
            // 
            // lblAdditionalRunmodes
            // 
            this.lblAdditionalRunmodes.AutoSize = true;
            this.lblAdditionalRunmodes.Location = new System.Drawing.Point(216, 91);
            this.lblAdditionalRunmodes.Name = "lblAdditionalRunmodes";
            this.lblAdditionalRunmodes.Size = new System.Drawing.Size(117, 13);
            this.lblAdditionalRunmodes.TabIndex = 13;
            this.lblAdditionalRunmodes.Text = "Additional Run Mode(s)";
            // 
            // lblAemInstanceType
            // 
            this.lblAemInstanceType.AutoSize = true;
            this.lblAemInstanceType.Location = new System.Drawing.Point(216, 67);
            this.lblAemInstanceType.Name = "lblAemInstanceType";
            this.lblAemInstanceType.Size = new System.Drawing.Size(101, 13);
            this.lblAemInstanceType.TabIndex = 8;
            this.lblAemInstanceType.Text = "AEM Instance Type";
            // 
            // cboAemInstanceType
            // 
            this.cboAemInstanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAemInstanceType.FormattingEnabled = true;
            this.cboAemInstanceType.Location = new System.Drawing.Point(336, 62);
            this.cboAemInstanceType.Name = "cboAemInstanceType";
            this.cboAemInstanceType.Size = new System.Drawing.Size(120, 21);
            this.cboAemInstanceType.TabIndex = 9;
            // 
            // cmdBrowseJavaExecutable
            // 
            this.cmdBrowseJavaExecutable.Location = new System.Drawing.Point(460, 161);
            this.cmdBrowseJavaExecutable.Name = "cmdBrowseJavaExecutable";
            this.cmdBrowseJavaExecutable.Size = new System.Drawing.Size(24, 20);
            this.cmdBrowseJavaExecutable.TabIndex = 21;
            this.cmdBrowseJavaExecutable.TabStop = false;
            this.cmdBrowseJavaExecutable.Text = "...";
            this.cmdBrowseJavaExecutable.UseVisualStyleBackColor = true;
            this.cmdBrowseJavaExecutable.Click += new System.EventHandler(this.cmdBrowseJavaExecutable_Click);
            // 
            // txtJavaExecutable
            // 
            this.txtJavaExecutable.Location = new System.Drawing.Point(80, 161);
            this.txtJavaExecutable.Name = "txtJavaExecutable";
            this.txtJavaExecutable.Size = new System.Drawing.Size(376, 20);
            this.txtJavaExecutable.TabIndex = 20;
            // 
            // lblJavaExecutable
            // 
            this.lblJavaExecutable.AutoSize = true;
            this.lblJavaExecutable.Location = new System.Drawing.Point(8, 165);
            this.lblJavaExecutable.Name = "lblJavaExecutable";
            this.lblJavaExecutable.Size = new System.Drawing.Size(57, 13);
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
            this.cmdBrowseBrowserExecutable.Location = new System.Drawing.Point(460, 427);
            this.cmdBrowseBrowserExecutable.Name = "cmdBrowseBrowserExecutable";
            this.cmdBrowseBrowserExecutable.Size = new System.Drawing.Size(24, 20);
            this.cmdBrowseBrowserExecutable.TabIndex = 32;
            this.cmdBrowseBrowserExecutable.TabStop = false;
            this.cmdBrowseBrowserExecutable.Text = "...";
            this.cmdBrowseBrowserExecutable.UseVisualStyleBackColor = true;
            this.cmdBrowseBrowserExecutable.Click += new System.EventHandler(this.cmdBrowseBrowser_Click);
            // 
            // txtBrowserExecutable
            // 
            this.txtBrowserExecutable.Location = new System.Drawing.Point(80, 427);
            this.txtBrowserExecutable.Name = "txtBrowserExecutable";
            this.txtBrowserExecutable.Size = new System.Drawing.Size(376, 20);
            this.txtBrowserExecutable.TabIndex = 31;
            // 
            // lblBrowserExecutable
            // 
            this.lblBrowserExecutable.AutoSize = true;
            this.lblBrowserExecutable.Location = new System.Drawing.Point(8, 431);
            this.lblBrowserExecutable.Name = "lblBrowserExecutable";
            this.lblBrowserExecutable.Size = new System.Drawing.Size(45, 13);
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
            this.chkRunmodeSampleContent.Location = new System.Drawing.Point(80, 112);
            this.chkRunmodeSampleContent.Name = "chkRunmodeSampleContent";
            this.chkRunmodeSampleContent.Size = new System.Drawing.Size(279, 17);
            this.chkRunmodeSampleContent.TabIndex = 15;
            this.chkRunmodeSampleContent.Text = "Install AEM Sample Content (Geometrixx) on first startup";
            this.chkRunmodeSampleContent.UseVisualStyleBackColor = true;
            // 
            // AemInstanceDialog
            // 
            this.AcceptButton = this.cmOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(715, 476);
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
    private System.Windows.Forms.TextBox txtMaxPermSizeMb;
    private System.Windows.Forms.CheckBox chkWicketDevelopmentMode;
    private System.Windows.Forms.Label lblMaxPermSizeMb;
    private System.Windows.Forms.TextBox txtHeapMaxSizeMb;
    private System.Windows.Forms.Label lblHeapMaxSizeMb;
    private System.Windows.Forms.TextBox txtDebugPort;
    private System.Windows.Forms.Label lblDebugPort;
    private System.Windows.Forms.TextBox txtHeapMinSizeMb;
    private System.Windows.Forms.Label lblHeapMinSizeMb;
    private System.Windows.Forms.CheckBox chkOpenBrowser;
    private System.Windows.Forms.Label label2;
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