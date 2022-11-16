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

namespace QLThuVien.GUI_DocGia
{
    public partial class TK_SachMuon_dg : UserControl
    {
        string madg = "DG000001";
        public TK_SachMuon_dg()
        {
            InitializeComponent();
        }

        public TK_SachMuon_dg(string ma)
        {
            InitializeComponent();
            madg = ma;
        }

        ThongKe_BUS tk_buss = new ThongKe_BUS();

        public string chuanhoa(string a)
        {
            return a.ToUpper();
        }

        private void TK_sachmuon_dg_Load(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (rbtnDamuon.Checked == true)
            {
                dgvTK.DataSource = tk_buss.Load_tt_sachmuon_dg(madg);
            }
            else if (rbtnChuaTra.Checked == true)
            {
                dgvTK.DataSource = tk_buss.Load_tt_sachchuatra_dg(madg);
            }
            else if (rbtnTrehen.Checked == true)
            {
                dgvTK.DataSource = tk_buss.Load_tt_sach_trehen_dg(madg);
            }
        }


    }
}
