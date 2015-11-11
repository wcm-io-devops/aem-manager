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
      this.cmOK = new System.Windows.Forms.Button();
      this.txtLogViewer = new System.Windows.Forms.TextBox();
      this.lblLogViewer = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      //
      // cmdCancel
      //
      this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdCancel.Location = new System.Drawing.Point(516, 40);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new System.Drawing.Size(88, 23);
      this.cmdCancel.TabIndex = 3;
      this.cmdCancel.Text = "Cancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
      //
      // cmOK
      //
      this.cmOK.Location = new System.Drawing.Point(516, 8);
      this.cmOK.Name = "cmOK";
      this.cmOK.Size = new System.Drawing.Size(88, 24);
      this.cmOK.TabIndex = 2;
      this.cmOK.Text = "OK";
      this.cmOK.UseVisualStyleBackColor = true;
      this.cmOK.Click += new System.EventHandler(this.cmOK_Click);
      //
      // txtLogViewer
      //
      this.txtLogViewer.Location = new System.Drawing.Point(84, 12);
      this.txtLogViewer.Name = "txtLogViewer";
      this.txtLogViewer.Size = new System.Drawing.Size(404, 20);
      this.txtLogViewer.TabIndex = 1;
      //
      // lblLogViewer
      //
      this.lblLogViewer.AutoSize = true;
      this.lblLogViewer.Location = new System.Drawing.Point(12, 16);
      this.lblLogViewer.Name = "lblLogViewer";
      this.lblLogViewer.Size = new System.Drawing.Size(60, 13);
      this.lblLogViewer.TabIndex = 0;
      this.lblLogViewer.Text = "Log Viewer";
      //
      // label1
      //
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(81, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(284, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Log filename is automatically attached to the command line";
      //
      // PreferencesDialog
      //
      this.AcceptButton = this.cmOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdCancel;
      this.ClientSize = new System.Drawing.Size(614, 77);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtLogViewer);
      this.Controls.Add(this.lblLogViewer);
      this.Controls.Add(this.cmdCancel);
      this.Controls.Add(this.cmOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    private System.Windows.Forms.Button cmOK;
    private System.Windows.Forms.TextBox txtLogViewer;
    private System.Windows.Forms.Label lblLogViewer;
    private System.Windows.Forms.Label label1;
  }
}