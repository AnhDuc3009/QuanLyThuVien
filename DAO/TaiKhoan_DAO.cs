using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DTO;

namespace QLThuVien.DAO
{
    class TaiKhoan_DAO : DataProvider
    {
        public bool login(string us, string pw)
        {
            if (GetData($"select * from TaiKhoan where TenDangNhap = '{us}' and MatKhau = '{pw}'").Rows.Count > 0)
                return true;
            return false;
        }

        public string GetLastest_MaDG()
        {
            string sql = $" SELECT TOP 1 MaDocGia FROM dbo.DocGia ORDER BY MaDocGia DESC";

            return GetString(sql);
        }

        public string CreateNextMaDG()
        {
            string current = GetLastest_MaDG();

            string inc = System.Text.RegularExpressions.Regex.Match(current, @"\d+\.*\d*").Value;
            string index = (int.Parse(inc) + 1).ToString();

            string Ma = "DG000000";
            Ma = Ma.Substring(0, Ma.Length - index.Length) + index;

            return Ma;
        }

        public bool signup(TaiKhoan tk, bool isNV)
        {


            if (GetData($"select * from TaiKhoan where TenDangNhap = '{tk.TenDangNhap}'").Rows.Count > 0)
                return false; // đã tồn tại tên đăng nhập

            string sql;
            string sql2;

            if (isNV)
            {
                sql = string.Format("Insert Into TaiKhoan(MatKhau, TenDangNhap, LoaiTK) values('{0}', '{1}', 'nhanvien')", tk.MatKhau, tk.TenDangNhap);
                sql2 = "";
            }
            else
            {
                sql = string.Format("Insert Into TaiKhoan(MatKhau, TenDangNhap,LoaiTK) values('{0}', '{1}', 'docgia')", tk.MatKhau, tk.TenDangNhap);
                sql2 = string.Format("Insert Into DocGia(MaDocGia, NgaySinh, TenDangNhap, NgayDangKi, TrangThai) values('{0}', '2001-09-30', '{1}', '{2}', '1')", CreateNextMaDG() ,tk.TenDangNhap, DateTime.Now);
            }

            Excute(sql);
            Excute(sql2);
            return true;
        }

        public string GetTenTK(string username)
        {
            string sql = $"SELECT TenDocGia FROM dbo.DOCGIA where TenDangNhap = '{username}'";
            return GetString(sql);
        }

        public bool checkExistTK(string username)
        {
            if (GetData($"select * from TaiKhoan where TenDangNhap = '{username}'").Rows.Count > 0)
                return true;

            return false;
        }
        public string LoaiTaiKhoan(string username)
        {
            string sql = $"SELECT LoaiTK FROM dbo.TAIKHOAN WHERE TenDangNhap = '{username}'";
            return GetString(sql);
        }


        public void ktramatkhau(string user, string pass)
        {
            string sql = $"INSERT INTO dbo.TAIKHOAN VALUES ('{user}','{pass}','docgia')";
            validateTest(sql);
        }
    }
}
