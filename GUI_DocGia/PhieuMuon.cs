using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI_DocGia
{
    public partial class PhieuMuon : UserControl
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }

        string MaDauSachCurrent = "DS000000";

        private void PhieuMuon_Load(object sender, EventArgs e)
        {

        }

        private void dgvInfoBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            GUI_Khach.ThongTin_Sach newform = new GUI_Khach.ThongTin_Sach(MaDauSachCurrent);
            newform.Show();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {

        }

        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
