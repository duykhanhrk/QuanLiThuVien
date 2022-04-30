using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Lib
{
    public static class CommonTask
    {
        /// <summary>
        /// This method use to get all book categories form Database
        /// </summary>
        public static List<T> GetAll<T>(string condition = "", params SqlParameter[] parameters)
        {
            string tableName = typeof(T).Name;

            TableAttribute tableAttribute = (TableAttribute)typeof(Account).GetCustomAttributes(typeof(TableAttribute), true).FirstOrDefault();
            if (tableAttribute != null)
                tableName = tableAttribute.Name;

            string commandText = "SELECT * FROM " + tableName;
            if (condition != "")
                commandText += " WHERE " + condition;

            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameters);
            List<T> list = new List<T>();
            DataAdapter.Fill(reader, list);

            return list;
        }
    }
}
