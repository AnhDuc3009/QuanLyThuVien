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
    public partial class ThongTin_Sach : Form
    {
        public ThongTin_Sach()
        {
            InitializeComponent();
        }

        string MaDauSach = "";
        public ThongTin_Sach(string Mads)
        {
            InitializeComponent();
            MaDauSach = Mads;
        }

        private void ThongTinSach_Load(object sender, EventArgs e)
        {

        }
    }
}
