using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool CheckPassword(string passwd)
        {

            if (passwd.Length < 6)
            {
                lbMsg.Text = "Mật khẩu tối thiếu là 6 kí tự. ";
                return false;
            }
            if (passwd.Contains(" "))
            {
                lbMsg.Text = "Mật khẩu không chứa khoảng trắng.";
                return false;
            }

            return true;
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKy newdangky = new FrmDangKy();
            newdangky.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            this.Hide();
            newform.Show();
        }
    }
}
