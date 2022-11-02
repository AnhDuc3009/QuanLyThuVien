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
    public partial class frmLapBBVP : UserControl
    {
        public frmLapBBVP()
        {
            InitializeComponent();
        }
        string MaNV;
        string maVP = "";
        public frmLapBBVP(string manv)
        {
            InitializeComponent();
            MaNV = manv;
        }
    }
}
