
namespace QLThuVien.GUI_NhanVien
{
    partial class FrmThemTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemTacGia));
            this.panelShow = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNXB = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTacGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gachCheo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelShow.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.label2);
            this.panelShow.Controls.Add(this.guna2CustomGradientPanel3);
            this.panelShow.Controls.Add(this.dgvTacGia);
            this.panelShow.Controls.Add(this.btnBack);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1127, 638);
            this.panelShow.TabIndex = 0;
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.btnSua);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnXoa);
            this.guna2CustomGradientPanel3.Controls.Add(this.btnThemNXB);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtTenTacGia);
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMaTacGia);
            this.guna2CustomGradientPanel3.Controls.Add(this.label5);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(197)))));
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(95, 117);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(357, 374);
            this.guna2CustomGradientPanel3.TabIndex = 40;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 18;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(133, 254);
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
            this.btnXoa.Location = new System.Drawing.Point(240, 254);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Huỷ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNXB.BorderRadius = 18;
            this.btnThemNXB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(79)))));
            this.btnThemNXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNXB.ForeColor = System.Drawing.Color.White;
            this.btnThemNXB.Location = new System.Drawing.Point(33, 254);
            this.btnThemNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(77, 39);
            this.btnThemNXB.TabIndex = 10;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click_1);
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTacGia.BorderColor = System.Drawing.Color.Transparent;
            this.txtTenTacGia.BorderRadius = 6;
            this.txtTenTacGia.BorderThickness = 0;
            this.txtTenTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTacGia.DefaultText = "";
            this.txtTenTacGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTacGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTacGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtTenTacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTacGia.Location = new System.Drawing.Point(33, 181);
            this.txtTenTacGia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.PasswordChar = '\0';
            this.txtTenTacGia.PlaceholderText = "";
            this.txtTenTacGia.SelectedText = "";
            this.txtTenTacGia.Size = new System.Drawing.Size(284, 39);
            this.txtTenTacGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên tác giả";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTacGia.BorderColor = System.Drawing.Color.Transparent;
            this.txtMaTacGia.BorderRadius = 6;
            this.txtMaTacGia.BorderThickness = 0;
            this.txtMaTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTacGia.DefaultText = "";
            this.txtMaTacGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTacGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTacGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtMaTacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTacGia.Location = new System.Drawing.Point(33, 90);
            this.txtMaTacGia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.PasswordChar = '\0';
            this.txtMaTacGia.PlaceholderText = "";
            this.txtMaTacGia.SelectedText = "";
            this.txtMaTacGia.Size = new System.Drawing.Size(284, 39);
            this.txtMaTacGia.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã tác giả :";
            // 
            // dgvTacGia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTacGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTacGia.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(16)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTacGia.ColumnHeadersHeight = 40;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.gachCheo,
            this.id,
            this.TenTacGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTacGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvTacGia.Location = new System.Drawing.Point(499, 117);
            this.dgvTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowHeadersWidth = 51;
            this.dgvTacGia.RowTemplate.Height = 40;
            this.dgvTacGia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTacGia.Size = new System.Drawing.Size(563, 374);
            this.dgvTacGia.TabIndex = 42;
            this.dgvTacGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTacGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTacGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTacGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTacGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTacGia.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTacGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.dgvTacGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTacGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTacGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTacGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTacGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTacGia.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTacGia.ThemeStyle.ReadOnly = true;
            this.dgvTacGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTacGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTacGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTacGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTacGia.ThemeStyle.RowsStyle.Height = 40;
            this.dgvTacGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTacGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick_1);
            this.dgvTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellContentClick);
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "Mã tác giả";
            this.MaTacGia.MinimumWidth = 6;
            this.MaTacGia.Name = "MaTacGia";
            this.MaTacGia.ReadOnly = true;
            // 
            // gachCheo
            // 
            this.gachCheo.DataPropertyName = "\\";
            this.gachCheo.HeaderText = "\\";
            this.gachCheo.MinimumWidth = 6;
            this.gachCheo.Name = "gachCheo";
            this.gachCheo.ReadOnly = true;
            this.gachCheo.Visible = false;
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
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên tác giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(95, 54);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 46);
            this.btnBack.TabIndex = 43;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(481, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 41);
            this.label2.TabIndex = 50;
            this.label2.Text = "THÊM TÁC GIẢ";
            // 
            // FrmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThemTacGia";
            this.Size = new System.Drawing.Size(1127, 638);
            this.Load += new System.EventHandler(this.FrmThemTacGia_Load);
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThemNXB;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTacGia;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTacGia;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gachCheo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label2;
    }
}