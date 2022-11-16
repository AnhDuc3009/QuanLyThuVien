using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DTO;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien.DAO
{
    class LoadAll_DAO : DataProvider
    {

        public DataTable LoadDataTable(string tableName)
        {
            string sql = $"select * from {tableName}";
            return GetData(sql);
        }
    }
}
