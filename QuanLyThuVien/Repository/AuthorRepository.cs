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
    public class AuthorRepository : RepositoryAction<Author, string>
    {
        public List<Author> GetAllOfBookTitle(BookTitle bookTitle)
        {
            string commandText = $"SELECT {tableName}.* FROM {tableName} INNER JOIN BookTitle_Author ON {tableName}.Id = BookTitle_Author.AuthorId AND BookTitle_Author.BookTitleISBN = @iSBN";
            SqlParameter parameterISBN = new SqlParameter("@ISBN", bookTitle.ISBN);

            return Get(commandText, parameterISBN);
        }
    }
}
