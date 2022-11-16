
namespace QLThuVien.GUI
{
    partial class FrmDangKy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKy));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.checkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatkhau1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(524, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragOrientation = Guna.UI2.WinForms.Enums.DragOrientation.Horizontal;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(473, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderRadius = 22;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(193)))), ((int)(((byte)(140)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(122, 462);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(287, 46);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Đăng ký";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnToggle.Location = new System.Drawing.Point(122, 427);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(40, 20);
            this.btnToggle.TabIndex = 25;
            this.btnToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Đồng ý chấp hành Nội quy thư viện?";
            // 
            // checkShowPass
            // 
            this.checkShowPass.AutoSize = true;
            this.checkShowPass.BackColor = System.Drawing.Color.Transparent;
            this.checkShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkShowPass.CheckedState.BorderRadius = 2;
            this.checkShowPass.CheckedState.BorderThickness = 0;
            this.checkShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkShowPass.Location = new System.Drawing.Point(282, 249);
            this.checkShowPass.Name = "checkShowPass";
            this.checkShowPass.Size = new System.Drawing.Size(140, 21);
            this.checkShowPass.TabIndex = 26;
            this.checkShowPass.Text = "Hiển thị mật khẩu";
            this.checkShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkShowPass.UncheckedState.BorderRadius = 2;
            this.checkShowPass.UncheckedState.BorderThickness = 0;
            this.checkShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkShowPass.UseVisualStyleBackColor = false;
            this.checkShowPass.CheckedChanged += new System.EventHandler(this.checkShowPass_CheckedChanged);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(119, 398);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(12, 17);
            this.lbMsg.TabIndex = 28;
            this.lbMsg.Text = ".";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "ĐĂNG KÝ TÀI KHOẢN ĐỘC GIẢ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Xác thực mật khẩu ";
            // 
            // txtMatkhau1
            // 
            this.txtMatkhau1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtMatkhau1.BorderRadius = 12;
            this.txtMatkhau1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau1.DefaultText = "";
            this.txtMatkhau1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatkhau1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau1.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMatkhau1.IconLeft")));
            this.txtMatkhau1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtMatkhau1.Location = new System.Drawing.Point(121, 352);
            this.txtMatkhau1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMatkhau1.Name = "txtMatkhau1";
            this.txtMatkhau1.PasswordChar = '•';
            this.txtMatkhau1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMatkhau1.PlaceholderText = "      Password";
            this.txtMatkhau1.SelectedText = "";
            this.txtMatkhau1.Size = new System.Drawing.Size(288, 42);
            this.txtMatkhau1.TabIndex = 24;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtMatkhau.BorderRadius = 12;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMatkhau.IconLeft")));
            this.txtMatkhau.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtMatkhau.Location = new System.Drawing.Point(122, 277);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '•';
            this.txtMatkhau.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMatkhau.PlaceholderText = "      Password";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.Size = new System.Drawing.Size(288, 42);
            this.txtMatkhau.TabIndex = 23;
            // 
            // txtUsername
            // 
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtUsername.BorderRadius = 12;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUsername.Location = new System.Drawing.Point(122, 198);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUsername.PlaceholderText = "      Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(287, 42);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.checkShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.txtMatkhau1);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btnToggle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox checkShowPass;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}