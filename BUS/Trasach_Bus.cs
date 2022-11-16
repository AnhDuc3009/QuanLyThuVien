﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DAO;
using QLThuVien.DTO;
using System.Data;
namespace QLThuVien.BUS
{
    class Trasach_Bus
    {
        Trasach_DAO ts_Dao = new Trasach_DAO();
        public DataTable Loadls()
        {
            return ts_Dao.load_trasach();
        }
        public DataTable loadtk_dgia(string a)
        {
            return ts_Dao.loadtk_madg(a);
        }
        public DataTable loadtk_masach(string a)
        {
            return ts_Dao.loadtk_masach(a);
        }
        public void update(string a)
        {
            ts_Dao.Update(a);

        }

    }
}
