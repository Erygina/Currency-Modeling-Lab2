namespace currencyModeling
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intialPriceLabel = new System.Windows.Forms.Label();
            this.euroEd = new System.Windows.Forms.NumericUpDown();
            this.dollarEd = new System.Windows.Forms.NumericUpDown();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.euroEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startStopBtn);
            this.panel1.Controls.Add(this.dollarEd);
            this.panel1.Controls.Add(this.euroEd);
            this.panel1.Controls.Add(this.intialPriceLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 79);
            this.panel1.TabIndex = 0;
            // 
            // intialPriceLabel
            // 
            this.intialPriceLabel.AutoSize = true;
            this.intialPriceLabel.Location = new System.Drawing.Point(12, 25);
            this.intialPriceLabel.Name = "intialPriceLabel";
            this.intialPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.intialPriceLabel.TabIndex = 0;
            this.intialPriceLabel.Text = "Initial price";
            // 
            // euroEd
            // 
            this.euroEd.DecimalPlaces = 2;
            this.euroEd.Location = new System.Drawing.Point(85, 23);
            this.euroEd.Name = "euroEd";
            this.euroEd.Size = new System.Drawing.Size(82, 20);
            this.euroEd.TabIndex = 1;
            this.euroEd.Value = new decimal(new int[] {
            8005,
            0,
            0,
            131072});
            // 
            // dollarEd
            // 
            this.dollarEd.DecimalPlaces = 2;
            this.dollarEd.Location = new System.Drawing.Point(189, 23);
            this.dollarEd.Name = "dollarEd";
            this.dollarEd.Size = new System.Drawing.Size(82, 20);
            this.dollarEd.TabIndex = 2;
            this.dollarEd.Value = new decimal(new int[] {
            7546,
            0,
            0,
            131072});
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(346, 23);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(75, 23);
            this.startStopBtn.TabIndex = 3;
            this.startStopBtn.Text = "Start/Stop";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 60D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 79);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "C";
            series1.Legend = "Legend1";
            series1.Name = "Euro";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "C";
            series2.Legend = "Legend1";
            series2.Name = "$";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(822, 513);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 592);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.euroEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.NumericUpDown dollarEd;
        private System.Windows.Forms.NumericUpDown euroEd;
        private System.Windows.Forms.Label intialPriceLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

