﻿using QLThuVien.BUS;
using QLThuVien.DTO;
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
    public partial class FrmThemDauSach : UserControl
    {
        public FrmThemDauSach()
        {
            InitializeComponent();
        }

        DauSach_BUS dsBus = new DauSach_BUS();
        TacGia_BUS tgBus = new TacGia_BUS();
        NhaXuatBan_BUS nxbBus = new NhaXuatBan_BUS();
        TheLoai_BUS tlBus = new TheLoai_BUS();

        private void hideChildForm()
        {

        }

        private void FrmThemDauSach_Load(object sender, EventArgs e)
        {
            hideChildForm();
            dgvDauSach.DataSource = dsBus.LoadListDSMini();
            DataTable temp = new DataTable();

            temp = tgBus.LoadTenTacGia();
            cbTenTacGia.DataSource = temp;
            cbTenTacGia.DisplayMember = temp.Columns[2].ToString();
            cbTenTacGia.ValueMember = temp.Columns[1].ToString();

            temp = nxbBus.LoadTenNXB();
            cbTenNXB.DataSource = temp;
            cbTenNXB.DisplayMember = temp.Columns[2].ToString();
            cbTenNXB.ValueMember = temp.Columns[1].ToString();

            temp = tlBus.LoadTenTheLoai();
            cbTenTheLoai.DataSource = temp;
            cbTenTheLoai.DisplayMember = temp.Columns[2].ToString();
            cbTenTheLoai.ValueMember = temp.Columns[1].ToString();


            txtMaDauSach.Text = dsBus.CreateNextMaDS();
        }

        private void dgvDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDauSach.Rows[e.RowIndex];
                txtMaDauSach.Text = row.Cells[0].Value.ToString();
                txtTenDauSach.Text = row.Cells[1].Value.ToString();
                txtNamXuatBan.Text = row.Cells[4].Value.ToString();
                txtLanTaiBan.Text = row.Cells[2].Value.ToString();
                txtGiaTien.Text = row.Cells[5].Value.ToString();
                txtMoTa.Text = row.Cells[6].Value.ToString();
                cbTenTacGia.Text = row.Cells[9].Value.ToString();
                cbTenNXB.Text = row.Cells[11].Value.ToString();
                cbTenTheLoai.Text = row.Cells[14].Value.ToString();
                ImageConverter objImageConverter = new ImageConverter();
                imageBook.BackgroundImage = (Image)objImageConverter.ConvertFrom(row.Cells[7].Value);
                imageBook.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            string TuKhoa = txtTuKhoa.Text;
            if (cbLoaiLoc.Text == "Mã đầu sách")
                dgvDauSach.DataSource = dsBus.SearchDS(TuKhoa, "MaDauSach");
            else if (cbLoaiLoc.Text == "Tên đầu sách")
                dgvDauSach.DataSource = dsBus.SearchDS(TuKhoa, "TenDauSach");
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            DauSach_BUS dsBus = new DauSach_BUS();
            DauSach ds = new DauSach();
            SangTac st = new SangTac();
            XuatBan xb = new XuatBan();
            if (dsBus.CheckMaDauSach(txtMaDauSach.Text) == true) MessageBox.Show("Mã đầu sách đã tồn tại!");
            else
            {
                ds.MaDauSach = txtMaDauSach.Text;
                ds.TenDauSach = txtTenDauSach.Text;
                ds.SoLuong = 0;
                ds.LanTaiBan = Int32.Parse(txtLanTaiBan.Text);
                ds.NamXuatBan = txtNamXuatBan.Text;
                ds.GiaTien = Int32.Parse(txtGiaTien.Text);
                ds.MoTa = txtMoTa.Text;
                ds.MaTheLoai = cbTenTheLoai.SelectedValue.ToString();
                st.MaTacGia = cbTenTacGia.SelectedValue.ToString();
                xb.MaNhaXuatBan = cbTenNXB.SelectedValue.ToString();
                dsBus.ThemThongtinNhap(ds, st, xb);
                dsBus.LuuAnh(ds.MaDauSach, ofdOpenFile.FileName);

                dgvDauSach.DataSource = dsBus.LoadListDSMini();



            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DauSach_BUS dsBus = new DauSach_BUS();
            DauSach ds = new DauSach();
            SangTac st = new SangTac();
            XuatBan xb = new XuatBan();

            ds.MaDauSach = txtMaDauSach.Text;
            ds.TenDauSach = txtTenDauSach.Text;
            ds.SoLuong = 0;
            ds.LanTaiBan = Int32.Parse(txtLanTaiBan.Text);
            ds.NamXuatBan = txtNamXuatBan.Text;
            ds.GiaTien = Int32.Parse(txtGiaTien.Text);
            ds.MoTa = txtMoTa.Text;
            ds.MaTheLoai = cbTenTheLoai.SelectedValue.ToString();
            st.MaTacGia = cbTenTacGia.SelectedValue.ToString();
            xb.MaNhaXuatBan = cbTenNXB.SelectedValue.ToString();
            dsBus.Update(ds, st, xb);
            dsBus.LuuAnh(ds.MaDauSach, ofdOpenFile.FileName);
            dgvDauSach.DataSource = dsBus.LoadListDSMini();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtMaDauSach.Clear();
            txtTenDauSach.Clear();
            txtNamXuatBan.Clear();
            txtLanTaiBan.Clear();
            txtGiaTien.Clear();
            txtMoTa.Clear();
            imageBook.BackgroundImage = null;
            imageBook.Update();
            txtMaDauSach.Text = dsBus.CreateNextMaDS();
        }

        private void btnThemTacGia_Click_1(object sender, EventArgs e)
        {
            hideChildForm();
            panelShow.Controls.Clear();
            UserControl temp = new GUI_NhanVien.FrmThemTacGia();
            panelShow.Controls.Add(temp);
        }

        private void btnThemNXB_Click_1(object sender, EventArgs e)
        {
            hideChildForm();
            panelShow.Controls.Clear();
            UserControl temp = new GUI_NhanVien.FrmThemNXB();
            panelShow.Controls.Add(temp);
        }

        private void btnThemTheLoai_Click_1(object sender, EventArgs e)
        {
            hideChildForm();
            panelShow.Controls.Clear();
            UserControl temp = new GUI_NhanVien.FrmThemTheLoai();
            panelShow.Controls.Add(temp);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string file = ofdOpenFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image myImage = Image.FromFile(file);
            imageBook.BackgroundImage = myImage;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            hideChildForm();
            panelShow.Controls.Clear();
            UserControl temp = new GUI_NhanVien.FrmThemCuonSach();
            panelShow.Controls.Add(temp);
        }
    }
}
