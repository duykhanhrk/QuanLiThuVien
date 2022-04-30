using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class LibrarianRepository
    {
        /// <summary>
        /// This method use to get all librarians form Database
        /// </summary>
        public List<Librarian> GetAll(string search = "")
        {
            string commandText = "SELECT * FROM Librarian WHERE Id LIKE @search OR LastName + ' ' + FirstName LIKE @search OR Email LIKE @search OR Address LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);
            List<Librarian> list = new List<Librarian>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        /// <summary>
        /// This method use to get a max id of librarians form Database
        /// </summary>
        public string GetMaxId()
        {
            string commandText = "SELECT MAX(Id) FROM Librarian WHERE Id LIKE 'LB[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
            string maxId = (string)DbConnection.ExecuteScalar(commandText, CommandType.Text);

            return maxId;
        }

        /// <summary>
        /// This method use to insert a new librarian into Database
        /// </summary>
        public void Create(Librarian librarian, Account account)
        {
            // Validate
            DataValidation.Validate(librarian);
            DataValidation.Validate(account);

            // Command Text
            string commandText = "sp_create_librarian";

            // Params
            SqlParameter parameterId = new SqlParameter("@id", librarian.Id);
            SqlParameter parameterFirstName = new SqlParameter("@first_name", librarian.FirstName);
            SqlParameter parameterLastName = new SqlParameter("@last_name", librarian.LastName);
            SqlParameter parameterBirthday = new SqlParameter("@birthday", librarian.Birthday);
            SqlParameter parameterSex = new SqlParameter("@sex", librarian.Sex);
            SqlParameter parameterAddress = new SqlParameter("@address", librarian.Address);
            SqlParameter parameterEmail = new SqlParameter("@email", librarian.Email);
            SqlParameter parameterUsername = new SqlParameter("@username", account.Username);
            SqlParameter parameterPassword = new SqlParameter("@password", account.Password);
            SqlParameter parameterEnable = new SqlParameter("@enable", account.Enable);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail, parameterUsername,
                parameterPassword, parameterEnable);
        }
    }
}
