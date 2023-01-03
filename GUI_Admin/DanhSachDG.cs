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
    public partial class DanhSachDG : UserControl
    {
        public DanhSachDG()
        {
            InitializeComponent();
        }
        DocGia_BUS dgBus = new DocGia_BUS();

        private void DanhSachDG_Load(object sender, EventArgs e)
        {
            dgvDG.DataSource = dgBus.GetList();
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword != "")
            {
                dgvDG.DataSource = dgBus.TimKiem(keyword);
            }
            else
            {
                dgvDG.DataSource = dgBus.GetList();
            }
        }

        int rowIcurrent = 0;
        string MaDocGiaCurrent;
        DocGia dg = new DocGia();

        private void dgvDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIcurrent = e.RowIndex;
            if (rowIcurrent >= 0)
            {
                DataGridViewRow row = dgvDG.Rows[e.RowIndex];
                MaDocGiaCurrent = row.Cells["MaDocGia"].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtDiachi.Text = row.Cells[4].Value.ToString();
                pickerBirthday.Value = DateTime.Parse(row.Cells[5].Value.ToString()); ;
                cbGender.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtCMND.Text = row.Cells[8].Value.ToString();
                txtTendangnhap.Text = row.Cells[10].Value.ToString();

                dg.MaDocGia = row.Cells["MaDocGia"].Value.ToString();
                dg.TenDocGia = txtName.Text;
                dg.DiaChi = txtDiachi.Text;
                dg.NgaySinh = pickerBirthday.Value;
                dg.NgayDangKi = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                dg.CMND = txtCMND.Text;
                dg.TenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                dg.SDT = txtSDT.Text;
                dg.GioiTinh = cbGender.Text;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dg.TenDocGia = txtName.Text;
            dg.DiaChi = txtDiachi.Text;
            dg.NgaySinh = pickerBirthday.Value;
            dg.CMND = txtCMND.Text;
            dg.SDT = txtSDT.Text;
            dg.GioiTinh = cbGender.Text;

            if (MessageBox.Show("Bạn có chắc chắn muốn lưu?", "Lưu thông tin độc giả?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgBus.Sua(dg))
                {
                    
                    MessageBox.Show("Lưu thông tin thành công!");
                    dgvDG.DataSource = dgBus.GetList();
                }
                else
                {
                    MessageBox.Show("Lưu thông tin không thành công! Hãy kiểm tra lại");

                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn vô hiệu hóa tài khoản này?", "Vô hiệu hóa tài khoản?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgBus.Xoa(dg.TenDangNhap);
                MessageBox.Show("Vô hiệu hóa thành công!");
                dgvDG.DataSource = dgBus.GetList();
            }
        }
    }
}
