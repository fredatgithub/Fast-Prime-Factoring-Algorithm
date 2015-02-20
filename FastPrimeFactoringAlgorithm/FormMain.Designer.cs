namespace FastPrimeFactoringAlgorithm
{
  partial class FormMain
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
      this.buttonCalculate = new System.Windows.Forms.Button();
      this.listBoxPrime = new System.Windows.Forms.ListBox();
      this.listBoxFactorizeNumbers = new System.Windows.Forms.ListBox();
      this.buttonFactorize = new System.Windows.Forms.Button();
      this.labelCounterPrimes = new System.Windows.Forms.Label();
      this.labelCounterFactorizeNumbers = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.numericUpDownPrimes = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownFactorize = new System.Windows.Forms.NumericUpDown();
      this.labelDurationPrimes = new System.Windows.Forms.Label();
      this.labelDurationFactorize = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactorize)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Location = new System.Drawing.Point(33, 25);
      this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(126, 23);
      this.buttonCalculate.TabIndex = 0;
      this.buttonCalculate.Text = "List primes";
      this.buttonCalculate.UseVisualStyleBackColor = true;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // listBoxPrime
      // 
      this.listBoxPrime.FormattingEnabled = true;
      this.listBoxPrime.Location = new System.Drawing.Point(33, 81);
      this.listBoxPrime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.listBoxPrime.Name = "listBoxPrime";
      this.listBoxPrime.Size = new System.Drawing.Size(128, 576);
      this.listBoxPrime.TabIndex = 1;
      // 
      // listBoxFactorizeNumbers
      // 
      this.listBoxFactorizeNumbers.FormattingEnabled = true;
      this.listBoxFactorizeNumbers.Location = new System.Drawing.Point(195, 81);
      this.listBoxFactorizeNumbers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.listBoxFactorizeNumbers.Name = "listBoxFactorizeNumbers";
      this.listBoxFactorizeNumbers.Size = new System.Drawing.Size(451, 576);
      this.listBoxFactorizeNumbers.TabIndex = 3;
      // 
      // buttonFactorize
      // 
      this.buttonFactorize.Location = new System.Drawing.Point(195, 25);
      this.buttonFactorize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonFactorize.Name = "buttonFactorize";
      this.buttonFactorize.Size = new System.Drawing.Size(451, 23);
      this.buttonFactorize.TabIndex = 2;
      this.buttonFactorize.Text = "Factorize numbers";
      this.buttonFactorize.UseVisualStyleBackColor = true;
      this.buttonFactorize.Click += new System.EventHandler(this.buttonFactorize_Click);
      // 
      // labelCounterPrimes
      // 
      this.labelCounterPrimes.AutoSize = true;
      this.labelCounterPrimes.Location = new System.Drawing.Point(33, 661);
      this.labelCounterPrimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelCounterPrimes.Name = "labelCounterPrimes";
      this.labelCounterPrimes.Size = new System.Drawing.Size(56, 13);
      this.labelCounterPrimes.TabIndex = 4;
      this.labelCounterPrimes.Text = "Counter: 0";
      // 
      // labelCounterFactorizeNumbers
      // 
      this.labelCounterFactorizeNumbers.AutoSize = true;
      this.labelCounterFactorizeNumbers.Location = new System.Drawing.Point(193, 661);
      this.labelCounterFactorizeNumbers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelCounterFactorizeNumbers.Name = "labelCounterFactorizeNumbers";
      this.labelCounterFactorizeNumbers.Size = new System.Drawing.Size(56, 13);
      this.labelCounterFactorizeNumbers.TabIndex = 5;
      this.labelCounterFactorizeNumbers.Text = "Counter: 0";
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBar1.Location = new System.Drawing.Point(0, 733);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(673, 19);
      this.progressBar1.TabIndex = 6;
      // 
      // numericUpDownPrimes
      // 
      this.numericUpDownPrimes.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDownPrimes.Location = new System.Drawing.Point(35, 54);
      this.numericUpDownPrimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.numericUpDownPrimes.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.numericUpDownPrimes.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDownPrimes.Name = "numericUpDownPrimes";
      this.numericUpDownPrimes.Size = new System.Drawing.Size(124, 20);
      this.numericUpDownPrimes.TabIndex = 7;
      this.numericUpDownPrimes.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      // 
      // numericUpDownFactorize
      // 
      this.numericUpDownFactorize.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDownFactorize.Location = new System.Drawing.Point(197, 54);
      this.numericUpDownFactorize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.numericUpDownFactorize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.numericUpDownFactorize.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDownFactorize.Name = "numericUpDownFactorize";
      this.numericUpDownFactorize.Size = new System.Drawing.Size(449, 20);
      this.numericUpDownFactorize.TabIndex = 8;
      this.numericUpDownFactorize.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      // 
      // labelDurationPrimes
      // 
      this.labelDurationPrimes.AutoSize = true;
      this.labelDurationPrimes.Location = new System.Drawing.Point(33, 687);
      this.labelDurationPrimes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelDurationPrimes.Name = "labelDurationPrimes";
      this.labelDurationPrimes.Size = new System.Drawing.Size(50, 13);
      this.labelDurationPrimes.TabIndex = 9;
      this.labelDurationPrimes.Text = "Duration:";
      // 
      // labelDurationFactorize
      // 
      this.labelDurationFactorize.AutoSize = true;
      this.labelDurationFactorize.Location = new System.Drawing.Point(192, 687);
      this.labelDurationFactorize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelDurationFactorize.Name = "labelDurationFactorize";
      this.labelDurationFactorize.Size = new System.Drawing.Size(50, 13);
      this.labelDurationFactorize.TabIndex = 10;
      this.labelDurationFactorize.Text = "Duration:";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 752);
      this.Controls.Add(this.labelDurationFactorize);
      this.Controls.Add(this.labelDurationPrimes);
      this.Controls.Add(this.numericUpDownFactorize);
      this.Controls.Add(this.numericUpDownPrimes);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.labelCounterFactorizeNumbers);
      this.Controls.Add(this.labelCounterPrimes);
      this.Controls.Add(this.listBoxFactorizeNumbers);
      this.Controls.Add(this.buttonFactorize);
      this.Controls.Add(this.listBoxPrime);
      this.Controls.Add(this.buttonCalculate);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Fast Prime Factoring Algorithm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactorize)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCalculate;
    private System.Windows.Forms.ListBox listBoxPrime;
    private System.Windows.Forms.ListBox listBoxFactorizeNumbers;
    private System.Windows.Forms.Button buttonFactorize;
    private System.Windows.Forms.Label labelCounterPrimes;
    private System.Windows.Forms.Label labelCounterFactorizeNumbers;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.NumericUpDown numericUpDownPrimes;
    private System.Windows.Forms.NumericUpDown numericUpDownFactorize;
    private System.Windows.Forms.Label labelDurationPrimes;
    private System.Windows.Forms.Label labelDurationFactorize;
  }
}

