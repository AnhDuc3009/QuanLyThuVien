
namespace QLThuVien.GUI_NhanVien
{
    partial class FrmThemTheLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemTheLoai));
            this.panelShow = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTheLoai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelShow.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.label2);
            this.panelShow.Controls.Add(this.guna2CustomGradientPanel3);
            this.panelShow.Controls.Add(this.dgvTheLoai);
            this.panelShow.Controls.Add(this.btnBack);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1137, 633);
            this.panelShow.TabIndex = 0;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.btnSua);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnXoa);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnThem);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtTenTheLoai);
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMaTheLoai);
            this.guna2CustomGradientPanel3.Controls.Add(this.label5);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(197)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(67, 167);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(391, 366);
            this.guna2CustomGradientPanel3.TabIndex = 45;
            this.guna2CustomGradientPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel3_Paint);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 18;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(153, 254);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 39);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 18;
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(276, 254);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Huỷ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 18;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(33, 254);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 39);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTheLoai.BorderColor = System.Drawing.Color.Transparent;
            this.txtTenTheLoai.BorderRadius = 6;
            this.txtTenTheLoai.BorderThickness = 0;
            this.txtTenTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTheLoai.DefaultText = "";
            this.txtTenTheLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTheLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTenTheLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTheLoai.Location = new System.Drawing.Point(33, 181);
            this.txtTenTheLoai.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.PasswordChar = '\0';
            this.txtTenTheLoai.PlaceholderText = "";
            this.txtTenTheLoai.SelectedText = "";
            this.txtTenTheLoai.Size = new System.Drawing.Size(320, 39);
            this.txtTenTheLoai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên thể loại";
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTheLoai.BorderColor = System.Drawing.Color.Transparent;
            this.txtMaTheLoai.BorderRadius = 6;
            this.txtMaTheLoai.BorderThickness = 0;
            this.txtMaTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTheLoai.DefaultText = "";
            this.txtMaTheLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTheLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txtMaTheLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTheLoai.Location = new System.Drawing.Point(33, 90);
            this.txtMaTheLoai.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.PasswordChar = '\0';
            this.txtMaTheLoai.PlaceholderText = "";
            this.txtMaTheLoai.SelectedText = "";
            this.txtMaTheLoai.Size = new System.Drawing.Size(320, 39);
            this.txtMaTheLoai.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã thể loại :";
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTheLoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTheLoai.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTheLoai.ColumnHeadersHeight = 40;
            this.dgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheLoai,
            this.id,
            this.TenTheLoai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheLoai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTheLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvTheLoai.Location = new System.Drawing.Point(507, 167);
            this.dgvTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersVisible = false;
            this.dgvTheLoai.RowHeadersWidth = 51;
            this.dgvTheLoai.RowTemplate.Height = 40;
            this.dgvTheLoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTheLoai.Size = new System.Drawing.Size(563, 366);
            this.dgvTheLoai.TabIndex = 47;
            this.dgvTheLoai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTheLoai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTheLoai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTheLoai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTheLoai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTheLoai.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTheLoai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvTheLoai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTheLoai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTheLoai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTheLoai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTheLoai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTheLoai.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTheLoai.ThemeStyle.ReadOnly = true;
            this.dgvTheLoai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTheLoai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTheLoai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTheLoai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTheLoai.ThemeStyle.RowsStyle.Height = 40;
            this.dgvTheLoai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTheLoai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick_1);
            this.dgvTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellContentClick);
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã thể loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên thể loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(67, 36);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 55);
            this.btnBack.TabIndex = 48;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(440, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 41);
            this.label2.TabIndex = 49;
            this.label2.Text = "THÊM THỂ LOẠI";
            // 
            // FrmThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThemTheLoai";
            this.Size = new System.Drawing.Size(1137, 633);
            this.Load += new System.EventHandler(this.FrmThemTheLoai_Load);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTheLoai;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTheLoai;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label2;
    }
}