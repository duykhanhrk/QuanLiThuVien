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
    public class AccountRepository : RepositoryAction<Account, string>
    {
        public void UpdatetByLibrarianId(string librarianId, Account account)
        {
            // Validate
            DataValidation.Validate(account);

            string commandText = "sp_update_librarian_account";
            SqlParameter parameterLibrarianId = new SqlParameter("@librarian_id", librarianId);
            SqlParameter parameterUsername = new SqlParameter("@username", account.Username);
            SqlParameter parameterPassword = new SqlParameter("@password_digest", account.PasswordDigest);
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterLibrarianId, parameterUsername, parameterPassword);

            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }
    }
}
