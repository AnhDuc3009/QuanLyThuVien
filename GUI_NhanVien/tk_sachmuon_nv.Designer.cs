
namespace QLThuVien.GUI_NhanVien
{
    partial class tk_sachmuon_nv
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.charttk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_tksachmuon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.filter2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.filter1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaPanel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSachMoi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charttk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tksachmuon)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(533, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê sách mượn";
            // 
            // charttk
            // 
            this.charttk.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.charttk.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charttk.Legends.Add(legend1);
            this.charttk.Location = new System.Drawing.Point(800, 179);
            this.charttk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.charttk.Name = "charttk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Chart1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.charttk.Series.Add(series1);
            this.charttk.Size = new System.Drawing.Size(466, 287);
            this.charttk.TabIndex = 3;
            this.charttk.Text = "chart1";
            title1.Name = "Title1";
            title2.Name = "Title2";
            this.charttk.Titles.Add(title1);
            this.charttk.Titles.Add(title2);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(542, 98);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sách mượn ";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(271, 167);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chartTK";
            // 
            // dgv_tksachmuon
            // 
            this.dgv_tksachmuon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_tksachmuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tksachmuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tksachmuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tksachmuon.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tksachmuon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tksachmuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.Location = new System.Drawing.Point(14, 179);
            this.dgv_tksachmuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tksachmuon.Name = "dgv_tksachmuon";
            this.dgv_tksachmuon.ReadOnly = true;
            this.dgv_tksachmuon.RowHeadersVisible = false;
            this.dgv_tksachmuon.RowHeadersWidth = 51;
            this.dgv_tksachmuon.RowTemplate.Height = 40;
            this.dgv_tksachmuon.Size = new System.Drawing.Size(780, 633);
            this.dgv_tksachmuon.TabIndex = 6;
            this.dgv_tksachmuon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_tksachmuon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_tksachmuon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_tksachmuon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_tksachmuon.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tksachmuon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_tksachmuon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_tksachmuon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tksachmuon.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_tksachmuon.ThemeStyle.ReadOnly = true;
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_tksachmuon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // filter2
            // 
            this.filter2.BackColor = System.Drawing.Color.Transparent;
            this.filter2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter2.FocusedColor = System.Drawing.Color.Empty;
            this.filter2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filter2.FormattingEnabled = true;
            this.filter2.ItemHeight = 30;
            this.filter2.Items.AddRange(new object[] {
            "Trễ hạn",
            "Vi phạm"});
            this.filter2.Location = new System.Drawing.Point(470, 48);
            this.filter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(124, 36);
            this.filter2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(879, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(626, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Từ ngày";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(1114, 48);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(116, 48);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.filter1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtSearch);
            this.guna2CustomGradientPanel1.Controls.Add(this.dateEnd);
            this.guna2CustomGradientPanel1.Controls.Add(this.dateStart);
            this.guna2CustomGradientPanel1.Controls.Add(this.filter2);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTK);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(14, 52);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1252, 115);
            this.guna2CustomGradientPanel1.TabIndex = 9;
            // 
            // filter1
            // 
            this.filter1.BackColor = System.Drawing.Color.Transparent;
            this.filter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter1.FocusedColor = System.Drawing.Color.Empty;
            this.filter1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filter1.FormattingEnabled = true;
            this.filter1.ItemHeight = 30;
            this.filter1.Items.AddRange(new object[] {
            "Độc giả",
            "Đầu sách",
            "Thể loại",
            "Nhà xuất bản"});
            this.filter1.Location = new System.Drawing.Point(329, 49);
            this.filter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(135, 36);
            this.filter1.TabIndex = 18;
            this.filter1.SelectedIndexChanged += new System.EventHandler(this.filter1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(37, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(41, 49);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên độc giả hoặc mã độc giả";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(266, 44);
            this.txtSearch.TabIndex = 16;
            // 
            // dateEnd
            // 
            this.dateEnd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateEnd.Checked = true;
            this.dateEnd.CustomFormat = "dd/MM/yyyy";
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(883, 52);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateEnd.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(182, 44);
            this.dateEnd.TabIndex = 15;
            this.dateEnd.Value = new System.DateTime(2022, 11, 9, 21, 43, 14, 825);
            // 
            // dateStart
            // 
            this.dateStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateStart.Checked = true;
            this.dateStart.CustomFormat = "dd/MM/yyyy";
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(630, 52);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateStart.MinimumSize = new System.Drawing.Size(4, 44);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(172, 44);
            this.dateStart.TabIndex = 14;
            this.dateStart.Value = new System.DateTime(2022, 11, 9, 21, 43, 14, 869);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(325, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lọc theo";
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.gunaPanel5.BorderRadius = 30;
            this.gunaPanel5.BorderThickness = 1;
            this.gunaPanel5.Controls.Add(this.dgvSachMoi);
            this.gunaPanel5.Controls.Add(this.label14);
            this.gunaPanel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaPanel5.Location = new System.Drawing.Point(800, 472);
            this.gunaPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(465, 340);
            this.gunaPanel5.TabIndex = 21;
            // 
            // dgvSachMoi
            // 
            this.dgvSachMoi.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvSachMoi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSachMoi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachMoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSachMoi.ColumnHeadersHeight = 40;
            this.dgvSachMoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDG,
            this.SL});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachMoi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSachMoi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSachMoi.Location = new System.Drawing.Point(9, 61);
            this.dgvSachMoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSachMoi.Name = "dgvSachMoi";
            this.dgvSachMoi.ReadOnly = true;
            this.dgvSachMoi.RowHeadersVisible = false;
            this.dgvSachMoi.RowHeadersWidth = 51;
            this.dgvSachMoi.RowTemplate.Height = 40;
            this.dgvSachMoi.Size = new System.Drawing.Size(436, 258);
            this.dgvSachMoi.TabIndex = 19;
            this.dgvSachMoi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachMoi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSachMoi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSachMoi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSachMoi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSachMoi.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSachMoi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSachMoi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSachMoi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSachMoi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvSachMoi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSachMoi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSachMoi.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSachMoi.ThemeStyle.ReadOnly = true;
            this.dgvSachMoi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachMoi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSachMoi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvSachMoi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSachMoi.ThemeStyle.RowsStyle.Height = 40;
            this.dgvSachMoi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachMoi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã DG";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // TenDG
            // 
            this.TenDG.DataPropertyName = "TenDocGia";
            this.TenDG.HeaderText = "Tên độc giả";
            this.TenDG.MinimumWidth = 6;
            this.TenDG.Name = "TenDG";
            this.TenDG.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "sl";
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label14.Location = new System.Drawing.Point(4, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(420, 30);
            this.label14.TabIndex = 18;
            this.label14.Text = "Những độc giả mượn nhiều sách nhất";
            // 
            // tk_sachmuon_nv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gunaPanel5);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgv_tksachmuon);
            this.Controls.Add(this.charttk);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tk_sachmuon_nv";
            this.Size = new System.Drawing.Size(1281, 807);
            this.Load += new System.EventHandler(this.tk_sachmuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charttk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tksachmuon)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_tksachmuon;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox filter2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel gunaPanel5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSachMoi;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ComboBox filter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
    }
}
