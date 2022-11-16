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
    public partial class HomeDG : UserControl
    {
        public HomeDG()
        {
            InitializeComponent();
        }
        Home_BUS homeHello = new Home_BUS();

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            GUI_Khach.Hello_TacGia newform = new GUI_Khach.Hello_TacGia();
            newform.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GUI_Khach.TimKiem4Hello newform = new GUI_Khach.TimKiem4Hello(txtSearch.Text);
            newform.Show();
        }

        private void HomeDG_Load(object sender, EventArgs e)
        {
            long ts = homeHello.GetTongSach();
            int ts1 = Convert.ToInt32(ts);
            lbTongSach.Text = ts1.ToString();

            long dg = homeHello.GetTongDG();
            int dg1 = Convert.ToInt32(dg);
            lbTongDG.Text = dg1.ToString();

            long ds = homeHello.GetTongDS();
            int ds1 = Convert.ToInt32(ds);
            lbTongDS.Text = ds1.ToString();

            long tl = homeHello.GetTongTL();
            int tl1 = Convert.ToInt32(tl);
            lbTongTL.Text = tl1.ToString();

            DataTable temp = homeHello.GetTop2Dausach();
            foreach (DataRow row in temp.Rows)
            {
                string mads = row["MaDauSach"].ToString();
                flowpanel.Controls.Add(new GUI_Khach.OneBook(mads));
            }
        }
    }
}
