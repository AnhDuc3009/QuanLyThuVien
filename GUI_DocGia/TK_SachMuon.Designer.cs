﻿
namespace QLThuVien.GUI_DocGia
{
    partial class TK_SachMuon
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
            this.rbtnChuaTra = new System.Windows.Forms.RadioButton();
            this.rbtnTrehen = new System.Windows.Forms.RadioButton();
            this.rbtnDamuon = new System.Windows.Forms.RadioButton();
            this.dgvTK = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnChuaTra
            // 
            this.rbtnChuaTra.AutoSize = true;
            this.rbtnChuaTra.BackColor = System.Drawing.Color.Transparent;
            this.rbtnChuaTra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChuaTra.Location = new System.Drawing.Point(567, 75);
            this.rbtnChuaTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnChuaTra.Name = "rbtnChuaTra";
            this.rbtnChuaTra.Size = new System.Drawing.Size(109, 32);
            this.rbtnChuaTra.TabIndex = 4;
            this.rbtnChuaTra.TabStop = true;
            this.rbtnChuaTra.Text = "Chưa trả";
            this.rbtnChuaTra.UseVisualStyleBackColor = false;
            // 
            // rbtnTrehen
            // 
            this.rbtnTrehen.AutoSize = true;
            this.rbtnTrehen.BackColor = System.Drawing.Color.Transparent;
            this.rbtnTrehen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTrehen.Location = new System.Drawing.Point(350, 75);
            this.rbtnTrehen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnTrehen.Name = "rbtnTrehen";
            this.rbtnTrehen.Size = new System.Drawing.Size(101, 32);
            this.rbtnTrehen.TabIndex = 4;
            this.rbtnTrehen.TabStop = true;
            this.rbtnTrehen.Text = "Trễ hẹn";
            this.rbtnTrehen.UseVisualStyleBackColor = false;
            // 
            // rbtnDamuon
            // 
            this.rbtnDamuon.AutoSize = true;
            this.rbtnDamuon.BackColor = System.Drawing.Color.Transparent;
            this.rbtnDamuon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDamuon.Location = new System.Drawing.Point(112, 75);
            this.rbtnDamuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnDamuon.Name = "rbtnDamuon";
            this.rbtnDamuon.Size = new System.Drawing.Size(117, 32);
            this.rbtnDamuon.TabIndex = 4;
            this.rbtnDamuon.TabStop = true;
            this.rbtnDamuon.Text = "Đã mượn";
            this.rbtnDamuon.UseVisualStyleBackColor = false;
            // 
            // dgvTK
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTK.ColumnHeadersHeight = 40;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgvTK.Location = new System.Drawing.Point(87, 186);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersVisible = false;
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 40;
            this.dgvTK.Size = new System.Drawing.Size(1103, 640);
            this.dgvTK.TabIndex = 1;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTK.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgvTK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTK.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTK.ThemeStyle.ReadOnly = false;
            this.dgvTK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTK.ThemeStyle.RowsStyle.Height = 40;
            this.dgvTK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMuonTra";
            this.Column1.HeaderText = "Mã mượn trả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSach";
            this.Column2.HeaderText = "Mã sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenDauSach";
            this.Column3.HeaderText = "Tên sách";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayMuon";
            this.Column4.HeaderText = "Ngày mượn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayTra";
            this.Column5.HeaderText = "Ngày trả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.rbtnChuaTra);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTK);
            this.guna2CustomGradientPanel1.Controls.Add(this.rbtnTrehen);
            this.guna2CustomGradientPanel1.Controls.Add(this.rbtnDamuon);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(198)))), ((int)(((byte)(165)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(87, 26);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1103, 135);
            this.guna2CustomGradientPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(467, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê sách mượn";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.BorderRadius = 15;
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(793, 63);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(175, 44);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // TK_SachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.dgvTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TK_SachMuon";
            this.Size = new System.Drawing.Size(1339, 865);
            this.Load += new System.EventHandler(this.TK_sachmuon_dg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnChuaTra;
        private System.Windows.Forms.RadioButton rbtnTrehen;
        private System.Windows.Forms.RadioButton rbtnDamuon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTK;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
