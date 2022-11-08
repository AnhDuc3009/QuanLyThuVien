
namespace QLThuVien.GUI_Admin
{
    partial class tk_sachnhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.txtTongso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tkSachnhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkSachnhap)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(393, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê sách nhập";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.BorderRadius = 10;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(812, 95);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(169, 49);
            this.btnTK.TabIndex = 6;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTongso
            // 
            this.txtTongso.BackColor = System.Drawing.Color.Transparent;
            this.txtTongso.BorderRadius = 10;
            this.txtTongso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongso.DefaultText = "";
            this.txtTongso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongso.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongso.Location = new System.Drawing.Point(613, 95);
            this.txtTongso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTongso.Name = "txtTongso";
            this.txtTongso.PasswordChar = '\0';
            this.txtTongso.PlaceholderText = "";
            this.txtTongso.SelectedText = "";
            this.txtTongso.Size = new System.Drawing.Size(155, 49);
            this.txtTongso.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // dgv_tkSachnhap
            // 
            this.dgv_tkSachnhap.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_tkSachnhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tkSachnhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tkSachnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_tkSachnhap.ColumnHeadersHeight = 40;
            this.dgv_tkSachnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDauSach,
            this.soluong});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tkSachnhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_tkSachnhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgv_tkSachnhap.Location = new System.Drawing.Point(51, 238);
            this.dgv_tkSachnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tkSachnhap.Name = "dgv_tkSachnhap";
            this.dgv_tkSachnhap.RowHeadersVisible = false;
            this.dgv_tkSachnhap.RowHeadersWidth = 51;
            this.dgv_tkSachnhap.RowTemplate.Height = 40;
            this.dgv_tkSachnhap.Size = new System.Drawing.Size(1177, 542);
            this.dgv_tkSachnhap.TabIndex = 2;
            this.dgv_tkSachnhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_tkSachnhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_tkSachnhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_tkSachnhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_tkSachnhap.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_tkSachnhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgv_tkSachnhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_tkSachnhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_tkSachnhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_tkSachnhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tkSachnhap.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_tkSachnhap.ThemeStyle.ReadOnly = false;
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_tkSachnhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng sách nhập của đầu sách";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.dateEnd);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.dateStart);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTK);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtTongso);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(51, 4);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1177, 228);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.BackColor = System.Drawing.Color.Transparent;
            this.dateEnd.BorderColor = System.Drawing.Color.Transparent;
            this.dateEnd.BorderRadius = 10;
            this.dateEnd.Checked = true;
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(112, 128);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateEnd.MinimumSize = new System.Drawing.Size(5, 54);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(261, 54);
            this.dateEnd.TabIndex = 8;
            this.dateEnd.Value = new System.DateTime(2022, 11, 5, 23, 38, 27, 379);
            // 
            // dateStart
            // 
            this.dateStart.BackColor = System.Drawing.Color.Transparent;
            this.dateStart.BorderColor = System.Drawing.Color.Transparent;
            this.dateStart.BorderRadius = 10;
            this.dateStart.Checked = true;
            this.dateStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(112, 56);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateStart.MinimumSize = new System.Drawing.Size(5, 54);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(261, 54);
            this.dateStart.TabIndex = 7;
            this.dateStart.Value = new System.DateTime(2022, 11, 5, 23, 38, 27, 426);
            // 
            // tk_sachnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgv_tkSachnhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tk_sachnhap";
            this.Size = new System.Drawing.Size(1258, 802);
            this.Load += new System.EventHandler(this.tk_sachnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkSachnhap)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTongso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_tkSachnhap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}
