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
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrimes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFactorize)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Location = new System.Drawing.Point(44, 31);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(286, 28);
      this.buttonCalculate.TabIndex = 0;
      this.buttonCalculate.Text = "List primes";
      this.buttonCalculate.UseVisualStyleBackColor = true;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // listBoxPrime
      // 
      this.listBoxPrime.FormattingEnabled = true;
      this.listBoxPrime.ItemHeight = 16;
      this.listBoxPrime.Location = new System.Drawing.Point(44, 100);
      this.listBoxPrime.Name = "listBoxPrime";
      this.listBoxPrime.Size = new System.Drawing.Size(286, 708);
      this.listBoxPrime.TabIndex = 1;
      // 
      // listBoxFactorizeNumbers
      // 
      this.listBoxFactorizeNumbers.FormattingEnabled = true;
      this.listBoxFactorizeNumbers.ItemHeight = 16;
      this.listBoxFactorizeNumbers.Location = new System.Drawing.Point(371, 100);
      this.listBoxFactorizeNumbers.Name = "listBoxFactorizeNumbers";
      this.listBoxFactorizeNumbers.Size = new System.Drawing.Size(286, 708);
      this.listBoxFactorizeNumbers.TabIndex = 3;
      // 
      // buttonFactorize
      // 
      this.buttonFactorize.Location = new System.Drawing.Point(371, 31);
      this.buttonFactorize.Name = "buttonFactorize";
      this.buttonFactorize.Size = new System.Drawing.Size(286, 28);
      this.buttonFactorize.TabIndex = 2;
      this.buttonFactorize.Text = "Factorize numbers";
      this.buttonFactorize.UseVisualStyleBackColor = true;
      this.buttonFactorize.Click += new System.EventHandler(this.buttonFactorize_Click);
      // 
      // labelCounterPrimes
      // 
      this.labelCounterPrimes.AutoSize = true;
      this.labelCounterPrimes.Location = new System.Drawing.Point(44, 814);
      this.labelCounterPrimes.Name = "labelCounterPrimes";
      this.labelCounterPrimes.Size = new System.Drawing.Size(74, 17);
      this.labelCounterPrimes.TabIndex = 4;
      this.labelCounterPrimes.Text = "Counter: 0";
      // 
      // labelCounterFactorizeNumbers
      // 
      this.labelCounterFactorizeNumbers.AutoSize = true;
      this.labelCounterFactorizeNumbers.Location = new System.Drawing.Point(368, 814);
      this.labelCounterFactorizeNumbers.Name = "labelCounterFactorizeNumbers";
      this.labelCounterFactorizeNumbers.Size = new System.Drawing.Size(74, 17);
      this.labelCounterFactorizeNumbers.TabIndex = 5;
      this.labelCounterFactorizeNumbers.Text = "Counter: 0";
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBar1.Location = new System.Drawing.Point(0, 859);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(718, 23);
      this.progressBar1.TabIndex = 6;
      // 
      // numericUpDownPrimes
      // 
      this.numericUpDownPrimes.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDownPrimes.Location = new System.Drawing.Point(47, 66);
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
      this.numericUpDownPrimes.Size = new System.Drawing.Size(283, 22);
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
      this.numericUpDownFactorize.Location = new System.Drawing.Point(374, 66);
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
      this.numericUpDownFactorize.Size = new System.Drawing.Size(283, 22);
      this.numericUpDownFactorize.TabIndex = 8;
      this.numericUpDownFactorize.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(718, 882);
      this.Controls.Add(this.numericUpDownFactorize);
      this.Controls.Add(this.numericUpDownPrimes);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.labelCounterFactorizeNumbers);
      this.Controls.Add(this.labelCounterPrimes);
      this.Controls.Add(this.listBoxFactorizeNumbers);
      this.Controls.Add(this.buttonFactorize);
      this.Controls.Add(this.listBoxPrime);
      this.Controls.Add(this.buttonCalculate);
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
  }
}

