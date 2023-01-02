using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DAO;
using QLThuVien.DTO;
using System.Data;

namespace QLThuVien.BUS
{
    class TacGia_BUS
    {
        TacGia_DAO tgDao = new TacGia_DAO();
        public DataTable LoadTenTacGia()
        {
            return tgDao.GetTenTacGia();
        }

        public string GetLastest_MaTG()
        {
            return tgDao.GetLastest_MaTG();
        }

        public string CreateNextMaTG()
        {
            string current = GetLastest_MaTG();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string Ma = "TG000000";
            Ma = Ma.Substring(0, Ma.Length - index.Length) + index;

            return Ma;
        }

        public DataTable LoadListTG()
        {
            return tgDao.LoadTacGia();
        }

        public DataTable LoadListTGMini()
        {
            return tgDao.LoadTacGiaMini();
        }

        public void ThemThongtinNhap(TacGia tg)
        {
            tgDao.InsertTacGia(tg);
        }
        public void Update(string MaTacGia, string TenTacGia)
        {
            tgDao.UpdateTacGia(MaTacGia, TenTacGia);
        }

        public void Delete(TacGia tg)
        {
            tgDao.DeleteTacGia(tg);
        }
    }
}
