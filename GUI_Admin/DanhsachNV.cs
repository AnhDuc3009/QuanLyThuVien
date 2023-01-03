using QLThuVien.BUS;
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
    public partial class DanhsachNV : UserControl
    {
        NhanVien_BUS nvbus = new NhanVien_BUS();
        public DanhsachNV()
        {
            InitializeComponent();
        }

        private void DanhsachNV_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = nvbus.GetList();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;


            if (keyword != "")
            {
                dgvNhanvien.DataSource = nvbus.TimKiem(keyword);
            }
            else
            {
                dgvNhanvien.DataSource = nvbus.GetList();
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];
            txtName.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
            pickerBirthday.Value = DateTime.Parse(row.Cells[5].Value.ToString()); ;
            cbGioitinh.SelectedIndex = row.Cells["GioiTinh"].Value.ToString() == "Nam" ? 0 : 1;
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtCMND.Text = row.Cells["CMND"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            nv.MaNhanVien = row.Cells["MaNhanVien"].Value.ToString();
            nv.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
        }


        NhanVien nv = new NhanVien();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            nv.TenNhanVien = txtName.Text;
            nv.NgaySinh = pickerBirthday.Value;
            nv.GioiTinh = cbGioitinh.Text;
            nv.Email = txtEmail.Text;
            nv.SDT = txtSDT.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.CMND = txtCMND.Text;

            if (MessageBox.Show("Bạn có chắc chắn muốn lưu?", "Lưu thông tin nhân viên?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nvbus.Sua(nv))
                {
                    MessageBox.Show("Lưu thông tin thành công!");
                    dgvNhanvien.DataSource = nvbus.GetList();
                }
                else
                {
                    MessageBox.Show("Lưu thông tin không thành công! Hãy kiểm tra lại");

                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn vô hiệu hóa tài khoản này?", "Vô hiệu hóa tài khoản?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nvbus.Xoa(nv.TenDangNhap);
                MessageBox.Show("Vô hiệu hóa thành công!");
                dgvNhanvien.DataSource = nvbus.GetList();
            }
        }
    }
}
