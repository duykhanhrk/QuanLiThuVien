using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyThuVien.Repository
{
    public class BookTitleRepository : RepositoryAction<BookTitle>
    {
        public List<BookTitle> GetAll(string search)
        {
            string commandText = "SELECT * FROM BookTitle WHERE ISBN LIKE @search OR Name LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");  

            return Get(commandText, parameterSearch);
        }

        public BookTitle findByISBN(string iSBN)
        {
            string commandText = "SELECT * FROM BookTitle WHERE ISBN = @isbn";
            SqlParameter parameterSearch = new SqlParameter("@isbn", iSBN);

            return Find(commandText, parameterSearch);
        }

        public void Delete(string iSBN)
        {
            // Command Text
            string commandText = "sp_delete_book_title";

            // Params
            SqlParameter parameterISBN = new SqlParameter("@isbn", iSBN);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure, parameterISBN);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }
    }
}
