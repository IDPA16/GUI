using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Threading.Thread;
using static System.Diagnostics.Process;

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
      Start(@"https://github.com/IDPA16/");
    }

    private void btnSelectImage_Click(object sender, System.EventArgs e)
    {
      var fileDialog = new OpenFileDialog { Multiselect = false };
      fileDialog.ShowDialog(this);

      if (File.Exists(fileDialog.FileName))
      {
        btnStart.Enabled = true;
        selectedFilePath = fileDialog.FileName;
        lblImagePath.Text = fileDialog.SafeFileName;
        lblStatus.Text = "Ready";
        lblStatus.ForeColor = Color.Black;
        HideResults();
      }
      else
      {
        lblImagePath.Text = "No file or invalid file selected.";
        HideResults();
      }
    }

    private void btnStart_Click(object sender, System.EventArgs e)
    {
      HideResults();
      lblStatus.Text = "Running";
      MessageBox.Show("This will soon start the trained model of hippocrates! Not available yet.");
      Sleep(3000);
      lblStatus.Text = "Finished";
      lblStatus.ForeColor = Color.DarkGreen;
      ShowResults((AnalysisResults.Benign, 97.5m), (AnalysisResults.Normal, 13.25m), (AnalysisResults.Cancer, 5.5m));
      lblHighestMatch.Font = new Font(this.Font, FontStyle.Underline); ;
    }

    private void HideResults()
    {
      lblHighestMatch.Text = "";
      lblSecondMatch.Text = "";
      lblWorstMatch.Text = "";
    }

    private void ShowResults(
      (AnalysisResults resultType, decimal percentage) highest,
      (AnalysisResults resultType, decimal percentage) second,
      (AnalysisResults resultType, decimal percentage) worst)
    {
      pbxResult.BackColor = GetColorForResultType(highest.resultType);
      SetResultLabel(highest, lblHighestMatch);
      SetResultLabel(second, lblSecondMatch);
      SetResultLabel(worst, lblWorstMatch);
    }

    private Color GetColorForResultType(AnalysisResults type)
    {
      switch (type)
      {
        case AnalysisResults.Cancer:
          return Color.Red;
        case AnalysisResults.Benign:
          return Color.Yellow;
        case AnalysisResults.Normal:
          return Color.Green;
        default:
          throw new ArgumentOutOfRangeException(nameof(type), type, null);
      }
    }

    private void SetResultLabel((AnalysisResults resultType, decimal percentage) result, Label label)
    {
      label.Text = $"{GetEnumDiscription(result.resultType)}: {result.percentage / 100:P}";
    }

    private static string GetEnumDiscription<T>(T source)
    {
      FieldInfo fi = source.GetType().GetField(source.ToString());
      var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

      return attributes.Length > 0 ? attributes[0].Description : source.ToString();
    }

    private enum AnalysisResults
    {
      [Description("Cancer")]
      Cancer,
      [Description("Benign")]
      Benign,
      [Description("Normal")]
      Normal
    }
  }
}
