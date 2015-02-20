//******************************************************************************
// Author           :   Alexander Bell
// Copyright        :   2007-2011 Infosoft International Inc
// Date Created     :   01/15/2007
// Last Modified    :   02/08/2011
// Description      :   Prime Factoring
//******************************************************************************
// DISCLAIMER: This Application is provide on AS IS basis without any warranty
//******************************************************************************
//******************************************************************************
// TERMS OF USE     :   This module is copyrighted.
//                  :   You can use it at your sole risk provided that you keep
//                  :   the original copyright note.
//******************************************************************************
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using FastPrimeFactoringAlgorithm.Properties;

namespace FastPrimeFactoringAlgorithm
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void buttonCalculate_Click(object sender, System.EventArgs e)
    {
      int upperLimit = int.Parse(numericUpDownPrimes.Value.ToString(CultureInfo.InvariantCulture));
      listBoxPrime.Items.Clear();
      progressBar1.Visible = true;
      progressBar1.Minimum = 3;
      progressBar1.Maximum = upperLimit;
      progressBar1.Value = progressBar1.Minimum;
      for (int i = 3; i < upperLimit; i++)
      {
        if (Integers.IsPrime(i))
        {
          listBoxPrime.Items.Add(i);
        }

        progressBar1.Value = i;
      }

      progressBar1.Value = progressBar1.Minimum;
      progressBar1.Visible = false;

      labelCounterPrimes.Text = "Count: " + listBoxPrime.Items.Count;
    }

    private void buttonFactorize_Click(object sender, System.EventArgs e)
    {
      int upperLimit = int.Parse(numericUpDownPrimes.Value.ToString(CultureInfo.InvariantCulture));
      listBoxFactorizeNumbers.Items.Clear();
      progressBar1.Visible = true;
      progressBar1.Minimum = 3;
      progressBar1.Maximum = upperLimit;
      progressBar1.Value = progressBar1.Minimum;
      for (int i = 3; i < upperLimit; i++)
      {
        listBoxFactorizeNumbers.Items.Add(Integers.FactorizeToString(i));
        progressBar1.Value = i;
      }

      progressBar1.Value = progressBar1.Minimum;
      progressBar1.Visible = false;

      labelCounterFactorizeNumbers.Text = "Count: " + listBoxFactorizeNumbers.Items.Count;
    }

    private void FormMain_Load(object sender, System.EventArgs e)
    {
      DisplayTitle();
      GetWindowValue();
      progressBar1.Visible = false;
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth < 400 ? 400 : Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight < 200 ? 200 : Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }
  }
}