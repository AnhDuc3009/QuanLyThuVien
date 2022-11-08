
namespace QLThuVien.GUI_Admin
{
    partial class DSSachCoSan
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
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbSLBook = new System.Windows.Forms.Label();
            this.btnFindByTG = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindAll = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutDS = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.lbSLBook);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindByTG);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnFindAll);
            this.guna2CustomGradientPanel2.Controls.Add(this.txtSearch);
            this.guna2CustomGradientPanel2.Controls.Add(this.cbTheLoai);
            this.guna2CustomGradientPanel2.Controls.Add(this.flowLayoutDS);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnSearch);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(14, 41);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1255, 761);
            this.guna2CustomGradientPanel2.TabIndex = 50;
            // 
            // lbSLBook
            // 
            this.lbSLBook.AutoSize = true;
            this.lbSLBook.BackColor = System.Drawing.Color.Transparent;
            this.lbSLBook.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbSLBook.ForeColor = System.Drawing.Color.Red;
            this.lbSLBook.Location = new System.Drawing.Point(829, 34);
            this.lbSLBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSLBook.Name = "lbSLBook";
            this.lbSLBook.Size = new System.Drawing.Size(15, 23);
            this.lbSLBook.TabIndex = 47;
            this.lbSLBook.Text = ".";
            // 
            // btnFindByTG
            // 
            this.btnFindByTG.BackColor = System.Drawing.Color.Transparent;
            this.btnFindByTG.BorderRadius = 15;
            this.btnFindByTG.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFindByTG.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFindByTG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindByTG.ForeColor = System.Drawing.Color.White;
            this.btnFindByTG.Location = new System.Drawing.Point(621, 14);
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
            this.btnFindAll.BorderRadius = 15;
            this.btnFindAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFindAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindAll.ForeColor = System.Drawing.Color.White;
            this.btnFindAll.Location = new System.Drawing.Point(464, 13);
            this.btnFindAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(149, 44);
            this.btnFindAll.TabIndex = 39;
            this.btnFindAll.Text = "Tìm tất cả";
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
            this.txtSearch.Location = new System.Drawing.Point(187, 62);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập tên sách để tôi tìm cho bạn";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(769, 49);
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
            this.cbTheLoai.Location = new System.Drawing.Point(187, 14);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(237, 36);
            this.cbTheLoai.TabIndex = 37;
            // 
            // flowLayoutDS
            // 
            this.flowLayoutDS.AutoScroll = true;
            this.flowLayoutDS.Location = new System.Drawing.Point(20, 123);
            this.flowLayoutDS.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutDS.Name = "flowLayoutDS";
            this.flowLayoutDS.Size = new System.Drawing.Size(1177, 615);
            this.flowLayoutDS.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(965, 62);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 49);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // DSSachCoSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSSachCoSan";
            this.Size = new System.Drawing.Size(1493, 903);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnFindByTG;
        private Guna.UI2.WinForms.Guna2Button btnFindAll;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbTheLoai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutDS;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lbSLBook;
    }
}
