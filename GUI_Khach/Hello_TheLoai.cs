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

namespace QLThuVien.GUI_Khach
{
    public partial class Hello_TheLoai : Form
    {
        public Hello_TheLoai()
        {
            InitializeComponent();
        }

        Home_BUS hellotl = new Home_BUS();

        TheLoai_BUS tlBus = new TheLoai_BUS();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string timkiem = txtSearch.Text;
            DataTable tl = hellotl.TimKiemTL(timkiem);
            dgvDs.DataSource = tl;
        }

        private void Hello_TheLoai_Load(object sender, EventArgs e)
        {
            dgvDs.DataSource = tlBus.LoadListTLMini();
        }
    }
}
