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
    public class BookCategoryRepository
    {
        /// <summary>
        /// This method use to get all book categories form Database
        /// </summary>
        public List<BookCategory> GetAll(string search = "")
        {
            string commandText = "SELECT * FROM BookCategory WHERE Name LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);
            List<BookCategory> list = new List<BookCategory>();
            DataAdapter.Fill(reader, list);

            return list;
        }
    }
}
