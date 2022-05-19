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
        /// Does a librarian exists?
        /// </summary>
        /// <param name="librarian"></param>
        /// <returns></returns>
        public bool Exists(Librarian librarian)
        {
            string commandText = "SELECT COUNT(*) FROM Librarian WHERE Id = @id";
            SqlParameter parameterSearch = new SqlParameter("@id", librarian.Id);
            int count = (int) DbConnection.ExecuteScalar(commandText, CommandType.Text, parameterSearch);

            return count > 0;
        }

        /// <summary>
        /// Does a librarian exists?
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exists(string id)
        {
            string commandText = "SELECT COUNT(*) FROM Librarian WHERE Id = @id";
            SqlParameter parameterSearch = new SqlParameter("@id", id);
            int count = (int)DbConnection.ExecuteScalar(commandText, CommandType.Text, parameterSearch);

            return count > 0;
        }

        /// <summary>
        /// Find librarian by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Librarian FindById(string id)
        {
            string commandText = "SELECT * FROM Librarian WHERE Id = @id";
            SqlParameter parameterSearch = new SqlParameter("@id", id);
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);

            if (!reader.HasRows)
                throw new Exception($"Không tìm thấy thủ thư với Id = {id}");

            Librarian librarian = new Librarian();
            DataAdapter.FillObject(reader, librarian);

            return librarian;
        }

        /// <summary>
        /// Get all librarians
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
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
        /// Find max Id
        /// </summary>
        /// <returns></returns>
        public string FindMaxId()
        {
            string commandText = "SELECT MAX(Id) FROM Librarian WHERE Id LIKE 'LB[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
            string maxId = (string)DbConnection.ExecuteScalar(commandText, CommandType.Text);

            return maxId;
        }

        /// <summary>
        /// Create a new librarian, include account
        /// </summary>
        /// <param name="librarian"></param>
        /// <param name="account"></param>
        public void CreateIncludeAccount(Librarian librarian, Account account)
        {
            // Validate
            DataValidation.Validate(librarian);
            DataValidation.Validate(account);

            // Command Text
            string commandText = "sp_create_librarian_include_account";

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

            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        /// <summary>
        /// Update a librarian, include account
        /// </summary>
        /// <param name="librarian"></param>
        /// <param name="account"></param>
        /// <exception cref="Exception"></exception>
        public void UpdateIncludeAccount(Librarian librarian, Account account)
        {
            // Validate
            DataValidation.Validate(librarian);
            DataValidation.Validate(account);

            // Command Text
            string commandText = "sp_update_librarian_include_account";

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

            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        /// <summary>
        /// Save a librarian
        /// </summary>
        /// <param name="librarian"></param>
        /// <exception cref="Exception"></exception>
        public void Save(Librarian librarian)
        {
            string commandText = "sp_create_librarian";
            if (Exists(librarian))
                commandText = "sp_update_librarian";

            // Validate
            DataValidation.Validate(librarian);

            // Params
            SqlParameter parameterId = new SqlParameter("@id", librarian.Id);
            SqlParameter parameterFirstName = new SqlParameter("@first_name", librarian.FirstName);
            SqlParameter parameterLastName = new SqlParameter("@last_name", librarian.LastName);
            SqlParameter parameterBirthday = new SqlParameter("@birthday", librarian.Birthday);
            SqlParameter parameterSex = new SqlParameter("@sex", librarian.Sex);
            SqlParameter parameterAddress = new SqlParameter("@address", librarian.Address);
            SqlParameter parameterEmail = new SqlParameter("@email", librarian.Email);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail);

            if (rows == 0)
                throw new Exception("Lưu không thành công");
        }

        /// <summary>
        /// Create a new librarian
        /// </summary>
        /// <param name="librarian"></param>
        /// <param name="account"></param>
        public void Create(Librarian librarian)
        {
            // Validate
            DataValidation.Validate(librarian);

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

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail);

            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        /// <summary>
        /// Update a librarian
        /// </summary>
        /// <param name="librarian"></param>
        /// <exception cref="Exception"></exception>
        public void Update(Librarian librarian)
        {
            // Validate
            DataValidation.Validate(librarian);

            // Command Text
            string commandText = "sp_update_librarian";

            // Params
            SqlParameter parameterId = new SqlParameter("@id", librarian.Id);
            SqlParameter parameterFirstName = new SqlParameter("@first_name", librarian.FirstName);
            SqlParameter parameterLastName = new SqlParameter("@last_name", librarian.LastName);
            SqlParameter parameterBirthday = new SqlParameter("@birthday", librarian.Birthday);
            SqlParameter parameterSex = new SqlParameter("@sex", librarian.Sex);
            SqlParameter parameterAddress = new SqlParameter("@address", librarian.Address);
            SqlParameter parameterEmail = new SqlParameter("@email", librarian.Email);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }

        /// <summary>
        /// Delete a librarian
        /// </summary>
        /// <param name="librarian"></param>
        /// <exception cref="Exception"></exception>
        public void Delete(Librarian librarian)
        {
            // Command Text
            string commandText = "sp_delete_librarian";

            // Params
            SqlParameter parameterId = new SqlParameter("@id", librarian.Id);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure, parameterId);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }

        /// <summary>
        /// Delete a librarian
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Delete(string id)
        {
            // Command Text
            string commandText = "sp_delete_librarian";

            // Params
            SqlParameter parameterId = new SqlParameter("@id", id);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure, parameterId);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }
    }
}
