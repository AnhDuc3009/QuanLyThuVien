using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DTO;

namespace QLThuVien.DAO
{
    class NhanVien_DAO : DataProvider
    {
        public DataTable loadNhanVien()
        {
            string sqlString = @"select * from NHANVIEN";
            return GetData(sqlString);
        }


        public string loadMa_TenDangNhap(string TenDangNhap)
        {
            string sql = $"select MaNhanVien from NHANVIEN where TenDangNhap = '{TenDangNhap}'";

            return GetString(sql);
        }
        public bool Insert(NhanVien nv)
        {
            if (GetData("select * from NHANVIEN where MaNhanVien = '" + nv.MaNhanVien + "'").Rows.Count > 0)
                return false;

            string sql = $"INSERT INTO dbo.NHANVIEN VALUES ('{nv.MaNhanVien}',N'{nv.TenNhanVien}','1',N'{nv.ChucVu}','{DateToString(nv.NgaySinh)}',N'{nv.GioiTinh}',N'{nv.DiaChi}','{nv.Email}','{nv.SDT}','{nv.CMND}','{nv.TenDangNhap}',NULL, NULL)";
            Excute(sql);


            return true;
        }

        public void Delete(string tDN)
        {
            Excute("Update NHANVIEN set TrangThai = 0 where TenDangNhap = '" + tDN + "'");
            Excute("Update TaiKhoan set LoaiTK = 'vohieuhoa' where TenDangNhap = '" + tDN + "'");
        }

        public void Update(NhanVien nv)
        {
            string sql = $"update NHANVIEN set TenNhanVien = N'{nv.TenNhanVien}', GioiTinh = N'{nv.GioiTinh}', NgaySinh = '{nv.NgaySinh}', DiaChi = N'{nv.DiaChi}', Email = '{nv.Email}', SDT = '{nv.SDT}', CMND = {nv.CMND}  where MaNhanVien = '{nv.MaNhanVien}'";
            Excute(sql);


        }


        public void UpdateMK(NhanVien nv, TaiKhoan tk)
        {
            string sql = $"update TAIKHOAN set MatKhau = N'{tk.MatKhau}' where TenDangNhap = '{nv.TenDangNhap}'";
            Excute(sql);


        }

        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select *  from nhanvien where MaNhanVien like '{0}' or TenNhanVien like N'%{0}%' or ChucVu like N'%{0}%' or NgaySinh like '%{0}%' or GioiTinh like N'%{0}%' or Email like '%{0}%' or SDT like '%{0}%' or CMND like '%{0}%' or TenDangNhap like '%{0}%' ", _timkiem);


            return GetData(sqlString);
        }


        #region get

        public DataTable GetMaNV()
        {
            string sql = "SELECT MaNhanVien FROM dbo.NHANVIEN";
            return GetData(sql);
        }

        public string GetTenNV(string MaNV)
        {
            string sql = $"SELECT TenNhanVien FROM dbo.NHANVIEN WHERE MaNhanVien = '{MaNV}'";
            return GetString(sql);
        }

        public string GetMaNV_PM(string MaMT)
        {
            string sql = $"SELECT MaNhanVien FROM dbo.PHIEUMUONTRA WHERE MaMuonTra = '{MaMT}'";
            return GetString(sql);
        }

        public DataTable GetThongTinNV(string MaNV)
        {
            string sql = $"select TenNhanVien,ChucVu,NgaySinh,GioiTinh,DiaChi,Email,SDT,CMND,TenDangNhap from Nhanvien WHERE MaNhanVien = '{MaNV}'";
            return GetData(sql);
        }

        public string GetLastest_MaNhanVien()
        {
            string sql = "SELECT TOP 1 MaNhanVien FROM dbo.NHANVIEN ORDER BY MaNhanVien DESC";
            return GetString(sql);
        }

        #endregion




    }
}
