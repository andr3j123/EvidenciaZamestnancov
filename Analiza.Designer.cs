namespace EvidenciaZamestnancov
{
    partial class Analiza
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
            this.izlazBtn = new System.Windows.Forms.Button();
            this.statistikaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // izlazBtn
            // 
            this.izlazBtn.Image = global::EvidenciaZamestnancov.Properties.Resources.icons8_power_button_50;
            this.izlazBtn.Location = new System.Drawing.Point(713, 375);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(75, 63);
            this.izlazBtn.TabIndex = 0;
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // statistikaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statistikaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statistikaChart.Legends.Add(legend1);
            this.statistikaChart.Location = new System.Drawing.Point(12, 12);
            this.statistikaChart.Name = "statistikaChart";
            this.statistikaChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statistikaChart.Series.Add(series1);
            this.statistikaChart.Size = new System.Drawing.Size(673, 426);
            this.statistikaChart.TabIndex = 1;
            this.statistikaChart.Text = "chart1";
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statistikaChart);
            this.Controls.Add(this.izlazBtn);
            this.Name = "Analiza";
            this.Text = "Analiza";
            ((System.ComponentModel.ISupportInitialize)(this.statistikaChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izlazBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart statistikaChart;
    }
}