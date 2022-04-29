using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class AuthRepository
    {
        public Librarian Login(string username, string password)
        {
            // For testing
            Debug.WriteLine("Password digest: " + PasswordSecurity.Encrypt(password));

            string commandText = "sp_librarian_login";
            SqlParameter parameterUsername = new SqlParameter("@username", username);
            SqlParameter parameterPasswordDigest = new SqlParameter("@password_digest", PasswordSecurity.Encrypt(password));
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.StoredProcedure,
                parameterUsername,
                parameterPasswordDigest);

            if (!reader.HasRows)
                throw new Exception("Hệ thống xảy ra lỗi, hãy thông báo cho Quản trị viên để được hỗ trợ!");

            Librarian librarian = new Librarian();
            DataAdapter.FillObject(reader, librarian);

            return librarian;
        }
    }
}
