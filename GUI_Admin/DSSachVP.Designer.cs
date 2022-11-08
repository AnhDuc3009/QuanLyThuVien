
namespace QLThuVien.GUI_Admin
{
    partial class DSSachVP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSSachVP));
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvChonDauSach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label7.Location = new System.Drawing.Point(405, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(543, 53);
            this.label7.TabIndex = 45;
            this.label7.Text = "DANH SÁCH CUỐN SÁCH BỊ VI PHẠM";
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
            this.txtSearch.Location = new System.Drawing.Point(35, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập thông tin để tôi tìm cho bạn";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(717, 49);
            this.txtSearch.TabIndex = 46;
            // 
            // dgvChonDauSach
            // 
            this.dgvChonDauSach.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvChonDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChonDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChonDauSach.ColumnHeadersHeight = 40;
            this.dgvChonDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaViPham,
            this.MaDauSach,
            this.MaSach,
            this.TenDauSach,
            this.TenNhanVien,
            this.TenDocGia,
            this.NgayTra,
            this.LyDo,
            this.TienPhat,
            this.Anh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChonDauSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChonDauSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvChonDauSach.Location = new System.Drawing.Point(35, 170);
            this.dgvChonDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChonDauSach.Name = "dgvChonDauSach";
            this.dgvChonDauSach.RowHeadersVisible = false;
            this.dgvChonDauSach.RowHeadersWidth = 51;
            this.dgvChonDauSach.RowTemplate.Height = 40;
            this.dgvChonDauSach.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChonDauSach.Size = new System.Drawing.Size(1224, 647);
            this.dgvChonDauSach.TabIndex = 44;
            this.dgvChonDauSach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChonDauSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChonDauSach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChonDauSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChonDauSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChonDauSach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChonDauSach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvChonDauSach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChonDauSach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvChonDauSach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvChonDauSach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChonDauSach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChonDauSach.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvChonDauSach.ThemeStyle.ReadOnly = false;
            this.dgvChonDauSach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChonDauSach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChonDauSach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvChonDauSach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChonDauSach.ThemeStyle.RowsStyle.Height = 40;
            this.dgvChonDauSach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChonDauSach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChonDauSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonDauSach_CellContentClick);
            // 
            // MaViPham
            // 
            this.MaViPham.DataPropertyName = "MaViPham";
            this.MaViPham.HeaderText = "Mã vi phạm";
            this.MaViPham.MinimumWidth = 6;
            this.MaViPham.Name = "MaViPham";
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.Visible = false;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã cuốn sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý do";
            this.LyDo.MinimumWidth = 6;
            this.LyDo.Name = "LyDo";
            this.LyDo.ReadOnly = true;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "TienPhat";
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.MinimumWidth = 6;
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            // 
            // btnSearch
            // 
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(778, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 49);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DSSachVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvChonDauSach);
            this.Name = "DSSachVP";
            this.Size = new System.Drawing.Size(1367, 857);
            this.Load += new System.EventHandler(this.DSSachVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChonDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewImageColumn Anh;
    }
}
