namespace AEMManager {
  partial class InfoDialog {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDialog));
      this.OKButton = new System.Windows.Forms.Button();
      this.lblAppTitle = new System.Windows.Forms.Label();
      this.lblCopyright = new System.Windows.Forms.Label();
      this.lblWebsite = new System.Windows.Forms.LinkLabel();
      this.lblVersion = new System.Windows.Forms.Label();
      this.lblLicense = new System.Windows.Forms.Label();
      this.lblLicenseLink = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // OKButton
      // 
      this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.OKButton.Location = new System.Drawing.Point(256, 12);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(75, 23);
      this.OKButton.TabIndex = 0;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
      // 
      // lblAppTitle
      // 
      this.lblAppTitle.AutoSize = true;
      this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
      this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAppTitle.ForeColor = System.Drawing.Color.White;
      this.lblAppTitle.Location = new System.Drawing.Point(20, 20);
      this.lblAppTitle.Name = "lblAppTitle";
      this.lblAppTitle.Size = new System.Drawing.Size(129, 13);
      this.lblAppTitle.TabIndex = 1;
      this.lblAppTitle.Text = "wcm.io AEM Manager";
      // 
      // lblCopyright
      // 
      this.lblCopyright.AutoSize = true;
      this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
      this.lblCopyright.ForeColor = System.Drawing.Color.White;
      this.lblCopyright.Location = new System.Drawing.Point(20, 79);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(51, 13);
      this.lblCopyright.TabIndex = 2;
      this.lblCopyright.Text = "Copyright";
      // 
      // lblWebsite
      // 
      this.lblWebsite.AutoSize = true;
      this.lblWebsite.BackColor = System.Drawing.Color.Transparent;
      this.lblWebsite.ForeColor = System.Drawing.Color.White;
      this.lblWebsite.LinkColor = System.Drawing.Color.White;
      this.lblWebsite.Location = new System.Drawing.Point(20, 97);
      this.lblWebsite.Name = "lblWebsite";
      this.lblWebsite.Size = new System.Drawing.Size(240, 13);
      this.lblWebsite.TabIndex = 3;
      this.lblWebsite.TabStop = true;
      this.lblWebsite.Text = "https://github.com/wcm-io-devops/aem-manager";
      this.lblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWebsite_LinkClicked);
      // 
      // lblVersion
      // 
      this.lblVersion.AutoSize = true;
      this.lblVersion.BackColor = System.Drawing.Color.Transparent;
      this.lblVersion.ForeColor = System.Drawing.Color.White;
      this.lblVersion.Location = new System.Drawing.Point(20, 40);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(60, 13);
      this.lblVersion.TabIndex = 4;
      this.lblVersion.Text = "Version 0.0";
      // 
      // lblLicense
      // 
      this.lblLicense.AutoSize = true;
      this.lblLicense.BackColor = System.Drawing.Color.Transparent;
      this.lblLicense.ForeColor = System.Drawing.Color.White;
      this.lblLicense.Location = new System.Drawing.Point(20, 120);
      this.lblLicense.Name = "lblLicense";
      this.lblLicense.Size = new System.Drawing.Size(73, 13);
      this.lblLicense.TabIndex = 5;
      this.lblLicense.Text = "Open Source:";
      // 
      // lblLicenseLink
      // 
      this.lblLicenseLink.AutoSize = true;
      this.lblLicenseLink.BackColor = System.Drawing.Color.Transparent;
      this.lblLicenseLink.ForeColor = System.Drawing.Color.White;
      this.lblLicenseLink.LinkColor = System.Drawing.Color.White;
      this.lblLicenseLink.Location = new System.Drawing.Point(99, 120);
      this.lblLicenseLink.Name = "lblLicenseLink";
      this.lblLicenseLink.Size = new System.Drawing.Size(102, 13);
      this.lblLicenseLink.TabIndex = 6;
      this.lblLicenseLink.TabStop = true;
      this.lblLicenseLink.Text = "Apache 2.0 License";
      this.lblLicenseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLicenseLink_LinkClicked);
      // 
      // InfoDialog
      // 
      this.AcceptButton = this.OKButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.CancelButton = this.OKButton;
      this.ClientSize = new System.Drawing.Size(440, 142);
      this.Controls.Add(this.lblLicenseLink);
      this.Controls.Add(this.lblLicense);
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.lblWebsite);
      this.Controls.Add(this.lblCopyright);
      this.Controls.Add(this.lblAppTitle);
      this.Controls.Add(this.OKButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InfoDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Info";
      this.Load += new System.EventHandler(this.InfoDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Label lblAppTitle;
    private System.Windows.Forms.Label lblCopyright;
    private System.Windows.Forms.LinkLabel lblWebsite;
    private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.LinkLabel lblLicenseLink;
    }
}