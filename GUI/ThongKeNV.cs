﻿using System;
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
    public partial class ThongKeNV : UserControl
    {
        public ThongKeNV()
        {
            InitializeComponent();
        }

        public ThongKeNV(string MaNV)
        {
            InitializeComponent();
            MaNhanVien = MaNV;
        }
        string MaNhanVien = "";
    }
}
