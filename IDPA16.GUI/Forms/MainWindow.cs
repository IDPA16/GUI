using System.Windows.Forms;

namespace IDPA16.GUI.Forms
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
      lblGithub.LinkClicked += LblGithub_LinkClicked;
    }

    private void LblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(@"https://github.com/IDPA16/");
    }
  }
}
