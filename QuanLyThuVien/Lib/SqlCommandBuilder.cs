using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Lib
{
    public static class SqlCommandBuilder
    {

        public static string Insert<T>(List<T> list)
        {
            return "";
        }

        public static string Insert<T>(List<T> list, Object[] propertyNames)
        {
            Type type = typeof(T);
            PropertyInfo property;
            Object value;

            foreach (T item in list)
            {
                foreach (var propertyName in propertyNames)
                {
                    if (propertyName.GetType() == typeof(string))
                    {
                        property = type.GetProperty((string)propertyName);
                        value = property.GetValue(item);
                    }
                    else
                    {
                        property = type.GetProperty(((KeyValuePair<string, Object>)propertyName).Key);
                        value = ((KeyValuePair<string, Object>)propertyName).Value;
                    }
                }


            }

            foreach (var propertyName in propertyNames)
            {
                if (propertyName.GetType() == typeof(string))
                {
                    property = type.GetProperty((string)propertyName);
                    value = property.GetValue(null, null);
                }
                else
                {
                    property = type.GetProperty(((KeyValuePair<string, Object>)propertyName).Key);
                    value = ((KeyValuePair<string, Object>)propertyName).Value;
                }
            }

            return "";
        }

        public static string Transaction(string[] sqlCommand)
        {
            // Transaction
            string sqlTransaction = $"BEGIN TRY BEGIN TRANSACTION {String.Join(" ", sqlCommand)} COMMIT TRANSACTION END " +
                "TRY BEGIN CATCH ROLLBACK TRANSACTION " +
                "DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT " +
                "SET @ErrorMessage  = ERROR_MESSAGE() SET @ErrorSeverity = ERROR_SEVERITY() SET @ErrorState = ERROR_STATE() " +
                "RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState) END CATCH";

            return sqlTransaction;
        }
    }
}
