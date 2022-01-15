namespace Food.NewFolder1
{
    partial class FormReporting
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tctReport = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.dgvProductsSold = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chtSellingProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chtDeepCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chtTotalRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tctReport.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSold)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtSellingProduct)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDeepCustomers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // tctReport
            // 
            this.tctReport.Controls.Add(this.tabPage1);
            this.tctReport.Controls.Add(this.tabPage3);
            this.tctReport.Controls.Add(this.tabPage4);
            this.tctReport.Controls.Add(this.tabPage5);
            this.tctReport.Location = new System.Drawing.Point(3, 38);
            this.tctReport.Margin = new System.Windows.Forms.Padding(4);
            this.tctReport.Name = "tctReport";
            this.tctReport.SelectedIndex = 0;
            this.tctReport.Size = new System.Drawing.Size(1438, 757);
            this.tctReport.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnStatistical);
            this.tabPage1.Controls.Add(this.dtpStart);
            this.tabPage1.Controls.Add(this.dtpFinish);
            this.tabPage1.Controls.Add(this.dgvProductsSold);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1430, 728);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PRODUCTS SOLD";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(836, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "To date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Since:";
            // 
            // btnStatistical
            // 
            this.btnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.Location = new System.Drawing.Point(12, 5);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(156, 42);
            this.btnStatistical.TabIndex = 4;
            this.btnStatistical.Text = "Statistical";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(643, 9);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(164, 29);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFinish
            // 
            this.dtpFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinish.Location = new System.Drawing.Point(923, 8);
            this.dtpFinish.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(164, 29);
            this.dtpFinish.TabIndex = 3;
            this.dtpFinish.Value = new System.DateTime(2021, 12, 30, 0, 0, 0, 0);
            this.dtpFinish.ValueChanged += new System.EventHandler(this.dtpFinish_ValueChanged);
            // 
            // dgvProductsSold
            // 
            this.dgvProductsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsSold.Location = new System.Drawing.Point(4, 54);
            this.dgvProductsSold.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductsSold.Name = "dgvProductsSold";
            this.dgvProductsSold.RowHeadersWidth = 51;
            this.dgvProductsSold.Size = new System.Drawing.Size(1426, 678);
            this.dgvProductsSold.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chtSellingProduct);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1430, 728);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SELLING PRODUCTS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chtSellingProduct
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "QUANTITY";
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chtSellingProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtSellingProduct.Legends.Add(legend1);
            this.chtSellingProduct.Location = new System.Drawing.Point(0, 0);
            this.chtSellingProduct.Margin = new System.Windows.Forms.Padding(4);
            this.chtSellingProduct.Name = "chtSellingProduct";
            this.chtSellingProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "PRODUCTS SOLD";
            series1.YValuesPerPoint = 2;
            this.chtSellingProduct.Series.Add(series1);
            this.chtSellingProduct.Size = new System.Drawing.Size(1426, 724);
            this.chtSellingProduct.TabIndex = 0;
            this.chtSellingProduct.Text = "Ch";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "TitlePS";
            title1.Text = "SELLING PRODUCTS CHART";
            this.chtSellingProduct.Titles.Add(title1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chtDeepCustomers);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1430, 728);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "DEEP CUSTOMERS";
            // 
            // chtDeepCustomers
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea2.AxisY.LabelStyle.Format = "#,##";
            chartArea2.AxisY.Title = "AMOUNT OF MONEY";
            chartArea2.Name = "ChartArea1";
            this.chtDeepCustomers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtDeepCustomers.Legends.Add(legend2);
            this.chtDeepCustomers.Location = new System.Drawing.Point(0, 0);
            this.chtDeepCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.chtDeepCustomers.Name = "chtDeepCustomers";
            this.chtDeepCustomers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#,##";
            series2.Legend = "Legend1";
            series2.Name = "CUSTOMERS";
            this.chtDeepCustomers.Series.Add(series2);
            this.chtDeepCustomers.Size = new System.Drawing.Size(1426, 707);
            this.chtDeepCustomers.TabIndex = 0;
            this.chtDeepCustomers.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "tlt";
            title2.Text = "DEEP CUSTOMERS CHART";
            this.chtDeepCustomers.Titles.Add(title2);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chtTotalRevenue);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1430, 728);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "TOTAL REVENUE";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chtTotalRevenue
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.Format = "#,##";
            chartArea3.Name = "ChartArea1";
            this.chtTotalRevenue.ChartAreas.Add(chartArea3);
            legend3.BorderWidth = 2;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtTotalRevenue.Legends.Add(legend3);
            this.chtTotalRevenue.Location = new System.Drawing.Point(4, 4);
            this.chtTotalRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.chtTotalRevenue.Name = "chtTotalRevenue";
            this.chtTotalRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chtTotalRevenue.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DarkRed};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.LabelBorderWidth = 3;
            series3.LabelFormat = "#,##";
            series3.Legend = "Legend1";
            series3.Name = "REVENUE";
            this.chtTotalRevenue.Series.Add(series3);
            this.chtTotalRevenue.Size = new System.Drawing.Size(1416, 479);
            this.chtTotalRevenue.TabIndex = 0;
            this.chtTotalRevenue.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "TOTAL REVENUE BY THE TIME CHART";
            this.chtTotalRevenue.Titles.Add(title3);
            this.chtTotalRevenue.Click += new System.EventHandler(this.chtTotalRevenue_Click);
            // 
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1440, 757);
            this.Controls.Add(this.tctReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReporting";
            this.Text = "REPORT";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            this.tctReport.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSold)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtSellingProduct)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtDeepCustomers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctReport;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvProductsSold;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSellingProduct;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDeepCustomers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTotalRevenue;
    }
}