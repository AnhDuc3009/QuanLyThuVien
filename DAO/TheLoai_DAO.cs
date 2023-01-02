using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLThuVien.DTO;

namespace QLThuVien.DAO
{
    class TheLoai_DAO : DataProvider
    {

        public DataTable GetTenTheLoai()
        {
            string sql = "SELECT * FROM dbo.THELOAI";
            return GetData(sql);
        }

        public string GetLastest_MaTL()
        {
            string sql = $" SELECT TOP 1 MaTheLoai FROM dbo.THELOAI ORDER BY MaTheLoai DESC";

            return GetString(sql);
        }
        public DataTable LoadTheLoai()
        {
            string sqlString = @"select * from TheLoai";
            return GetData(sqlString);
        }

        public DataTable LoadTheLoaiMini()
        {
            string sqlString = @"SELECT TENTHELOAI N'Tên thể loại', COUNT(MASACH) N'Số lượng cuốn sách' FROM dbo.CUONSACH CS, dbo.THELOAI TL, dbo.DAUSACH DS WHERE CS.MaDauSach = DS.MaDauSach AND DS.MaTheLoai = TL.MaTheLoai GROUP BY TL.TenTheLoai";
            return GetData(sqlString);
        }

        public string GetMaTheLoai(string ten)
        {
            string sql = "SELECT MaTheLoai FROM dbo.THELOAI WHERE TenTheLoai = N'" + ten + "'";
            return GetString(sql);
        }


        public void InsertTheLoai(TheLoai tl)
        {
            string sql = $"EXEC PROC_THEMTHELOAI '{tl.MaTheLoai}','{tl.TenTheLoai}'";

            Excute(sql);
        }
        public void UpdateTheLoai(string MaTheLoai, string TenTheLoai)
        {
            string sql = $"EXEC PROC_SUATHELOAI '{MaTheLoai}','{TenTheLoai}'";

            Excute(sql);
        }
        public void DeleteTheLoai(TheLoai tl)
        {
            string sql = $"EXEC PROC_XOATHELOAI '{tl.MaTheLoai}'";

            Excute(sql);
        }
    }
}
