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
    public partial class Hello_DauSach : Form
    {
        public Hello_DauSach()
        {
            InitializeComponent();
        }

        Home_BUS hellods = new Home_BUS();
        DauSach_BUS dsBus = new DauSach_BUS();

        private void Hello_DauSach_Load(object sender, EventArgs e)
        {
            dgvDs.DataSource = dsBus.GetminiDS();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string timkiem = txtSearch.Text;
            DataTable ds = hellods.TimKiemDS(timkiem);
            dgvDs.DataSource = ds;
        }
    }
}
