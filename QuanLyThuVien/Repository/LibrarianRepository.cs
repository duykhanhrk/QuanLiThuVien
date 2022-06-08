using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class LibrarianRepository : RepositoryAction<Librarian, string>
    {
        public override List<Librarian> FilterByKeyword(string search = "")
        {
            string commandText = "SELECT * FROM Librarian WHERE Id LIKE @search OR LastName + ' ' + FirstName LIKE @search OR Email LIKE @search OR Address LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);
            List<Librarian> list = new List<Librarian>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public override void Create(Librarian librarian, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(librarian);
            DataValidation.Validate(librarian.Account);

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
            SqlParameter parameterUsername = new SqlParameter("@username", librarian.Account.Username);
            SqlParameter parameterPassword = new SqlParameter("@password_digest", librarian.Account.PasswordDigest);
            SqlParameter parameterEnable = new SqlParameter("@enable", librarian.Account.Enable);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail,
                parameterUsername, parameterPassword, parameterEnable);

            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        public override void Update(Librarian librarian, params KeyValuePair<string, object>[] pairs)
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
            SqlParameter parameterUsername = new SqlParameter("@username", librarian.Account.Username);
            SqlParameter parameterPassword = new SqlParameter("@password_digest", librarian.Account.PasswordDigest);
            SqlParameter parameterEnable = new SqlParameter("@enable", librarian.Account.Enable);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterId, parameterFirstName, parameterLastName, parameterBirthday,
                parameterSex, parameterAddress, parameterEmail,
                parameterUsername, parameterPassword, parameterEnable);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }

        public override void Delete(string id)
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
