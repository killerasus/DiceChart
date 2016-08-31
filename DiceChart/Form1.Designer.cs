namespace DiceChart
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.diceNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.diceType = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.diceHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.diceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // diceNumber
            // 
            this.diceNumber.Location = new System.Drawing.Point(66, 40);
            this.diceNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.diceNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diceNumber.Name = "diceNumber";
            this.diceNumber.Size = new System.Drawing.Size(35, 20);
            this.diceNumber.TabIndex = 1;
            this.diceNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Die: d";
            // 
            // diceType
            // 
            this.diceType.Items.Add("2");
            this.diceType.Items.Add("3");
            this.diceType.Items.Add("4");
            this.diceType.Items.Add("6");
            this.diceType.Items.Add("8");
            this.diceType.Items.Add("10");
            this.diceType.Items.Add("12");
            this.diceType.Items.Add("20");
            this.diceType.Items.Add("24");
            this.diceType.Items.Add("30");
            this.diceType.Items.Add("100");
            this.diceType.Location = new System.Drawing.Point(149, 40);
            this.diceType.Name = "diceType";
            this.diceType.Size = new System.Drawing.Size(63, 20);
            this.diceType.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diceHistogram
            // 
            chartArea2.Name = "ChartArea1";
            this.diceHistogram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.diceHistogram.Legends.Add(legend2);
            this.diceHistogram.Location = new System.Drawing.Point(12, 68);
            this.diceHistogram.Name = "diceHistogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.diceHistogram.Series.Add(series2);
            this.diceHistogram.Size = new System.Drawing.Size(530, 316);
            this.diceHistogram.TabIndex = 5;
            this.diceHistogram.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Controls.Add(this.diceHistogram);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diceNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dice Chart";
            ((System.ComponentModel.ISupportInitialize)(this.diceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown diceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown diceType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart diceHistogram;
    }
}

