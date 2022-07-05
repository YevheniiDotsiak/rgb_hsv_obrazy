
namespace ApoEgz
{
    partial class PlotChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlotChartForm));
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBottom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTop
            // 
            this.chartTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTop.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartTop.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTop.Legends.Add(legend1);
            this.chartTop.Location = new System.Drawing.Point(12, 12);
            this.chartTop.Name = "chartTop";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTop.Series.Add(series1);
            this.chartTop.Size = new System.Drawing.Size(960, 300);
            this.chartTop.TabIndex = 0;
            this.chartTop.Text = "chart1";
            // 
            // chartMid
            // 
            this.chartMid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMid.BackColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.chartMid.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMid.Legends.Add(legend2);
            this.chartMid.Location = new System.Drawing.Point(12, 330);
            this.chartMid.Name = "chartMid";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMid.Series.Add(series2);
            this.chartMid.Size = new System.Drawing.Size(960, 300);
            this.chartMid.TabIndex = 1;
            this.chartMid.Text = "chart2";
            // 
            // chartBottom
            // 
            this.chartBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBottom.BackColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.chartBottom.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBottom.Legends.Add(legend3);
            this.chartBottom.Location = new System.Drawing.Point(12, 649);
            this.chartBottom.Name = "chartBottom";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartBottom.Series.Add(series3);
            this.chartBottom.Size = new System.Drawing.Size(960, 300);
            this.chartBottom.TabIndex = 2;
            this.chartBottom.Text = "chart3";
            // 
            // PlotChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.chartBottom);
            this.Controls.Add(this.chartMid);
            this.Controls.Add(this.chartTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlotChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlotChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartMid;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartBottom;
    }
}