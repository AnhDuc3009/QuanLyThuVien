using QLThuVien.BUS;
using QLThuVien.GUI_NhanVien;
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
    public partial class Xu_ly_tra : UserControl
    {
        Trasach_Bus ts_bus = new Trasach_Bus();
        public Xu_ly_tra()
        {
            InitializeComponent();
        }
        string MaNhanVien = "";
        public Xu_ly_tra(string manv)
        {
            InitializeComponent();
            MaNhanVien = manv;
        }

        public string chuanhoa(string a)
        {
            return a.ToUpper();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text != "")
            {
                if (cmbTKiem.SelectedItem == "Mã độc giả")
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        dgv_trasach.DataSource = ts_bus.loadtk_dgia(chuanhoa(txtTK.Text));
                    }

                }
                else if (cmbTKiem.SelectedItem == "Mã sách")
                {
                    dgv_trasach.DataSource = ts_bus.loadtk_masach(chuanhoa(txtTK.Text));
                }
                else if (cmbTKiem.SelectedItem == "Tất cả")
                {
                    txtTK.Text = " ";
                    dgv_trasach.DataSource = ts_bus.Loadls();
                }
            }
            else
            {
                if (cmbTKiem.SelectedItem == "Tất cả")
                {
                    dgv_trasach.DataSource = ts_bus.Loadls();
                }
                else if (cmbTKiem.SelectedItem == "Mã sách" || cmbTKiem.SelectedItem == "Mã độc giả")
                {
                    MessageBox.Show("Vui lòng nhập nội dung tìm kiếm");
                }

            }
        }

        private void Xu_ly_tra_Load(object sender, EventArgs e)
        {
            dgv_trasach.DataSource = ts_bus.Loadls();
            cmbTKiem.SelectedIndex = 0;
        }

        private void btnBbvp_Click(object sender, EventArgs e)
        {
            List<string> book = new List<string>();
            string madg;
            string ngaytra1;
            int count = 0;

            //  bool tre = false;
            for (int i = 0; i < dgvDs.Rows.Count; i++)
            {
                if (Equals(dgvDs.Rows[i].Cells[3].Value, "Có"))
                {
                    book.Add(dgvDs.Rows[i].Cells[0].Value.ToString().Trim());
                    count++;
                }


            }
            if (count != 0)
            {
                madg = dgvDs.Rows[0].Cells[1].Value.ToString();
                ngaytra1 = dgvDs.Rows[0].Cells[2].Value.ToString();
                FrmBienbanVP bbvp = new FrmBienbanVP(madg, ngaytra1, book/*,tre*/, MaNhanVien);
                bbvp.Show();
            }
        }

        private void dgv_trasach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            DateTime res;
            i = dgv_trasach.CurrentRow.Index;
            txtMasach.Text = dgv_trasach.Rows[i].Cells[3].Value.ToString();
            txtMadg.Text = dgv_trasach.Rows[i].Cells[0].Value.ToString();
            DateTime.TryParse(dgv_trasach.Rows[i].Cells[5].Value.ToString(), out res);
            if (res < DateTime.Now)
            {
                cboxVi_pham.Checked = true;
            }
            else
            {
                cboxVi_pham.Checked = false;
            }
        }

        private void dgvDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int i;
             i = dgvDs.CurrentRow.Index;
             txtMasach.Text = dgvDs.Rows[i].Cells[0].Value.ToString();
             txtMadg.Text = dgvDs.Rows[i].Cells[1].Value.ToString();
             if (dgvDs.Rows[i].Cells[0].Value.ToString() == "Có")
             {
                 cboxVi_pham.Checked =true;
             }
            if (e.ColumnIndex == 4)
            {

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dgvDs.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDs.Rows.Count; i++)
            {
                if (dgvDs.Rows[i].Cells[3].Value.ToString() == "Không")// chỉ set những cuốn sách không vi phạm những cuốn sách vi phạm thì sẽ set ở bên vi phạm
                {
                    ts_bus.update(dgvDs.Rows[i].Cells[0].Value.ToString());
                    MessageBox.Show("Trả sách thành công!!");
                }
            }

            dgvDs.Rows.Clear();
            dgv_trasach.DataSource = ts_bus.Loadls();
        }

        private void btnCleardgv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả?", "Xóa tất cả sách đã chọn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dgvDs.Rows.Clear();

            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã độc giả");
                return;
            }
            else if (txtMasach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách trả");
                return;
            }


            for (int i = 0; i < dgvDs.Rows.Count; i++)
            {
                if (txtMasach.Text == dgvDs.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Cuốn sách đã được chọn!");
                    return;
                }

                int j = dgv_trasach.CurrentRow.Index;

                if (dgvDs.Rows.Count > 0 && (dgvDs.Rows[0].Cells[1].Value.ToString() != dgv_trasach.Rows[j].Cells["MaDocGia"].Value.ToString()))
                {
                    MessageBox.Show("Hãy trả sách của một độc giả trong một lượt trả!");
                    return;
                }

            }


            if (cboxVi_pham.Checked == true)
            {
                dgvDs.Rows.Add(chuanhoa(txtMasach.Text), chuanhoa(txtMadg.Text), DateTime.Now, "Có", "Bỏ");
            }
            else
            {
                dgvDs.Rows.Add(chuanhoa(txtMasach.Text), chuanhoa(txtMadg.Text), DateTime.Now, "Không", "Bỏ");
            }
        }
    }
}
