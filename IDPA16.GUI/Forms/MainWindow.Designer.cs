namespace IDPA16.GUI.Forms
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblGithub = new System.Windows.Forms.LinkLabel();
      this.btnSelectImage = new System.Windows.Forms.Button();
      this.lblImagePath = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblGithub
      // 
      this.lblGithub.AutoSize = true;
      this.lblGithub.Location = new System.Drawing.Point(319, 9);
      this.lblGithub.Name = "lblGithub";
      this.lblGithub.Size = new System.Drawing.Size(38, 13);
      this.lblGithub.TabIndex = 0;
      this.lblGithub.TabStop = true;
      this.lblGithub.Text = "Github";
      this.lblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGithub_LinkClicked);
      // 
      // btnSelectImage
      // 
      this.btnSelectImage.Location = new System.Drawing.Point(12, 12);
      this.btnSelectImage.Name = "btnSelectImage";
      this.btnSelectImage.Size = new System.Drawing.Size(104, 23);
      this.btnSelectImage.TabIndex = 1;
      this.btnSelectImage.Text = "Select Image";
      this.btnSelectImage.UseVisualStyleBackColor = true;
      this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
      // 
      // lblImagePath
      // 
      this.lblImagePath.AutoSize = true;
      this.lblImagePath.Location = new System.Drawing.Point(12, 38);
      this.lblImagePath.Name = "lblImagePath";
      this.lblImagePath.Size = new System.Drawing.Size(0, 13);
      this.lblImagePath.TabIndex = 2;
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(12, 54);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(104, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start Classification";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Visible = false;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(369, 247);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.lblImagePath);
      this.Controls.Add(this.btnSelectImage);
      this.Controls.Add(this.lblGithub);
      this.Name = "MainWindow";
      this.Text = "IDPA16";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.LinkLabel lblGithub;
    private System.Windows.Forms.Button btnSelectImage;
    private System.Windows.Forms.Label lblImagePath;
    private System.Windows.Forms.Button btnStart;
  }
}

