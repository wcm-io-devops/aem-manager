namespace AEMManager {
  partial class PreferencesDialog {
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
      this.cmdCancel = new System.Windows.Forms.Button();
      this.cmdOK = new System.Windows.Forms.Button();
      this.txtLogViewer = new System.Windows.Forms.TextBox();
      this.lblLogViewer = new System.Windows.Forms.Label();
      this.lblLogViewerDescription = new System.Windows.Forms.Label();
      this.txtBundleFilter = new System.Windows.Forms.TextBox();
      this.lblBundleFilter = new System.Windows.Forms.Label();
      this.lblBundleFilterDescription = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdCancel
      // 
      this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdCancel.Location = new System.Drawing.Point(774, 62);
      this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new System.Drawing.Size(132, 35);
      this.cmdCancel.TabIndex = 3;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
      // 
      // cmdOK
      // 
      this.cmdOK.Location = new System.Drawing.Point(774, 12);
      this.cmdOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new System.Drawing.Size(132, 37);
      this.cmdOK.TabIndex = 2;
      this.cmdOK.Text = "OK";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
      // 
      // txtLogViewer
      // 
      this.txtLogViewer.Location = new System.Drawing.Point(126, 18);
      this.txtLogViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtLogViewer.Name = "txtLogViewer";
      this.txtLogViewer.Size = new System.Drawing.Size(604, 26);
      this.txtLogViewer.TabIndex = 1;
      // 
      // lblLogViewer
      // 
      this.lblLogViewer.AutoSize = true;
      this.lblLogViewer.Location = new System.Drawing.Point(18, 21);
      this.lblLogViewer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblLogViewer.Name = "lblLogViewer";
      this.lblLogViewer.Size = new System.Drawing.Size(88, 20);
      this.lblLogViewer.TabIndex = 0;
      this.lblLogViewer.Text = "Log Viewer";
      // 
      // lblLogViewerDescription
      // 
      this.lblLogViewerDescription.AutoSize = true;
      this.lblLogViewerDescription.Location = new System.Drawing.Point(122, 59);
      this.lblLogViewerDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblLogViewerDescription.Name = "lblLogViewerDescription";
      this.lblLogViewerDescription.Size = new System.Drawing.Size(425, 20);
      this.lblLogViewerDescription.TabIndex = 2;
      this.lblLogViewerDescription.Text = "Log filename is automatically attached to the command line";
      // 
      // txtBundleFilter
      // 
      this.txtBundleFilter.Location = new System.Drawing.Point(126, 110);
      this.txtBundleFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtBundleFilter.Multiline = true;
      this.txtBundleFilter.Name = "txtBundleFilter";
      this.txtBundleFilter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtBundleFilter.Size = new System.Drawing.Size(604, 128);
      this.txtBundleFilter.TabIndex = 4;
      // 
      // lblBundleFilter
      // 
      this.lblBundleFilter.AutoSize = true;
      this.lblBundleFilter.Location = new System.Drawing.Point(18, 113);
      this.lblBundleFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblBundleFilter.Name = "lblBundleFilter";
      this.lblBundleFilter.Size = new System.Drawing.Size(98, 20);
      this.lblBundleFilter.TabIndex = 3;
      this.lblBundleFilter.Text = "Bundle Filter";
      // 
      // lblBundleFilterDescription
      // 
      this.lblBundleFilterDescription.AutoSize = true;
      this.lblBundleFilterDescription.Location = new System.Drawing.Point(122, 254);
      this.lblBundleFilterDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblBundleFilterDescription.Name = "lblBundleFilterDescription";
      this.lblBundleFilterDescription.Size = new System.Drawing.Size(528, 20);
      this.lblBundleFilterDescription.TabIndex = 5;
      this.lblBundleFilterDescription.Text = "List of OSGi bundle symbolic names to be ignored on bundle status check";
      // 
      // PreferencesDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdCancel;
      this.ClientSize = new System.Drawing.Size(921, 300);
      this.Controls.Add(this.lblBundleFilterDescription);
      this.Controls.Add(this.txtBundleFilter);
      this.Controls.Add(this.lblBundleFilter);
      this.Controls.Add(this.lblLogViewerDescription);
      this.Controls.Add(this.txtLogViewer);
      this.Controls.Add(this.lblLogViewer);
      this.Controls.Add(this.cmdCancel);
      this.Controls.Add(this.cmdOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PreferencesDialog";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Preferences";
      this.Load += new System.EventHandler(this.PreferencesDialog_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdCancel;
    private System.Windows.Forms.Button cmdOK;
    private System.Windows.Forms.TextBox txtLogViewer;
    private System.Windows.Forms.Label lblLogViewer;
    private System.Windows.Forms.Label lblLogViewerDescription;
    private System.Windows.Forms.TextBox txtBundleFilter;
    private System.Windows.Forms.Label lblBundleFilter;
    private System.Windows.Forms.Label lblBundleFilterDescription;
  }
}