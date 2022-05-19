using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class ReaderRepository : RepositoryAction<Reader>
    {
        public List<Reader> GetAll(string search)
        {
            string commandText = "SELECT * FROM Reader WHERE Id LIKE @search OR LastName + ' ' + FirstName LIKE @search OR Email LIKE @search OR Address LIKE @search";
            SqlParameter parameterSearch = new SqlParameter("@search", $"%{search.Trim()}%");

            return Get(commandText, parameterSearch);
        }

        public string FindMaxId()
        {
            string commandText = "SELECT MAX(Id) FROM Reader WHERE Id LIKE 'RD[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
            string maxId = (string)DbConnection.ExecuteScalar(commandText, CommandType.Text);

            return maxId;
        }
    }
}
