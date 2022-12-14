using QLThuVien.BUS;
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
    public partial class DSSachCoSan : UserControl
    {
        public DSSachCoSan()
        {
            InitializeComponent();
        }

        private int index = 0;
        private int limit = 9;

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

                };
            }
        }

        private List<string> DSDauSach = new List<string>();
        DauSach_BUS dsBus = new DauSach_BUS();

        public void LoadComboBoxTheLoai()
        {
            List<string> dsTheLoai = dsBus.LoadAllTheLoai();
            for (int i = 0; i < dsTheLoai.Count; i++)
            {
                cbTheLoai.Items.Insert(i, dsTheLoai[i]);
            }

        }

        private void LoadBookFlow(int offset)
        {
            flowLayoutDS.Controls.Clear();
            lbSLBook.Text = $"Danh sách này có {DSDauSach.Count.ToString()} đầu sách.";
            if (DSDauSach.Count > 0)
            {
                for(int i=offset; i<offset+limit; i++)
                {
                    AddItem(DSDauSach[i]);
                }
            }
        }

        bool isSearchTG = false;

        

        private void ShowAll()
        {
            DSDauSach = dsBus.LoadMaDauSach();
        }

        private void SearchByName()
        {
            string tl = cbTheLoai.Text.Trim();
            string keysearch = txtSearch.Text.Trim();
            index = 0;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchByName();
            index = 0;
            label1.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
            LoadBookFlow(index*limit);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            ShowAll();
            index = 0;
            label1.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
            LoadBookFlow(index*limit);
        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cbTheLoai.Text;


        }

        private void DSSachCoSan_Load(object sender, EventArgs e)
        {
            DSDauSach = dsBus.LoadMaDauSach_SanCo();
            cbTheLoai.Text = "Tất cả thể loại";
            label1.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
            LoadBookFlow(index * limit);
            LoadComboBoxTheLoai();
        }

        private void cbTheLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string key = cbTheLoai.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                label1.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index*limit);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < Math.Ceiling((double)DSDauSach.Count() / limit)-1)
            {
                index++;
                label1.Text = $"Trang {index + 1}/{Math.Ceiling((double)DSDauSach.Count / limit)}";
                LoadBookFlow(index*limit);
            }
        }
    }
}
