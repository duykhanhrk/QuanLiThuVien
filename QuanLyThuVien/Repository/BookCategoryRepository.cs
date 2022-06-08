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
    public class BookCategoryRepository : RepositoryAction<BookCategory, long>
    {
        public List<BookCategory> GetAllOfBookTitle(BookTitle bookTitle)
        {
            string commandText = $"SELECT {tableName}.* FROM {tableName} INNER JOIN BookTitle_BookCategory ON {tableName}.Id = BookTitle_BookCategory.BookCategoryId AND BookTitle_BookCategory.BookTitleISBN = @iSBN";
            SqlParameter parameterISBN = new SqlParameter("@ISBN", bookTitle.ISBN);

            return Get(commandText, parameterISBN);
        }
    }
}
