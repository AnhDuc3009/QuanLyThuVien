﻿
namespace QLThuVien.GUI_NhanVien
{
    partial class TimKiem4NV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbSLBook = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnFindByTG = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindAll = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutDS = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvChooseBook = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreatePM = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnPreview = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseBook)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSLBook
            // 
            this.lbSLBook.AutoSize = true;
            this.lbSLBook.BackColor = System.Drawing.Color.Transparent;
            this.lbSLBook.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbSLBook.ForeColor = System.Drawing.Color.Red;
            this.lbSLBook.Location = new System.Drawing.Point(40, 36);
            this.lbSLBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSLBook.Name = "lbSLBook";
            this.lbSLBook.Size = new System.Drawing.Size(15, 23);
            this.lbSLBook.TabIndex = 45;
            this.lbSLBook.Text = ".";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindByTG);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindAll);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtSearch);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbTheLoai);
            this.guna2CustomGradientPanel2.Controls.Add(this.flowLayoutDS);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(9, 74);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(776, 828);
            this.guna2CustomGradientPanel2.TabIndex = 49;
            // 
            // btnFindByTG
            // 
            this.btnFindByTG.BackColor = System.Drawing.Color.Transparent;
            this.btnFindByTG.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFindByTG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindByTG.ForeColor = System.Drawing.Color.White;
            this.btnFindByTG.Location = new System.Drawing.Point(295, 14);
            this.btnFindByTG.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindByTG.Name = "btnFindByTG";
            this.btnFindByTG.Size = new System.Drawing.Size(187, 44);
            this.btnFindByTG.TabIndex = 40;
            this.btnFindByTG.Tag = "Tìm theo tên tác giả";
            this.btnFindByTG.Text = "Tìm theo tên tác giả";
            // 
            // btnFindAll
            // 
            this.btnFindAll.BackColor = System.Drawing.Color.Transparent;
            this.btnFindAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFindAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindAll.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.Location = new System.Drawing.Point(489, 14);
            this.btnFindAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(100, 44);
            this.btnFindAll.TabIndex = 39;
            this.btnFindAll.Text = "Tất cả";
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(20, 65);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên sách để tôi tìm cho bạn";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(553, 49);
            this.txtSearch.TabIndex = 35;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cbTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.ItemHeight = 30;
            this.cbTheLoai.Items.AddRange(new object[] {
            "Tất cả thể loại"});
            this.cbTheLoai.Location = new System.Drawing.Point(20, 14);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(265, 36);
            this.cbTheLoai.TabIndex = 37;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // flowLayoutDS
            // 
            this.flowLayoutDS.AutoScroll = true;
            this.flowLayoutDS.Location = new System.Drawing.Point(20, 123);
            this.flowLayoutDS.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutDS.MaximumSize = new System.Drawing.Size(903, 673);
            this.flowLayoutDS.Name = "flowLayoutDS";
            this.flowLayoutDS.Size = new System.Drawing.Size(741, 673);
            this.flowLayoutDS.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(618, 65);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 49);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label13.Location = new System.Drawing.Point(20, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 30);
            this.label13.TabIndex = 39;
            this.label13.Text = "Bạn đã chọn:";
            // 
            // dgvChooseBook
            // 
            this.dgvChooseBook.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvChooseBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChooseBook.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChooseBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChooseBook.ColumnHeadersHeight = 40;
            this.dgvChooseBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.ViTri,
            this.Remove});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChooseBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChooseBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.Location = new System.Drawing.Point(4, 92);
            this.dgvChooseBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChooseBook.Name = "dgvChooseBook";
            this.dgvChooseBook.ReadOnly = true;
            this.dgvChooseBook.RowHeadersVisible = false;
            this.dgvChooseBook.RowHeadersWidth = 51;
            this.dgvChooseBook.RowTemplate.Height = 40;
            this.dgvChooseBook.Size = new System.Drawing.Size(445, 524);
            this.dgvChooseBook.TabIndex = 36;
            this.dgvChooseBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChooseBook.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChooseBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChooseBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChooseBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChooseBook.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvChooseBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChooseBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvChooseBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChooseBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChooseBook.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvChooseBook.ThemeStyle.ReadOnly = true;
            this.dgvChooseBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChooseBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChooseBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvChooseBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChooseBook.ThemeStyle.RowsStyle.Height = 40;
            this.dgvChooseBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChooseBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChooseBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChooseBook_CellClick);
            // 
            // MaDauSach
            // 
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            // 
            // TenDauSach
            // 
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            // 
            // ViTri
            // 
            this.ViTri.DataPropertyName = "ViTri";
            this.ViTri.HeaderText = "Vị trí";
            this.ViTri.MinimumWidth = 6;
            this.ViTri.Name = "ViTri";
            this.ViTri.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Loại bỏ";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnExportExcel);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnCreatePM);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnClearAll);
            this.guna2CustomGradientPanel1.Controls.Add(this.label13);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPreview);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvChooseBook);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(793, 74);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(463, 828);
            this.guna2CustomGradientPanel1.TabIndex = 48;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BorderRadius = 18;
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(286, 636);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(163, 44);
            this.btnExportExcel.TabIndex = 42;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCreatePM
            // 
            this.btnCreatePM.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatePM.BorderRadius = 18;
            this.btnCreatePM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnCreatePM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreatePM.ForeColor = System.Drawing.Color.White;
            this.btnCreatePM.Location = new System.Drawing.Point(286, 684);
            this.btnCreatePM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePM.Name = "btnCreatePM";
            this.btnCreatePM.Size = new System.Drawing.Size(163, 44);
            this.btnCreatePM.TabIndex = 41;
            this.btnCreatePM.Text = "Tạo phiếu mượn";
            this.btnCreatePM.Click += new System.EventHandler(this.btnCreatePM_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.BorderRadius = 18;
            this.btnClearAll.FillColor = System.Drawing.Color.LightCoral;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(277, 29);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(172, 44);
            this.btnClearAll.TabIndex = 40;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Transparent;
            this.btnPreview.BorderRadius = 18;
            this.btnPreview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(27, 684);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(197, 44);
            this.btnPreview.TabIndex = 37;
            this.btnPreview.Text = "Xem chi tiết";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "TÌM KIẾM ĐẦU SÁCH";
            // 
            // TimKiem4NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSLBook);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiem4NV";
            this.Size = new System.Drawing.Size(1275, 924);
            this.Load += new System.EventHandler(this.TimKiem4NV_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseBook)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSLBook;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnFindByTG;
        private Guna.UI2.WinForms.Guna2Button btnFindAll;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbTheLoai;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnCreatePM;
        private Guna.UI2.WinForms.Guna2Button btnClearAll;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnPreview;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChooseBook;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
    }
}