using Guna.UI2.WinForms;
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
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        public frmDocGia(string username)
        {

        }

        public frmDocGia(string username, List<string> lsMuon)
        {

        }

        string Madocgia = "DG000001";
        string user = "";

        void loadAvt()
        {

        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebartick.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_DocGia.HomeDG());
            loadAvt();
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();

            panelShow.Controls.Add(new GUI_DocGia.InfoDG());
        }

        private void btnTk_Sach_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();

            panelShow.Controls.Add(new GUI_DocGia.TK_SachMuon());
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            loadAvt();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_DocGia.FrmTimKiemForDG());
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();

            panelShow.Controls.Add(new GUI_DocGia.TimKiem4HelloV2());
        }

        private void pictureAvt_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
