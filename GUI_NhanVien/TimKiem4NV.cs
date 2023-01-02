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
using QLThuVien.DTO;

namespace QLThuVien.GUI_NhanVien
{
    public partial class TimKiem4NV : UserControl
    {
        public TimKiem4NV()
        {
            InitializeComponent();
        }

        private int index = 0;
        private int limit = 6;

        public TimKiem4NV(string Keyword)
        {
            InitializeComponent();
            txtSearch.Text = Keyword;
            cbTheLoai.Text = "Tất cả thể loại";
            SearchByName();
            index = 0;
            label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
            LoadBookFlow(index * limit);
        }

        string MaDSCurrent = "";
        public void AddItem(string MaDauSach)
        {

            if (MaDauSach != "")
            {
                GUI_Khach.OneBook newbook = new GUI_Khach.OneBook(MaDauSach);
                flowLayoutDS.Controls.Add(newbook);

                newbook.OnSelect += (ss, ee) =>
                {
                    var item = (GUI_Khach.OneBook)ss;
                    MaDSCurrent = item.MaDauSach;

                    foreach (DataGridViewRow row in dgvChooseBook.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == item.MaDauSach)
                        {
                            return;
                        }
                    }

                    if (item.SoLuong > 0)
                        dgvChooseBook.Rows.Add(new object[] { item.MaDauSach, item.TenSach, item.ViTri, "Bỏ" });


                };
            }
        }

        private List<string> DSDauSach = new List<string>();


        private void LoadBookFlow(int offset)
        {
            flowLayoutDS.Controls.Clear();
            lbSLBook.Text = $"Danh sách này có {DSDauSach.Count.ToString()} đầu sách.";
            if (DSDauSach.Count > 0)
            {
                for (int i = offset; i < offset + limit; i++)
                {
                    AddItem(DSDauSach[i]);
                }
            }
        }

        DauSach_BUS dsBus = new DauSach_BUS();
        private void TimKiem4NV_Load(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                DSDauSach = dsBus.LoadMaDauSach();
                index = 0;
                label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index * limit);
            }




            LoadComboBoxTheLoai();

        }

        public void LoadComboBoxTheLoai()
        {
            List<string> dsTheLoai = dsBus.LoadAllTheLoai();
            for (int i = 0; i < dsTheLoai.Count; i++)
            {
                cbTheLoai.Items.Insert(i, dsTheLoai[i]);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchByName();
            index = 0;
            label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
            LoadBookFlow(index * limit);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả?", "Xóa tất cả sách đã chọn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dgvChooseBook.Rows.Clear();
                foreach (var item in flowLayoutDS.Controls)
                {

                    GUI_Khach.OneBook it = (GUI_Khach.OneBook)item;
                    if (it.selected)
                    {
                        it.HighLightItem();

                    }

                }

            }
        }

        private void dgvChooseBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sách này ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string MaXoa = dgvChooseBook.Rows[e.RowIndex].Cells["MaDauSach"].Value.ToString();
                    dgvChooseBook.Rows.RemoveAt(e.RowIndex);
                    foreach (var item in flowLayoutDS.Controls)
                    {

                        GUI_Khach.OneBook it = (GUI_Khach.OneBook)item;
                        if (it.MaDauSach == MaXoa && it.selected)
                        {
                            it.HighLightItem();
                            break;
                        }

                    }
                }

            }
        }
        bool isSearchTG = false;
        private void btnFindByTG_Click(object sender, EventArgs e)
        {
            if (btnFindByTG.Text == btnFindByTG.Tag.ToString())
            {
                btnFindByTG.Text = "Tìm theo tên sách";
                txtSearch.PlaceholderText = "Nhập tên tác giả để tôi tìm sách cho bạn ";
                isSearchTG = true;
            }
            else
            {
                btnFindByTG.Text = btnFindByTG.Tag.ToString();
                txtSearch.PlaceholderText = "Nhập tên sách để tôi tìm cho bạn ";
                isSearchTG = false;

            }
        }

        private void ShowAll()
        {
            DSDauSach = dsBus.LoadMaDauSach();
        }

        private void SearchByName()
        {
            string tl = cbTheLoai.Text.Trim();
            if (tl == "") tl = "Tất cả thể loại";
            string keysearch = txtSearch.Text.Trim();

            if (keysearch != "")
            {
                if (!isSearchTG)
                {
                    if (tl != "Tất cả thể loại")
                    {
                        DSDauSach = dsBus.LoadMaDS_TS_TL(tl, keysearch);

                    }
                    else
                    {
                        DSDauSach = dsBus.LoadMaDS_onlyTenSach(keysearch);
                    }

                }
                else
                {
                    if (tl != "Tất cả thể loại")
                    {
                        DSDauSach = dsBus.LoadMaDS_TG_TL(tl, keysearch);
                    }
                    else
                    {
                        DSDauSach = dsBus.LoadMaDS_OnlyTG(keysearch);
                    }
                }
            }
            else
            {
                DSDauSach = dsBus.LoadMaDS_onlyTheloai(tl);

                if (tl == "Tất cả thể loại")
                {
                    DSDauSach = dsBus.LoadMaDauSach();
                }

            }
        }



        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cbTheLoai.Text;


        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            LoadBookFlow(index * limit);

        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            GUI_Khach.ThongTin_Sach newform = new GUI_Khach.ThongTin_Sach(MaDSCurrent);
            newform.Show();
        }

        public static List<string> dsMuon = new List<string>();
        public static bool DaTim = false;

        public event EventHandler OnClick = null;

        private void btnCreatePM_Click(object sender, EventArgs e)
        {
            dsMuon.Clear();
            for (int i = 0; i < dgvChooseBook.Rows.Count; i++)
            {
                dsMuon.Add(dgvChooseBook.Rows[i].Cells["MaDauSach"].Value.ToString());
            }

            OnClick?.Invoke(this, e);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index * limit);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < Math.Ceiling((double)DSDauSach.Count() / limit) - 1)
            {
                index++;
                label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index * limit);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (index < Math.Ceiling((double)DSDauSach.Count() / limit) - 1)
            {
                index++;
                label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index * limit);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                label2.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index * limit);
            }
        }
    }
}
