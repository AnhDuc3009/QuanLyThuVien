
namespace QLThuVien.GUI_Admin
{
    partial class Xu_ly_tra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbMuontra = new System.Windows.Forms.Label();
            this.cmbTKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.txtTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.cboxVi_pham = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtMadg = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMasach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMadg = new System.Windows.Forms.Label();
            this.lbMasach = new System.Windows.Forms.Label();
            this.dgv_trasach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHoantat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgvDs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmMasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMadg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCleardgv = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trasach)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMuontra
            // 
            this.lbMuontra.AutoSize = true;
            this.lbMuontra.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMuontra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.lbMuontra.Location = new System.Drawing.Point(20, 0);
            this.lbMuontra.Name = "lbMuontra";
            this.lbMuontra.Size = new System.Drawing.Size(154, 45);
            this.lbMuontra.TabIndex = 0;
            this.lbMuontra.Text = "Trả sách";
            // 
            // cmbTKiem
            // 
            this.cmbTKiem.BackColor = System.Drawing.Color.Transparent;
            this.cmbTKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTKiem.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTKiem.FormattingEnabled = true;
            this.cmbTKiem.ItemHeight = 30;
            this.cmbTKiem.Items.AddRange(new object[] {
            "Mã độc giả",
            "Mã sách",
            "Tất cả"});
            this.cmbTKiem.Location = new System.Drawing.Point(313, 21);
            this.cmbTKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTKiem.Name = "cmbTKiem";
            this.cmbTKiem.Size = new System.Drawing.Size(176, 36);
            this.cmbTKiem.TabIndex = 6;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.BorderRadius = 10;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(516, 21);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(125, 41);
            this.btnTK.TabIndex = 5;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTK.DefaultText = "";
            this.txtTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.Location = new System.Drawing.Point(20, 21);
            this.txtTK.Margin = new System.Windows.Forms.Padding(5);
            this.txtTK.Name = "txtTK";
            this.txtTK.PasswordChar = '\0';
            this.txtTK.PlaceholderText = "Nhập nội dung tìm kiếm";
            this.txtTK.SelectedText = "";
            this.txtTK.Size = new System.Drawing.Size(287, 41);
            this.txtTK.TabIndex = 3;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapnhat.BorderRadius = 10;
            this.btnCapnhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCapnhat.Location = new System.Drawing.Point(201, 730);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(387, 46);
            this.btnCapnhat.TabIndex = 8;
            this.btnCapnhat.Text = "Trả sách";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // cboxVi_pham
            // 
            this.cboxVi_pham.AutoSize = true;
            this.cboxVi_pham.BackColor = System.Drawing.Color.Transparent;
            this.cboxVi_pham.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxVi_pham.CheckedState.BorderRadius = 2;
            this.cboxVi_pham.CheckedState.BorderThickness = 0;
            this.cboxVi_pham.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxVi_pham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxVi_pham.Location = new System.Drawing.Point(357, 41);
            this.cboxVi_pham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxVi_pham.Name = "cboxVi_pham";
            this.cboxVi_pham.Size = new System.Drawing.Size(96, 27);
            this.cboxVi_pham.TabIndex = 7;
            this.cboxVi_pham.Text = "Vi phạm";
            this.cboxVi_pham.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxVi_pham.UncheckedState.BorderRadius = 2;
            this.cboxVi_pham.UncheckedState.BorderThickness = 0;
            this.cboxVi_pham.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cboxVi_pham.UseVisualStyleBackColor = false;
            // 
            // txtMadg
            // 
            this.txtMadg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMadg.DefaultText = "";
            this.txtMadg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMadg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMadg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMadg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMadg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMadg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMadg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMadg.Location = new System.Drawing.Point(181, 32);
            this.txtMadg.Margin = new System.Windows.Forms.Padding(5);
            this.txtMadg.Name = "txtMadg";
            this.txtMadg.PasswordChar = '\0';
            this.txtMadg.PlaceholderText = "";
            this.txtMadg.SelectedText = "";
            this.txtMadg.Size = new System.Drawing.Size(149, 41);
            this.txtMadg.TabIndex = 5;
            // 
            // txtMasach
            // 
            this.txtMasach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMasach.DefaultText = "";
            this.txtMasach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMasach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMasach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMasach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMasach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMasach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMasach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMasach.Location = new System.Drawing.Point(31, 34);
            this.txtMasach.Margin = new System.Windows.Forms.Padding(5);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.PasswordChar = '\0';
            this.txtMasach.PlaceholderText = "";
            this.txtMasach.SelectedText = "";
            this.txtMasach.Size = new System.Drawing.Size(143, 38);
            this.txtMasach.TabIndex = 4;
            // 
            // lbMadg
            // 
            this.lbMadg.AutoSize = true;
            this.lbMadg.BackColor = System.Drawing.Color.Transparent;
            this.lbMadg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMadg.Location = new System.Drawing.Point(176, 5);
            this.lbMadg.Name = "lbMadg";
            this.lbMadg.Size = new System.Drawing.Size(100, 23);
            this.lbMadg.TabIndex = 2;
            this.lbMadg.Text = "Mã độc giả:";
            // 
            // lbMasach
            // 
            this.lbMasach.AutoSize = true;
            this.lbMasach.BackColor = System.Drawing.Color.Transparent;
            this.lbMasach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMasach.Location = new System.Drawing.Point(25, 5);
            this.lbMasach.Name = "lbMasach";
            this.lbMasach.Size = new System.Drawing.Size(78, 23);
            this.lbMasach.TabIndex = 1;
            this.lbMasach.Text = "Mã sách:";
            // 
            // dgv_trasach
            // 
            this.dgv_trasach.AllowUserToResizeColumns = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgv_trasach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_trasach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_trasach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_trasach.ColumnHeadersHeight = 40;
            this.dgv_trasach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.MaMuonTra,
            this.MaSach,
            this.NgayMuon,
            this.HanTra});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_trasach.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_trasach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_trasach.Location = new System.Drawing.Point(29, 156);
            this.dgv_trasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_trasach.Name = "dgv_trasach";
            this.dgv_trasach.ReadOnly = true;
            this.dgv_trasach.RowHeadersVisible = false;
            this.dgv_trasach.RowHeadersWidth = 51;
            this.dgv_trasach.RowTemplate.Height = 40;
            this.dgv_trasach.Size = new System.Drawing.Size(687, 543);
            this.dgv_trasach.TabIndex = 3;
            this.dgv_trasach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trasach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_trasach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_trasach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_trasach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_trasach.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_trasach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_trasach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_trasach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_trasach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_trasach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_trasach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_trasach.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_trasach.ThemeStyle.ReadOnly = true;
            this.dgv_trasach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_trasach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_trasach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_trasach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_trasach.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_trasach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_trasach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_trasach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trasach_CellContentClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên độc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            this.TenDocGia.ReadOnly = true;
            // 
            // MaMuonTra
            // 
            this.MaMuonTra.DataPropertyName = "MaMuonTra";
            this.MaMuonTra.HeaderText = "Mã mượn trả";
            this.MaMuonTra.MinimumWidth = 6;
            this.MaMuonTra.Name = "MaMuonTra";
            this.MaMuonTra.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.MinimumWidth = 6;
            this.HanTra.Name = "HanTra";
            this.HanTra.ReadOnly = true;
            // 
            // btnHoantat
            // 
            this.btnHoantat.BorderRadius = 15;
            this.btnHoantat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.btnHoantat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHoantat.ForeColor = System.Drawing.Color.White;
            this.btnHoantat.Location = new System.Drawing.Point(818, 730);
            this.btnHoantat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoantat.Name = "btnHoantat";
            this.btnHoantat.Size = new System.Drawing.Size(164, 46);
            this.btnHoantat.TabIndex = 4;
            this.btnHoantat.Text = "Hoàn tất trả sách";
            this.btnHoantat.Click += new System.EventHandler(this.btnHoantat_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 15;
            this.guna2CustomGradientPanel1.Controls.Add(this.cboxVi_pham);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbMasach);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtMadg);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbMadg);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtMasach);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(733, 47);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(518, 82);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.cmbTKiem);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnTK);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtTK);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.MediumVioletRed;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(29, 47);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(687, 82);
            this.guna2CustomGradientPanel2.TabIndex = 9;
            // 
            // dgvDs
            // 
            this.dgvDs.AllowUserToAddRows = false;
            this.dgvDs.AllowUserToResizeColumns = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvDs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(143)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDs.ColumnHeadersHeight = 40;
            this.dgvDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMasach,
            this.clmMadg,
            this.clmNgaytra,
            this.clmVP,
            this.Column1});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(209)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDs.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.dgvDs.Location = new System.Drawing.Point(733, 156);
            this.dgvDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDs.Name = "dgvDs";
            this.dgvDs.ReadOnly = true;
            this.dgvDs.RowHeadersVisible = false;
            this.dgvDs.RowHeadersWidth = 51;
            this.dgvDs.RowTemplate.Height = 40;
            this.dgvDs.Size = new System.Drawing.Size(518, 543);
            this.dgvDs.TabIndex = 1;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDs.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.dgvDs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDs.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDs.ThemeStyle.ReadOnly = true;
            this.dgvDs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDs.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDs_CellContentClick);
            // 
            // clmMasach
            // 
            this.clmMasach.DataPropertyName = "clmMasach";
            this.clmMasach.HeaderText = "Mã sách";
            this.clmMasach.MinimumWidth = 6;
            this.clmMasach.Name = "clmMasach";
            this.clmMasach.ReadOnly = true;
            // 
            // clmMadg
            // 
            this.clmMadg.DataPropertyName = "clmMadg";
            this.clmMadg.HeaderText = "Mã độc giả";
            this.clmMadg.MinimumWidth = 6;
            this.clmMadg.Name = "clmMadg";
            this.clmMadg.ReadOnly = true;
            // 
            // clmNgaytra
            // 
            this.clmNgaytra.DataPropertyName = "clmNgaytra";
            this.clmNgaytra.HeaderText = "Ngày trả";
            this.clmNgaytra.MinimumWidth = 6;
            this.clmNgaytra.Name = "clmNgaytra";
            this.clmNgaytra.ReadOnly = true;
            // 
            // clmVP
            // 
            this.clmVP.DataPropertyName = "clmVP";
            this.clmVP.HeaderText = "Vi Phạm";
            this.clmVP.MinimumWidth = 6;
            this.clmVP.Name = "clmVP";
            this.clmVP.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Loại bỏ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnCleardgv
            // 
            this.btnCleardgv.BorderRadius = 15;
            this.btnCleardgv.FillColor = System.Drawing.Color.DarkViolet;
            this.btnCleardgv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCleardgv.ForeColor = System.Drawing.Color.White;
            this.btnCleardgv.Location = new System.Drawing.Point(1090, 730);
            this.btnCleardgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleardgv.Name = "btnCleardgv";
            this.btnCleardgv.Size = new System.Drawing.Size(117, 46);
            this.btnCleardgv.TabIndex = 10;
            this.btnCleardgv.Text = "Clear all";
            this.btnCleardgv.Click += new System.EventHandler(this.btnCleardgv_Click);
            // 
            // Xu_ly_tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCleardgv);
            this.Controls.Add(this.dgvDs);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnHoantat);
            this.Controls.Add(this.dgv_trasach);
            this.Controls.Add(this.lbMuontra);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Xu_ly_tra";
            this.Size = new System.Drawing.Size(1277, 799);
            this.Load += new System.EventHandler(this.Xu_ly_tra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trasach)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMuontra;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2TextBox txtTK;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2CheckBox cboxVi_pham;
        private Guna.UI2.WinForms.Guna2TextBox txtMadg;
        private Guna.UI2.WinForms.Guna2TextBox txtMasach;
        private System.Windows.Forms.Label lbMadg;
        private System.Windows.Forms.Label lbMasach;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_trasach;
        private Guna.UI2.WinForms.Guna2Button btnHoantat;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTKiem;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMadg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVP;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private Guna.UI2.WinForms.Guna2Button btnCleardgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
    }
}
