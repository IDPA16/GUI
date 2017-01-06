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
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(369, 247);
      this.Controls.Add(this.lblGithub);
      this.Name = "MainWindow";
      this.Text = "IDPA16";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.LinkLabel lblGithub;
  }
}

