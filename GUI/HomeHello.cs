using QLThuVien.BUS;
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
    public partial class HomeHello : UserControl
    {
        public HomeHello()
        {
            InitializeComponent();
        }
        Home_BUS homeHello = new Home_BUS();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GUI.FrmDangKy newform = new GUI.FrmDangKy();
            newform.Show();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            GUI.Hello_TacGia newform = new GUI.Hello_TacGia();
            newform.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GUI.TimKiem4Hello newform = new GUI.TimKiem4Hello(txtSearch.Text);
            newform.Show();
        }
    }
}
