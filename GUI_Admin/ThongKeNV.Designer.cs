
namespace QLThuVien.GUI_Admin
{
    partial class ThongKeNV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gunaPanel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.chartDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.circleProcessPercent = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lbP_sanco = new System.Windows.Forms.Label();
            this.lbP_muon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDG)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.gunaPanel5.BorderRadius = 30;
            this.gunaPanel5.BorderThickness = 1;
            this.gunaPanel5.Controls.Add(this.chartDG);
            this.gunaPanel5.Controls.Add(this.label14);
            this.gunaPanel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaPanel5.Location = new System.Drawing.Point(28, 26);
            this.gunaPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(586, 408);
            this.gunaPanel5.TabIndex = 21;
            // 
            // chartDG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDG.Legends.Add(legend1);
            this.chartDG.Location = new System.Drawing.Point(47, 57);
            this.chartDG.Margin = new System.Windows.Forms.Padding(4);
            this.chartDG.Name = "chartDG";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "TienCoc";
            this.chartDG.Series.Add(series1);
            this.chartDG.Size = new System.Drawing.Size(501, 319);
            this.chartDG.TabIndex = 22;
            this.chartDG.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label14.Location = new System.Drawing.Point(42, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(328, 30);
            this.label14.TabIndex = 18;
            this.label14.Text = "Thống kê tiền cọc theo tháng";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.BorderRadius = 30;
            this.gunaPanel1.BorderThickness = 1;
            this.gunaPanel1.Controls.Add(this.chart1);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaPanel1.Location = new System.Drawing.Point(28, 463);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1151, 389);
            this.gunaPanel1.TabIndex = 23;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(47, 81);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "SoLuong";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(961, 283);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thống kê số lượng sách từng thể loại";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.BorderRadius = 30;
            this.gunaPanel2.BorderThickness = 1;
            this.gunaPanel2.Controls.Add(this.btnRp);
            this.gunaPanel2.Controls.Add(this.guna2CircleButton2);
            this.gunaPanel2.Controls.Add(this.guna2CircleButton1);
            this.gunaPanel2.Controls.Add(this.circleProcessPercent);
            this.gunaPanel2.Controls.Add(this.lbP_sanco);
            this.gunaPanel2.Controls.Add(this.lbP_muon);
            this.gunaPanel2.Controls.Add(this.label2);
            this.gunaPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaPanel2.Location = new System.Drawing.Point(632, 26);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(547, 408);
            this.gunaPanel2.TabIndex = 23;
            // 
            // btnRp
            // 
            this.btnRp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRp.ForeColor = System.Drawing.Color.White;
            this.btnRp.Location = new System.Drawing.Point(0, 375);
            this.btnRp.Name = "btnRp";
            this.btnRp.Size = new System.Drawing.Size(547, 37);
            this.btnRp.TabIndex = 23;
            this.btnRp.Text = "Báo cáo thống kê lượt mượn trên mỗi đầu sách";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Gray;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(44, 106);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton2.TabIndex = 36;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(44, 69);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton1.TabIndex = 35;
            // 
            // circleProcessPercent
            // 
            this.circleProcessPercent.AnimationSpeed = 1F;
            this.circleProcessPercent.BackColor = System.Drawing.Color.Transparent;
            this.circleProcessPercent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.circleProcessPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.circleProcessPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleProcessPercent.Location = new System.Drawing.Point(251, 127);
            this.circleProcessPercent.Margin = new System.Windows.Forms.Padding(4);
            this.circleProcessPercent.Minimum = 0;
            this.circleProcessPercent.Name = "circleProcessPercent";
            this.circleProcessPercent.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.circleProcessPercent.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.circleProcessPercent.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.circleProcessPercent.Size = new System.Drawing.Size(245, 245);
            this.circleProcessPercent.TabIndex = 32;
            this.circleProcessPercent.Text = "30";
            this.circleProcessPercent.Value = 30;
            // 
            // lbP_sanco
            // 
            this.lbP_sanco.AutoSize = true;
            this.lbP_sanco.BackColor = System.Drawing.Color.Transparent;
            this.lbP_sanco.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP_sanco.ForeColor = System.Drawing.Color.DimGray;
            this.lbP_sanco.Location = new System.Drawing.Point(77, 57);
            this.lbP_sanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP_sanco.Name = "lbP_sanco";
            this.lbP_sanco.Size = new System.Drawing.Size(156, 25);
            this.lbP_sanco.TabIndex = 33;
            this.lbP_sanco.Text = "Số sách chưa trả";
            // 
            // lbP_muon
            // 
            this.lbP_muon.AutoSize = true;
            this.lbP_muon.BackColor = System.Drawing.Color.Transparent;
            this.lbP_muon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP_muon.ForeColor = System.Drawing.Color.DimGray;
            this.lbP_muon.Location = new System.Drawing.Point(77, 94);
            this.lbP_muon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP_muon.Name = "lbP_muon";
            this.lbP_muon.Size = new System.Drawing.Size(164, 25);
            this.lbP_muon.TabIndex = 34;
            this.lbP_muon.Text = "Số sách đã mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số sách chưa trả với số sách đã cho mượn";
            // 
            // ThongKeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel5);
            this.Name = "ThongKeNV";
            this.Size = new System.Drawing.Size(1211, 856);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDG)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gunaPanel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDG;
        private Guna.UI2.WinForms.Guna2Panel gunaPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel gunaPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProcessPercent;
        private System.Windows.Forms.Label lbP_sanco;
        private System.Windows.Forms.Label lbP_muon;
        private Guna.UI2.WinForms.Guna2Button btnRp;
    }
}
