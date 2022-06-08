using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyThuVien.Lib
{
    public class RepositoryAction<T, L>
    {
        protected string tableName;

        private string filterByKeywordString;

        private string buildFilterByKeywordString()
        {
            // Filter By Keyword String
            List<String> cmps = new List<String>();

            var properties = typeof(T).GetProperties();

            ColumnAttribute columnAttribute;
            BrowsableAttribute browsableAttribute;
            foreach (var property in properties)
            {
                // Only string
                if (property.PropertyType != typeof(string))
                    continue;

                // Without Browsable(false)
                browsableAttribute = (BrowsableAttribute)property.GetCustomAttributes(typeof(BrowsableAttribute), true).FirstOrDefault();
                if (browsableAttribute != null && !browsableAttribute.Browsable)
                    continue;

                // Only column
                columnAttribute = (ColumnAttribute)property.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
                if (columnAttribute == null)
                    continue;

                cmps.Add($"{columnAttribute.Name} LIKE @keyword");
            }

            return String.Join(" OR ", cmps);
        }

        private string findTableName()
        {
            // Table name
            try
            {
                return (typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0] as TableAttribute).Name;
            }
            catch
            {
                return typeof(T).Name;
            }
        }

        public RepositoryAction()
        {
            tableName = findTableName();
            filterByKeywordString = buildFilterByKeywordString();
        }

        public virtual List<T> GetAll()
        {
            SqlDataReader reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName}", CommandType.Text);
            List<T> list = new List<T>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public virtual List<T> GetAllBy(string propertyName, object value)
        {
            string columnName = ((ColumnAttribute)typeof(T).GetProperty(propertyName).GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault()).Name;
            SqlParameter parameterSearch = new SqlParameter($"@{columnName.ToUnderscore()}", value);
            SqlDataReader reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName} WHERE {columnName} = @{columnName.ToUnderscore()}", CommandType.Text, parameterSearch);

            List<T> list = new List<T>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public virtual List<T> GetAllBy(params KeyValuePair<string, object>[] pairs)
        {
            List<String> cmp = new List<string>();
            string columnName;
            List<SqlParameter> parameters = new List<SqlParameter>();

            foreach (KeyValuePair<string, object> pair in pairs)
            {
                columnName = ((ColumnAttribute)typeof(T).GetProperty(pair.Key).GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault()).Name;
                cmp.Add($"{columnName} = @{columnName.ToUnderscore()}");
                parameters.Add(new SqlParameter($"@{columnName.ToUnderscore()}", pair.Value));
            }

            SqlDataReader reader;
            if (cmp.Count != 0)
                reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName} WHERE {String.Join(" AND ", cmp)}", CommandType.Text, parameters.ToArray());
            else
                reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName}", CommandType.Text);

            if (!reader.HasRows)
                throw new Exception($"Không tìm thấy đối tượng được yêu cầu");

            List<T> list = new List<T>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public virtual List<T> Get(string commandText, params SqlParameter[] parameters)
        {
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameters);
            List<T> list = new List<T>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public virtual T FindById(L id)
        {
            SqlParameter parameterSearch = new SqlParameter("@Id", id);
            SqlDataReader reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName} WHERE Id = @id", CommandType.Text, parameterSearch);

            if (!reader.HasRows)
                throw new Exception($"Không tìm thấy đối tượng được yêu cầu");

            T t = (T)Activator.CreateInstance(typeof(T));
            DataAdapter.FillObject(reader, t);

            return t;
        }

        public virtual T FindBy(string propertyName, object value)
        {
            string columnName = ((ColumnAttribute)typeof(T).GetProperty(propertyName).GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault()).Name;
            SqlParameter parameterSearch = new SqlParameter($"@{columnName.ToUnderscore()}", value);
            SqlDataReader reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName} WHERE {columnName} = @{columnName.ToUnderscore()}", CommandType.Text, parameterSearch);

            if (!reader.HasRows)
                throw new Exception($"Không tìm thấy đối tượng được yêu cầu");

            T t = (T)Activator.CreateInstance(typeof(T));
            DataAdapter.FillObject(reader, t);

            return t;
        }

        public virtual T FindBy(params KeyValuePair<string, object>[] pairs)
        {
            List<String> cmp = new List<string>();
            string columnName;
            List<SqlParameter> parameters = new List<SqlParameter>();

            foreach (KeyValuePair<string, object> pair in pairs)
            {
                columnName = ((ColumnAttribute)typeof(T).GetProperty(pair.Key).GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault()).Name;
                cmp.Add($"{columnName} = @{columnName.ToUnderscore()}");
                parameters.Add(new SqlParameter($"@{columnName.ToUnderscore()}", pair.Value));
            }

            SqlDataReader reader;
            if (cmp.Count != 0)
                reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName} WHERE {String.Join(" AND ", cmp)}", CommandType.Text, parameters.ToArray());
            else
                reader = DbConnection.ExecuteReader($"SELECT * FROM {tableName}", CommandType.Text);

            if (!reader.HasRows)
                throw new Exception($"Không tìm thấy đối tượng được yêu cầu");

            T t = (T)Activator.CreateInstance(typeof(T));
            DataAdapter.FillObject(reader, t);

            return t;
        }

        public virtual T Find(string commandText, params SqlParameter[] parameters)
        {
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameters);

            if (!reader.HasRows)
                throw new Exception($"Không tìm thấy đối tượng được yêu cầu");

            T t = (T)Activator.CreateInstance(typeof(T));
            DataAdapter.FillObject(reader, t);

            return t;
        }

        public virtual void Create(T obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Params
            SqlParameter[] parameters = LazyMagic.BuildParams(obj, pairs);

            // Execute
            int rows = DbConnection.ExecuteNonQuery($"sp_create_{typeof(T).Name.ToUnderscore()}", CommandType.StoredProcedure, parameters);

            // Exception
            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        public virtual void Update(T obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Params
            SqlParameter[] parameters = LazyMagic.BuildParams(obj, pairs);

            // Execute
            int rows = DbConnection.ExecuteNonQuery($"sp_update_{typeof(T).Name.ToUnderscore()}", CommandType.StoredProcedure, parameters);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }

        public virtual void Delete(L id)
        {
            // Params
            SqlParameter parameterId = new SqlParameter("@id", id);

            // Execute
            int rows = DbConnection.ExecuteNonQuery($"DELETE FROM " + tableName + " WHERE Id = @id", CommandType.Text, parameterId);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }

        public virtual List<T> FilterByKeyword(string keyword)
        {
            string commandText = filterByKeywordString == "" ? $"SELECT * FROM {tableName}" : $"SELECT * FROM {tableName} WHERE {filterByKeywordString}";
            SqlParameter parameterSearch = new SqlParameter("@keyword", $"%{keyword.Trim()}%");
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.Text, parameterSearch);
            List<T> list = new List<T>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public virtual L FindNextId()
        {
            string commandText = $"SELECT IDENT_CURRENT('{tableName}') + 1";
            object nextId = Int64.Parse(DbConnection.ExecuteScalar(commandText, CommandType.Text).ToString());

            return (L)nextId;
        }

        public virtual L FindNextId(string prefix)
        {
            string commandText = $"SELECT MAX(Id) FROM {tableName} WHERE Id LIKE '{prefix}[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
            string maxId = (string)DbConnection.ExecuteScalar(commandText, CommandType.Text);

            object nextId = prefix + (Int64.Parse(maxId.Substring(prefix.Length)) + 1).ToString().PadLeft(8, '0');

            return (L)nextId;
        }
    }
}
