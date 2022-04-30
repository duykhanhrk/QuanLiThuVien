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
    public class AuthorRepository
    {
        /// <summary>
        /// This method use to get all authors form Database
        /// </summary>
        public List<Author> GetAll(string search = "")
        {
            string commandText = "SELECT * FROM Author WHERE Id LIKE @search OR LastName + ' ' + FirstName LIKE @search OR Email LIKE @search OR Address LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);
            List<Author> list = new List<Author>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        // <summary>
        /// This method use to get a max id of authors form Database
        /// </summary>
        public string GetMaxId()
        {
            string commandText = "SELECT MAX(Id) FROM Author WHERE Id LIKE 'AT[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
            string maxId = (string)DbConnection.ExecuteScalar(commandText, CommandType.Text);

            return maxId;
        }

        /// <summary>
        /// This method use to insert a new author into Database
        /// </summary>
        public void Create(Author author)
        {
            // Validate
            DataValidation.Validate(author);

            // Command Text
            string commandText = "sp_create_author";

            // Params
            SqlParameter parameterId = new SqlParameter("@id", author.Id);
            SqlParameter parameterFirstName = new SqlParameter("@first_name", author.FirstName);
            SqlParameter parameterLastName = new SqlParameter("@last_name", author.LastName);
            SqlParameter parameterBirthday = new SqlParameter("@birthday", author.Birthday);
            SqlParameter parameterSex = new SqlParameter("@sex", author.Sex);
            SqlParameter parameterAddress = new SqlParameter("@address", author.Address);
            SqlParameter parameterEmail = new SqlParameter("@email", author.Email);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail);
        }
    }
}
