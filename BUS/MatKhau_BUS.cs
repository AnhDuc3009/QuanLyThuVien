using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DAO;
using QLThuVien.DTO;

namespace QLThuVien.BUS
{
    class MatKhau_BUS
    {
        MatKhau_DAO mkDao = new MatKhau_DAO();
        public void DoiMatKhau(TaiKhoan _tv)
        {
            mkDao.ChangePassWord(_tv);
        }
        public bool CheckExist(string _tdn, string _mkc)
        {
            return mkDao.CheckExist(_tdn, _mkc);

        }
    }
}
