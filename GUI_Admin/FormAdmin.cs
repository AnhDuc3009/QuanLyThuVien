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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void closeYCollapse()
        {
            if (QLNVTickCollapse)
            {
                Open_Y(ref panelQLNV, ref QLNVTickCollapse);
            }
            if (QLSachTickCollapse)
            {
                Open_Y(ref panelQLsach, ref QLSachTickCollapse);
            }
            if (QLSachNhap)
            {
                Open_Y(ref panelQLSachNhap, ref QLSachNhap);
            }
            if (XLMuonTra)
            {
                Open_Y(ref panelXLMuontra, ref XLMuonTra);
            }
            if (XLViPham)
            {
                Open_Y(ref panelXLViPham, ref XLViPham);
            }
            if (QLDocGiaExpand)
            {
                Open_Y(ref panelQLDocGia, ref QLDocGiaExpand);

            }
            if (thongkeExpand)
            {
                Open_Y(ref panelThongke, ref thongkeExpand);

            }

        }

        bool QLSachTickCollapse = true;
        bool QLNVTickCollapse = true;


        private void FormAdmin_Load_1(object sender, EventArgs e)
        {
            PanelMenuBar.AutoScroll = true;
            closeYCollapse();

            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.HomeAdmin());

        }




        private void Open_Y(ref Panel thisPanel, ref bool thisCollapse)
        {
            if (thisCollapse)
            {

                thisPanel.Height = thisPanel.MinimumSize.Height;
                thisCollapse = false;
            }
            else
            {
                thisPanel.Height = thisPanel.MaximumSize.Height;
                thisCollapse = true;
            }
        }
        private void btnOpenQLNV_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelQLNV, ref QLNVTickCollapse);
        }

        private void btnM_QLsach_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelQLsach, ref QLSachTickCollapse);
        }
        bool QLSachNhap = true;
        private void btnM_QLsachnhap_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelQLSachNhap, ref QLSachNhap);
        }
        bool XLMuonTra = true;

        private void btnM_XLMuonTra_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelXLMuontra, ref XLMuonTra);

        }
        bool XLViPham = true;
        private void btnM_XLViPham_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelXLViPham, ref XLViPham);
        }

        bool QLDocGiaExpand = true;
        private void btnM_QLDG_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelQLDocGia, ref QLDocGiaExpand);

        }
        bool thongkeExpand = true;
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Open_Y(ref panelThongke, ref thongkeExpand);
        }

        private void btnM_DSDausach_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.FrmThemDauSach());
        }

        private void btnM_dsSDamuon_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_NhanVien.tk_sachmuon_nv());

        }

        private void btnM_Muon_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.DSPhieuMuonNV());
        }
        private void btnDSNV_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.DanhsachNV());
        }

        private void btnM_Nhapsach_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.tk_sachnhap());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.HomeAdmin());
        }

        private void btnM_SConlai_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.DSSachCoSan());
        }

        public void btnAddNV_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.Admin_ThemNV());
        }

        private void btnM_DSDG_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.DanhSachDG());
        }



        private void btnM_Suadausach_Click(object sender, EventArgs e)
        {

        }

        private void btnM_Tra_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new Xu_ly_tra(MaQL));
        }
        string MaQL = "NV000000";
        private void btnM_ReportSLDS_Click(object sender, EventArgs e)
        {
            Report.TKLuotMuonCreator pmCreator = new Report.TKLuotMuonCreator(MaQL);
            pmCreator.ShowReportHoaDon();
        }

        private void btnM_tkChung_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new ThongKeNV(MaQL));
        }

        private void btnM_LapBBvp_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.frmLapBBVP(MaQL));
        }

        private void btnM_regtkdg_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.ThemDocgia());

        }

        private void btnQLNhap_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.QLNhap());
        }

        private void btnM_DSSachVP_Click(object sender, EventArgs e)
        {

            panelShow.Controls.Clear();
            panelShow.Controls.Add(new GUI_Admin.DSSachVP());
        }

        private void btnM_DGVP_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNameUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
