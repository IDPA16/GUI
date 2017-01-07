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
      this.lblStatus = new System.Windows.Forms.Label();
      this.pbxResult = new System.Windows.Forms.PictureBox();
      this.lblHighestMatch = new System.Windows.Forms.Label();
      this.lblSecondMatch = new System.Windows.Forms.Label();
      this.lblWorstMatch = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbxResult)).BeginInit();
      this.SuspendLayout();
      // 
      // lblGithub
      // 
      this.lblGithub.AutoSize = true;
      this.lblGithub.Location = new System.Drawing.Point(536, 12);
      this.lblGithub.Name = "lblGithub";
      this.lblGithub.Size = new System.Drawing.Size(89, 13);
      this.lblGithub.TabIndex = 0;
      this.lblGithub.TabStop = true;
      this.lblGithub.Text = "Source @ Github";
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
      this.lblImagePath.Location = new System.Drawing.Point(122, 17);
      this.lblImagePath.Name = "lblImagePath";
      this.lblImagePath.Size = new System.Drawing.Size(0, 13);
      this.lblImagePath.TabIndex = 2;
      // 
      // btnStart
      // 
      this.btnStart.Enabled = false;
      this.btnStart.Location = new System.Drawing.Point(12, 54);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(104, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start Classification";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(122, 59);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(0, 13);
      this.lblStatus.TabIndex = 4;
      // 
      // pbxResult
      // 
      this.pbxResult.Location = new System.Drawing.Point(12, 83);
      this.pbxResult.Name = "pbxResult";
      this.pbxResult.Size = new System.Drawing.Size(333, 352);
      this.pbxResult.TabIndex = 5;
      this.pbxResult.TabStop = false;
      // 
      // lblHighestMatch
      // 
      this.lblHighestMatch.AutoSize = true;
      this.lblHighestMatch.Location = new System.Drawing.Point(387, 105);
      this.lblHighestMatch.Name = "lblHighestMatch";
      this.lblHighestMatch.Size = new System.Drawing.Size(0, 13);
      this.lblHighestMatch.TabIndex = 6;
      // 
      // lblSecondMatch
      // 
      this.lblSecondMatch.AutoSize = true;
      this.lblSecondMatch.Location = new System.Drawing.Point(387, 150);
      this.lblSecondMatch.Name = "lblSecondMatch";
      this.lblSecondMatch.Size = new System.Drawing.Size(0, 13);
      this.lblSecondMatch.TabIndex = 7;
      // 
      // lblWorstMatch
      // 
      this.lblWorstMatch.AutoSize = true;
      this.lblWorstMatch.Location = new System.Drawing.Point(387, 174);
      this.lblWorstMatch.Name = "lblWorstMatch";
      this.lblWorstMatch.Size = new System.Drawing.Size(0, 13);
      this.lblWorstMatch.TabIndex = 8;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 447);
      this.Controls.Add(this.lblWorstMatch);
      this.Controls.Add(this.lblSecondMatch);
      this.Controls.Add(this.lblHighestMatch);
      this.Controls.Add(this.pbxResult);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.lblImagePath);
      this.Controls.Add(this.btnSelectImage);
      this.Controls.Add(this.lblGithub);
      this.Name = "MainWindow";
      this.Text = "IDPA16";
      ((System.ComponentModel.ISupportInitialize)(this.pbxResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.LinkLabel lblGithub;
    private System.Windows.Forms.Button btnSelectImage;
    private System.Windows.Forms.Label lblImagePath;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.PictureBox pbxResult;
    private System.Windows.Forms.Label lblHighestMatch;
    private System.Windows.Forms.Label lblSecondMatch;
    private System.Windows.Forms.Label lblWorstMatch;
  }
}

