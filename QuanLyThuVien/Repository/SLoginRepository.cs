using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyThuVien.Repository
{
    public class SLoginRepository
    {
        public List<SLogin> GetAll()
        {
            string commandText = @"SELECT L.name as loginname, U.name as username FROM sys.sysusers U
                                   LEFT JOIN sys.syslogins L ON L.sid = U.sid
                                   WHERE U.islogin = 1 AND L.name IS NOT NULL";

            SqlDataReader reader = DbConnection.ExecuteReader("SA", commandText, CommandType.Text);
            List<SLogin> list = new List<SLogin>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public void Create(SLogin obj)
        {
            // Command Text
            string commandText = "sp_create_login";

            // Params
            SqlParameter parameterLoginName = new SqlParameter("@loginname", obj.LoginName);
            SqlParameter parameterUsername = new SqlParameter("@username", obj.LoginName);
            SqlParameter parameterPassword = new SqlParameter("@password", obj.Password);
            SqlParameter parameterRoles = new SqlParameter("@roles", string.Join(",", obj.SRoles.Select(t => t.Name)));

            // Execute
            int rows = DbConnection.ExecuteNonQuery("SA", commandText, CommandType.StoredProcedure,
                parameterLoginName, parameterUsername, parameterPassword, parameterRoles);

            // Exception
            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        public void Update(SLogin obj)
        {
            // Command Text
            string commandText = "sp_update_login";

            // Params
            SqlParameter parameterLoginName = new SqlParameter("@loginname", obj.LoginName);
            SqlParameter parameterPassword = new SqlParameter("@password", obj.Password);
            SqlParameter parameterRoles = new SqlParameter("@roles", string.Join(",", obj.SRoles.Select(t => t.Name)));

            // Execute
            int rows = DbConnection.ExecuteNonQuery("SA", commandText, CommandType.StoredProcedure,
                parameterLoginName, parameterPassword, parameterRoles);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }

        public void Delete(object loginname)
        {
            // Command Text
            string commandText = "sp_delete_login";

            // Params
            SqlParameter parameterLoginName = new SqlParameter("@loginname", loginname);

            // Execute
            int rows = DbConnection.ExecuteNonQuery("SA", commandText, CommandType.StoredProcedure,
                parameterLoginName);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }
    }
}
