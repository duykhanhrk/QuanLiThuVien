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
    public class SGantRepository : RepositoryAction<SGrant>
    {
        public List<SGrant> GetAllOfSRole(string roleName)
        {
            string commandText = "sp_get_sgrants_of_role";
            SqlParameter parameterRoleName = new SqlParameter("@role_name", roleName);
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.StoredProcedure, parameterRoleName);

            List<SGrant> list = new List<SGrant>();
            DataAdapter.Fill(reader, list);

            return list;
        }
    }
}
