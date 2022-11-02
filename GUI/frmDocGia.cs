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

namespace QLThuVien.GUI
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

        bool sidebarExpand = true;

        private void sidebartick_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // thu vao
            {

                PanelMenuBar.Width -= 100;
                if (PanelMenuBar.Width == PanelMenuBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartick.Stop();
                }
                pictureAvt.Size = new Size(40, 40);
                pictureAvt.Dock = DockStyle.Fill;
                picIcon.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (var btn in panel4.Controls.OfType<Guna2Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(0);
                }

            }
            else // mo ra
            {
                PanelMenuBar.Width += 100;
                if (PanelMenuBar.Width == PanelMenuBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartick.Stop();

                }
                pictureAvt.Size = new Size(60, 60);
                pictureAvt.Dock = DockStyle.None;

                picIcon.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Guna2Button btn in panel4.Controls.OfType<Guna2Button>())
                {
                    btn.Text = btn.Tag.ToString();
                    btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }

            }
        }

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

        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

        }

        private void btnTk_Sach_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {

        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {

        }

        private void pictureAvt_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
