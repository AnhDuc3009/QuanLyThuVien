
namespace QLThuVien.GUI_Admin
{
    partial class DSSachMuon
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
            this.dgvDs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel22 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).BeginInit();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDs
            // 
            this.dgvDs.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDs.ColumnHeadersHeight = 40;
            this.dgvDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.MaSach,
            this.MaMuonTra,
            this.TenDocGia,
            this.TenDauSach,
            this.NgayMuon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvDs.Location = new System.Drawing.Point(15, 127);
            this.dgvDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDs.Name = "dgvDs";
            this.dgvDs.RowHeadersVisible = false;
            this.dgvDs.RowHeadersWidth = 51;
            this.dgvDs.RowTemplate.Height = 40;
            this.dgvDs.Size = new System.Drawing.Size(1238, 639);
            this.dgvDs.TabIndex = 0;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvDs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDs.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDs.ThemeStyle.ReadOnly = false;
            this.dgvDs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDs.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // TenDauSach
            // 
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // MaMuonTra
            // 
            this.MaMuonTra.HeaderText = "Mã mượn trả";
            this.MaMuonTra.MinimumWidth = 6;
            this.MaMuonTra.Name = "MaMuonTra";
            this.MaMuonTra.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // MaDauSach
            // 
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            this.MaDauSach.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(613, 71);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 49);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Tìm kiếm";
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
            this.txtSearch.Location = new System.Drawing.Point(15, 71);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập nội dung tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(583, 49);
            this.txtSearch.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(513, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "DANH SÁCH SÁCH MƯỢN";
            // 
            // panel22
            // 
            this.panel22.BorderRadius = 10;
            this.panel22.Controls.Add(this.label1);
            this.panel22.Controls.Add(this.txtSearch);
            this.panel22.Controls.Add(this.btnSearch);
            this.panel22.Controls.Add(this.dgvDs);
            this.panel22.FillColor = System.Drawing.Color.MediumVioletRed;
            this.panel22.FillColor2 = System.Drawing.Color.MediumOrchid;
            this.panel22.Location = new System.Drawing.Point(21, 39);
            this.panel22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1268, 873);
            this.panel22.TabIndex = 3;
            // 
            // DSSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel22);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSSachMuon";
            this.Size = new System.Drawing.Size(1328, 805);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel22;
    }
}
