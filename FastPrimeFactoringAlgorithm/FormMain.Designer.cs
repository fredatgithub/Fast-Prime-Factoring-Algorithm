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
      this.numericUpDownPrimesFrom = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownFactorize = new System.Windows.Forms.NumericUpDown();
      this.labelDurationPrimes = new System.Windows.Forms.Label();
      this.labelDurationFactorize = new System.Windows.Forms.Label();
      this.buttonSaveToText = new System.Windows.Forms.Button();
      this.labelFrom = new System.Windows.Forms.Label();
      this.labelTo = new System.Windows.Forms.Label();
      this.numericUpDownPrimesTo = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimesFrom)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactorize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimesTo)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Location = new System.Drawing.Point(33, 25);
      this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
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
      this.listBoxPrime.Location = new System.Drawing.Point(33, 172);
      this.listBoxPrime.Margin = new System.Windows.Forms.Padding(2);
      this.listBoxPrime.Name = "listBoxPrime";
      this.listBoxPrime.Size = new System.Drawing.Size(128, 485);
      this.listBoxPrime.TabIndex = 1;
      // 
      // listBoxFactorizeNumbers
      // 
      this.listBoxFactorizeNumbers.FormattingEnabled = true;
      this.listBoxFactorizeNumbers.Location = new System.Drawing.Point(195, 81);
      this.listBoxFactorizeNumbers.Margin = new System.Windows.Forms.Padding(2);
      this.listBoxFactorizeNumbers.Name = "listBoxFactorizeNumbers";
      this.listBoxFactorizeNumbers.Size = new System.Drawing.Size(451, 576);
      this.listBoxFactorizeNumbers.TabIndex = 3;
      // 
      // buttonFactorize
      // 
      this.buttonFactorize.Location = new System.Drawing.Point(195, 25);
      this.buttonFactorize.Margin = new System.Windows.Forms.Padding(2);
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
      this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(673, 19);
      this.progressBar1.TabIndex = 6;
      // 
      // numericUpDownPrimesFrom
      // 
      this.numericUpDownPrimesFrom.Location = new System.Drawing.Point(37, 81);
      this.numericUpDownPrimesFrom.Margin = new System.Windows.Forms.Padding(2);
      this.numericUpDownPrimesFrom.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numericUpDownPrimesFrom.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.numericUpDownPrimesFrom.Name = "numericUpDownPrimesFrom";
      this.numericUpDownPrimesFrom.Size = new System.Drawing.Size(124, 20);
      this.numericUpDownPrimesFrom.TabIndex = 7;
      this.numericUpDownPrimesFrom.Value = new decimal(new int[] {
            3,
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
      this.numericUpDownFactorize.Margin = new System.Windows.Forms.Padding(2);
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
      // buttonSaveToText
      // 
      this.buttonSaveToText.Location = new System.Drawing.Point(35, 706);
      this.buttonSaveToText.Margin = new System.Windows.Forms.Padding(2);
      this.buttonSaveToText.Name = "buttonSaveToText";
      this.buttonSaveToText.Size = new System.Drawing.Size(126, 23);
      this.buttonSaveToText.TabIndex = 11;
      this.buttonSaveToText.Text = "Save to text";
      this.buttonSaveToText.UseVisualStyleBackColor = true;
      this.buttonSaveToText.Click += new System.EventHandler(this.buttonSaveToText_Click);
      // 
      // labelFrom
      // 
      this.labelFrom.AutoSize = true;
      this.labelFrom.Location = new System.Drawing.Point(34, 61);
      this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelFrom.Name = "labelFrom";
      this.labelFrom.Size = new System.Drawing.Size(33, 13);
      this.labelFrom.TabIndex = 12;
      this.labelFrom.Text = "From:";
      // 
      // labelTo
      // 
      this.labelTo.AutoSize = true;
      this.labelTo.Location = new System.Drawing.Point(34, 114);
      this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.labelTo.Name = "labelTo";
      this.labelTo.Size = new System.Drawing.Size(23, 13);
      this.labelTo.TabIndex = 14;
      this.labelTo.Text = "To:";
      // 
      // numericUpDownPrimesTo
      // 
      this.numericUpDownPrimesTo.Location = new System.Drawing.Point(37, 134);
      this.numericUpDownPrimesTo.Margin = new System.Windows.Forms.Padding(2);
      this.numericUpDownPrimesTo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numericUpDownPrimesTo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.numericUpDownPrimesTo.Name = "numericUpDownPrimesTo";
      this.numericUpDownPrimesTo.Size = new System.Drawing.Size(124, 20);
      this.numericUpDownPrimesTo.TabIndex = 13;
      this.numericUpDownPrimesTo.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 752);
      this.Controls.Add(this.labelTo);
      this.Controls.Add(this.numericUpDownPrimesTo);
      this.Controls.Add(this.labelFrom);
      this.Controls.Add(this.buttonSaveToText);
      this.Controls.Add(this.labelDurationFactorize);
      this.Controls.Add(this.labelDurationPrimes);
      this.Controls.Add(this.numericUpDownFactorize);
      this.Controls.Add(this.numericUpDownPrimesFrom);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.labelCounterFactorizeNumbers);
      this.Controls.Add(this.labelCounterPrimes);
      this.Controls.Add(this.listBoxFactorizeNumbers);
      this.Controls.Add(this.buttonFactorize);
      this.Controls.Add(this.listBoxPrime);
      this.Controls.Add(this.buttonCalculate);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Fast Prime Factoring Algorithm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimesFrom)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactorize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimesTo)).EndInit();
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
    private System.Windows.Forms.NumericUpDown numericUpDownPrimesFrom;
    private System.Windows.Forms.NumericUpDown numericUpDownFactorize;
    private System.Windows.Forms.Label labelDurationPrimes;
    private System.Windows.Forms.Label labelDurationFactorize;
    private System.Windows.Forms.Button buttonSaveToText;
    private System.Windows.Forms.Label labelFrom;
    private System.Windows.Forms.Label labelTo;
    private System.Windows.Forms.NumericUpDown numericUpDownPrimesTo;
  }
}

