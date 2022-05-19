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
    public class AuthorRepository : RepositoryAction<Author>
    {
        public List<Author> GetAll(string search)
        {
            string commandText = "SELECT * FROM Author WHERE Id LIKE @search OR LastName + ' ' + FirstName LIKE @search OR Email LIKE @search OR Address LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");

            return Get(commandText, parameterSearch);
        }

        public string FindMaxId()
        {
            string commandText = "SELECT MAX(Id) FROM Author WHERE Id LIKE 'AT[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
            string maxId = (string)DbConnection.ExecuteScalar(commandText, CommandType.Text);

            return maxId;
        }

        public List<Author> GetAllOfBookTitle(BookTitle bookTitle)
        {
            string commandText = $"SELECT {tableName}.* FROM {tableName} INNER JOIN BookTitle_Author ON {tableName}.Id = BookTitle_Author.AuthorId AND BookTitle_Author.BookTitleISBN = @iSBN";
            SqlParameter parameterISBN = new SqlParameter("@ISBN", bookTitle.ISBN);

            return Get(commandText, parameterISBN);
        }
    }
}
