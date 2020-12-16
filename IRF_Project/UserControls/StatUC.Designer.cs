namespace IRF_Project
{
    partial class StatUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BackColor = System.Drawing.Color.Firebrick;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsInterlaced = true;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.BackColor = System.Drawing.Color.LawnGreen;
            chartArea1.BorderColor = System.Drawing.Color.Blue;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Gólok";
            series1.XValueMember = "Nev";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueMembers = "Gol";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Asszisztok";
            series2.XValueMember = "Nev";
            series2.YValueMembers = "Golpassz";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(853, 620);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(852, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 398);
            this.dataGridView1.TabIndex = 7;
            // 
            // StatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StatUC";
            this.Size = new System.Drawing.Size(1300, 650);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
