using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI_Admin
{
    public partial class Admin_ThemNV : UserControl
    {
        public Admin_ThemNV()
        {
            InitializeComponent();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void Admin_ThemNV_Load(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            if (cmnd.Length >= 12)
            {
                MessageBox.Show("Số cmnd có độ dài tối đa 12 kí tự!");

            }
        }
    }
}
