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
    public class AccountRepository
    {
        public Account FindAccountByLibrarianId(string librarianId)
        {
            string commandText = "SELECT * FROM Account WHERE UserableId = @id AND UserableType = N'Librarian'";
            SqlParameter parameterLibrarianId = new SqlParameter("@id", librarianId);
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterLibrarianId);

            if (!reader.HasRows)
                throw new Exception("Không tìm thấy tài khoản được liên kết");

            Account account = new Account();
            DataAdapter.FillObject(reader, account);

            return account;
        }

        public void UpdatetByLibrarianId(string librarianId, Account account)
        {
            // Validate
            DataValidation.Validate(account);

            string commandText = "sp_update_librarian_account";
            SqlParameter parameterLibrarianId = new SqlParameter("@librarian_id", librarianId);
            SqlParameter parameterUsername = new SqlParameter("@username", account.Username);
            SqlParameter parameterPassword = new SqlParameter("@password_digest", account.Password);
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterLibrarianId, parameterUsername, parameterPassword);

            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }
    }
}
