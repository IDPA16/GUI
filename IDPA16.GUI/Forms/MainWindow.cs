using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IDPA16.GUI.Forms
{
  public partial class MainWindow : Form
  {
    private string selectedFilePath;

    public MainWindow()
    {
      InitializeComponent();
    }

    private void lblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(@"https://github.com/IDPA16/");
    }

    private void btnSelectImage_Click(object sender, System.EventArgs e)
    {
      var fileDialog = new OpenFileDialog();
      fileDialog.Multiselect = false;
      fileDialog.ShowDialog(this);
      
      if (File.Exists(fileDialog.FileName))
      {
        btnStart.Visible = true;
        selectedFilePath = fileDialog.FileName;
        lblImagePath.Text = fileDialog.SafeFileName;
      }
      else
      {
        lblImagePath.Text = "No file or invalid file selected.";
      }
    }

    private void btnStart_Click(object sender, System.EventArgs e)
    {
      MessageBox.Show("This will soon start the trained model of hippocrates! Not available yet.");
    }
  }
}
