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
    public partial class Xu_ly_tra : UserControl
    {
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
    }
}
