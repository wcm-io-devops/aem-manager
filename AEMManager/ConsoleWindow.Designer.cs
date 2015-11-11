namespace AEMManager {
  partial class ConsoleWindow {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleWindow));
      this.label3 = new System.Windows.Forms.Label();
      this.txtArguments = new System.Windows.Forms.TextBox();
      this.lblArguments = new System.Windows.Forms.Label();
      this.txtExecutable = new System.Windows.Forms.TextBox();
      this.lblExecutable = new System.Windows.Forms.Label();
      this.txtConsoleOutput = new System.Windows.Forms.RichTextBox();
      this.txtWorkDir = new System.Windows.Forms.TextBox();
      this.lblWorkDir = new System.Windows.Forms.Label();
      this.cmClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      //
      // label3
      //
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 95);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 13);
      this.label3.TabIndex = 15;
      this.label3.Text = "Console Output";
      //
      // txtArguments
      //
      this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtArguments.BackColor = System.Drawing.SystemColors.Control;
      this.txtArguments.Location = new System.Drawing.Point(81, 65);
      this.txtArguments.Name = "txtArguments";
      this.txtArguments.ReadOnly = true;
      this.txtArguments.Size = new System.Drawing.Size(743, 20);
      this.txtArguments.TabIndex = 14;
      //
      // lblArguments
      //
      this.lblArguments.AutoSize = true;
      this.lblArguments.Location = new System.Drawing.Point(9, 69);
      this.lblArguments.Name = "lblArguments";
      this.lblArguments.Size = new System.Drawing.Size(57, 13);
      this.lblArguments.TabIndex = 13;
      this.lblArguments.Text = "Arguments";
      //
      // txtExecutable
      //
      this.txtExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtExecutable.BackColor = System.Drawing.SystemColors.Control;
      this.txtExecutable.Location = new System.Drawing.Point(81, 39);
      this.txtExecutable.Name = "txtExecutable";
      this.txtExecutable.ReadOnly = true;
      this.txtExecutable.Size = new System.Drawing.Size(743, 20);
      this.txtExecutable.TabIndex = 12;
      //
      // lblExecutable
      //
      this.lblExecutable.AutoSize = true;
      this.lblExecutable.Location = new System.Drawing.Point(9, 43);
      this.lblExecutable.Name = "lblExecutable";
      this.lblExecutable.Size = new System.Drawing.Size(60, 13);
      this.lblExecutable.TabIndex = 11;
      this.lblExecutable.Text = "Executable";
      //
      // txtConsoleOutput
      //
      this.txtConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtConsoleOutput.BackColor = System.Drawing.Color.Black;
      this.txtConsoleOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtConsoleOutput.ForeColor = System.Drawing.Color.White;
      this.txtConsoleOutput.Location = new System.Drawing.Point(12, 111);
      this.txtConsoleOutput.Name = "txtConsoleOutput";
      this.txtConsoleOutput.ReadOnly = true;
      this.txtConsoleOutput.Size = new System.Drawing.Size(928, 395);
      this.txtConsoleOutput.TabIndex = 16;
      this.txtConsoleOutput.Text = "";
      //
      // txtWorkDir
      //
      this.txtWorkDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtWorkDir.BackColor = System.Drawing.SystemColors.Control;
      this.txtWorkDir.Location = new System.Drawing.Point(81, 13);
      this.txtWorkDir.Name = "txtWorkDir";
      this.txtWorkDir.ReadOnly = true;
      this.txtWorkDir.Size = new System.Drawing.Size(743, 20);
      this.txtWorkDir.TabIndex = 10;
      //
      // lblWorkDir
      //
      this.lblWorkDir.AutoSize = true;
      this.lblWorkDir.Location = new System.Drawing.Point(9, 17);
      this.lblWorkDir.Name = "lblWorkDir";
      this.lblWorkDir.Size = new System.Drawing.Size(49, 13);
      this.lblWorkDir.TabIndex = 9;
      this.lblWorkDir.Text = "Work Dir";
      //
      // cmClose
      //
      this.cmClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmClose.Location = new System.Drawing.Point(852, 10);
      this.cmClose.Name = "cmClose";
      this.cmClose.Size = new System.Drawing.Size(88, 24);
      this.cmClose.TabIndex = 17;
      this.cmClose.Text = "Close";
      this.cmClose.UseVisualStyleBackColor = true;
      this.cmClose.Click += new System.EventHandler(this.cmClose_Click);
      //
      // ConsoleOutputWindow
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(949, 517);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtArguments);
      this.Controls.Add(this.lblArguments);
      this.Controls.Add(this.txtExecutable);
      this.Controls.Add(this.lblExecutable);
      this.Controls.Add(this.txtConsoleOutput);
      this.Controls.Add(this.txtWorkDir);
      this.Controls.Add(this.lblWorkDir);
      this.Controls.Add(this.cmClose);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "ConsoleOutputWindow";
      this.Text = "Console Output";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleOutputWindow_FormClosing);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleOutputWindow_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtArguments;
    private System.Windows.Forms.Label lblArguments;
    private System.Windows.Forms.TextBox txtExecutable;
    private System.Windows.Forms.Label lblExecutable;
    private System.Windows.Forms.RichTextBox txtConsoleOutput;
    private System.Windows.Forms.TextBox txtWorkDir;
    private System.Windows.Forms.Label lblWorkDir;
    private System.Windows.Forms.Button cmClose;
  }
}