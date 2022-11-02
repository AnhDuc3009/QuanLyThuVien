using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sidebartick.Start();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI.HomeHello());
        }

        public static bool isLogin = false;

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI.HomeHello());
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GUI.frmLogin newform = new GUI.frmLogin();
            this.Hide();
            newform.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            GUI.FrmDangKy newform = new GUI.FrmDangKy();
            this.Hide();
            newform.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI.TimKiem4Hello());
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI.ThongTin());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }
    }
}
