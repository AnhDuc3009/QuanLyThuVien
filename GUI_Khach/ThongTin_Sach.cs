﻿using QLThuVien.BUS;
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

        DauSach_BUS dsBus = new DauSach_BUS();

        private void ThongTinSach_Load(object sender, EventArgs e)
        {
            if (MaDauSach != "")
            {
                DataTable ThongTin = dsBus.LoadThongtinSach_DS(MaDauSach);


                if (ThongTin != null)
                {
                    lbInfoTenSach.Text = ThongTin.Rows[0]["TenDauSach"].ToString();
                    lbInfoTenTG.Text = ThongTin.Rows[0]["TenTacGia"].ToString();
                    lbGiaTien.Text = ThongTin.Rows[0]["GiaTien"].ToString();
                    lbInfoNamXB.Text = ThongTin.Rows[0]["NamXuatBan"].ToString();
                    lbInfoMota.Text = ThongTin.Rows[0]["MoTa"].ToString();

                }


                imageBook.BackgroundImage = dsBus.LoadAnh(MaDauSach);

            }
        }
    }
}
