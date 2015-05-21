namespace TaskPartitionTest
{
    partial class frmGraphics
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
            this.chtGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prbDEProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // chtGraphics
            // 
            chartArea1.Name = "ChartArea1";
            this.chtGraphics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtGraphics.Legends.Add(legend1);
            this.chtGraphics.Location = new System.Drawing.Point(12, 22);
            this.chtGraphics.Name = "chtGraphics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtGraphics.Series.Add(series1);
            this.chtGraphics.Size = new System.Drawing.Size(705, 295);
            this.chtGraphics.TabIndex = 0;
            this.chtGraphics.Text = "chart1";
            // 
            // prbDEProgress
            // 
            this.prbDEProgress.Location = new System.Drawing.Point(0, 394);
            this.prbDEProgress.Name = "prbDEProgress";
            this.prbDEProgress.Size = new System.Drawing.Size(729, 14);
            this.prbDEProgress.TabIndex = 1;
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 326);
            this.Controls.Add(this.prbDEProgress);
            this.Controls.Add(this.chtGraphics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGraphics";
            this.Text = "Task Partitioning Evolution";
            this.Load += new System.EventHandler(this.frmGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraphics;
        private System.Windows.Forms.ProgressBar prbDEProgress;
    }
}