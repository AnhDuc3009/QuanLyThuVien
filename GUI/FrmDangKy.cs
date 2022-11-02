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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtMatkhau.PasswordChar = '\0';
                txtMatkhau1.PasswordChar = '\0';
            }
            else
            {
                txtMatkhau.PasswordChar = '•';
                txtMatkhau1.PasswordChar = '•';
            }
        }

        private bool CheckPassword(string passwd)
        {

            if (passwd.Length < 6)
            {
                lbMsg.Text = "Mật khẩu tối thiếu là 6 kí tự.";
                return false;
            }
            if (passwd.Contains(" "))
            {
                lbMsg.Text = "Mật khẩu không chứa khoảng trắng.";
                return false;
            }


            return true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
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
