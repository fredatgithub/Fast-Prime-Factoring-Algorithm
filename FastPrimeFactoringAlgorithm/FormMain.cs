﻿using System.Diagnostics;
using System.Globalization;
using System.IO;
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
      int upperLimit = int.Parse(numericUpDownPrimesTo.Value.ToString(CultureInfo.InvariantCulture));
      int lowerLimit = int.Parse(numericUpDownPrimesFrom.Value.ToString(CultureInfo.InvariantCulture));
      listBoxPrime.Items.Clear();
      labelDurationPrimes.Text = "Duration:";
      labelCounterPrimes.Text = "Count: 0";
      Application.DoEvents();
      Stopwatch chrono = new Stopwatch();
      chrono.Start();
      progressBar1.Visible = true;
      progressBar1.Minimum = lowerLimit;
      progressBar1.Maximum = upperLimit;
      progressBar1.Value = progressBar1.Minimum;
      for (int i = lowerLimit; i < upperLimit; i++)
      {
        if (Integers.IsPrime(i))
        {
          listBoxPrime.Items.Add(i);
        }

        progressBar1.Value = i;
        Application.DoEvents();
      }

      buttonSaveToText.Enabled = listBoxPrime.Items.Count > 0;
      progressBar1.Value = progressBar1.Minimum;
      progressBar1.Visible = false;
      chrono.Stop();
      labelDurationPrimes.Text = "Duration: " + chrono.ElapsedMilliseconds + " milliseconds";
      labelCounterPrimes.Text = "Count: " + listBoxPrime.Items.Count;
    }

    private void buttonFactorize_Click(object sender, System.EventArgs e)
    {
      int upperLimit = int.Parse(numericUpDownPrimesFrom.Value.ToString(CultureInfo.InvariantCulture));
      listBoxFactorizeNumbers.Items.Clear();
      labelDurationFactorize.Text = "Duration:";
      labelCounterFactorizeNumbers.Text = "Count: 0";
      Application.DoEvents();
      Stopwatch chrono = new Stopwatch();
      chrono.Start();
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
      chrono.Stop();
      labelDurationFactorize.Text = "Duration: " + chrono.ElapsedMilliseconds + " milliseconds";
      labelCounterFactorizeNumbers.Text = "Count: " + listBoxFactorizeNumbers.Items.Count;
    }

    private void FormMain_Load(object sender, System.EventArgs e)
    {
      DisplayTitle();
      GetWindowValue();
      progressBar1.Visible = false;
      buttonSaveToText.Enabled = false;
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

    private void buttonSaveToText_Click(object sender, System.EventArgs e)
    {
      if (listBoxPrime.Items.Count > 0)
      {
        string fileName = "Primes-" + listBoxPrime.Items[0] + "-TO-" + listBoxPrime.Items[listBoxPrime.Items.Count - 1] + ".txt";
        bool overwriteFile = false;
        if (File.Exists(fileName))
        {
          if (DisplayMessage("The file {0} already exists\nDo you want to overwrite it ?",
            "The file already exists", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            overwriteFile = true;
          }
        }

        if (overwriteFile)
        {
          File.Delete(fileName);
        }
        
        StreamWriter sw = new StreamWriter(fileName);
        foreach (int item in listBoxPrime.Items)
        {
          sw.WriteLine(item);
        }
        
        sw.Flush();
        sw.Close();
        if (
          DisplayMessage("Do you want to open the newly saved text file?", "Open text file", MessageBoxButtons.YesNo) ==
          DialogResult.Yes)
        {
          Process.Start(fileName);
        }
      }
    }

    private DialogResult DisplayMessage(string message, string title, MessageBoxButtons buttons)
    {
      DialogResult result = MessageBox.Show(this, message, title, buttons);
      return result;
    }
  }
}