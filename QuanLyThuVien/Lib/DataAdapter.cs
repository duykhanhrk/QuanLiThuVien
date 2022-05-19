using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Lib
{
    public static class DataAdapter
    {
        public static void Fill<T>(SqlDataReader reader, List<T> list)
        {
            while (reader.Read())
            {
                T t = (T)Activator.CreateInstance(typeof(T));

                var properties = typeof(T).GetProperties();

                ColumnAttribute columnAttribute;
                RequiredAttribute requiredAttribute;
                foreach (var property in properties)
                {
                    columnAttribute = (ColumnAttribute)property.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
                    if (columnAttribute == null)
                        continue;

                    requiredAttribute = (RequiredAttribute)property.GetCustomAttribute(typeof(RequiredAttribute), true);
                    if (requiredAttribute == null)
                    {
                        try
                        {
                            property.SetValue(t, reader[columnAttribute.Name]);
                        }
                        catch
                        {
                            // pass
                        }

                        continue;
                    }

                    property.SetValue(t, reader[columnAttribute.Name]);
                }

                list.Add(t);
            }
        }

        public static void FillObject(SqlDataReader reader, Object obj)
        {
            reader.Read();

            var properties = obj.GetType().GetProperties();
            ColumnAttribute columnAttribute;
            foreach (var property in properties)
            {
                Object _obj = property.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
                if (_obj == null)
                    continue;

                columnAttribute = (ColumnAttribute)_obj;

                property.SetValue(obj, reader[columnAttribute.Name]);
            }
        }
    }
}
