using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class BookCaseRepository
    {
        public List<BookCase> GetAll(string search = "")
        {
            string commandText = "SELECT * FROM BookCase WHERE Description LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);
            List<BookCase> list = new List<BookCase>();
            DataAdapter.Fill(reader, list);

            return list;
        }
    }
}
