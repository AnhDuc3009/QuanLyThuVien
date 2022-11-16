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
using QLThuVien.BUS;

namespace QLThuVien.GUI_DocGia
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
            listSachMuon = new List<string>();
        }

        public frmDocGia(string username)
        {
            InitializeComponent();
            user = username;
            listSachMuon = new List<string>();
        }

        public frmDocGia(string username, List<string> lsMuon)
        {
            InitializeComponent();
            user = username;
            listSachMuon = lsMuon;
        }

        string Madocgia = "DG000001";
        string user = "";

        public static List<string> listSachMuon;

        void loadAvt()
        {
            pictureAvt.Image = dgBus.LoadAnh(Madocgia);
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

        DocGia_BUS dgBus = new DocGia_BUS();

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            if (user != "")
            {
                nameuser.Text = user;
                Madocgia = dgBus.LoadMaDG_TK(user);
                pictureAvt.Image = dgBus.LoadAnh(Madocgia);
            }
            if (GUI_Khach.TimKiem4Hello.DaTim)
            {
                panelShow.Controls.Clear();
                List<string> dsmuon = GUI_Khach.TimKiem4Hello.dsMuon;

                panelShow.Controls.Add(new GUI_DocGia.PhieuMuon(Madocgia, dsmuon));
                GUI_Khach.TimKiem4Hello.DaTim = false;
            }

            panelShow.Controls.Clear();

            if (listSachMuon.Count > 0)
            {
                panelShow.Controls.Add(new GUI_DocGia.PhieuMuon(Madocgia, listSachMuon));
            }
            else
            {
                panelShow.Controls.Add(new GUI_Khach.HomeHello());
            }
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();

            panelShow.Controls.Add(new GUI_DocGia.InfoDG());
        }

        private void btnTk_Sach_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();

            panelShow.Controls.Add(new GUI_DocGia.TK_SachMuon_dg());
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            loadAvt();
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_DocGia.FrmTimKiemForDG());
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            loadAvt();
            //nếu list sách mượn chưa có sách nào thì cho độc giả tìm sách xong mới mượn
            panelShow.Controls.Clear();

            if (listSachMuon.Count == 0)
            {
                GUI_DocGia.TimKiem4HelloV2 usertimkiem = new GUI_DocGia.TimKiem4HelloV2();

                usertimkiem.OnClick += (ss, ee) =>
                {
                    panelShow.Controls.Clear();

                    panelShow.Controls.Add(new GUI_DocGia.PhieuMuon(Madocgia, listSachMuon));

                };

                panelShow.Controls.Add(usertimkiem);

            }
            else
            {
                panelShow.Controls.Add(new GUI_DocGia.PhieuMuon(Madocgia, listSachMuon));
            }
        }

    }
}
