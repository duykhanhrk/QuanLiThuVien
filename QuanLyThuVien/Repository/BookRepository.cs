using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class BookRepository : RepositoryAction<Book>
    {
        public List<Book> GetAll(string search)
        {
            string commandText = "SELECT * FROM Book WHERE Id LIKE @search OR Description LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");

            return Get(commandText, parameterSearch);
        }
    }
}
