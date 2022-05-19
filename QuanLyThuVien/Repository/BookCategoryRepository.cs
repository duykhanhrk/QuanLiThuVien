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
    public class BookCategoryRepository : RepositoryAction<BookCategory>
    {
        public List<BookCategory> GetAll(string search = "")
        {
            string commandText = $"SELECT * FROM {tableName} WHERE Name LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");

            return Get(commandText, parameterSearch);
        }

        public List<BookCategory> GetAllOfBookTitle(BookTitle bookTitle)
        {
            string commandText = $"SELECT {tableName}.* FROM {tableName} INNER JOIN BookTitle_BookCategory ON {tableName}.Id = BookTitle_BookCategory.BookCategoryId AND BookTitle_BookCategory.BookTitleISBN = @iSBN";
            SqlParameter parameterISBN = new SqlParameter("@ISBN", bookTitle.ISBN);

            return Get(commandText, parameterISBN);
        }
    }
}
