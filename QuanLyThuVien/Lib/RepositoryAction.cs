using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Lib
{
    public class RepositoryAction<T>
    {
        protected string tableName;
        protected string creationCmdText;
        protected string updateCmdText;
        protected string deleteCmdText;
        protected string getAllCmdText;
        protected string findByIdCmdText;

        public RepositoryAction()
        {
            // Table name
            try
            {
                tableName = (typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0] as TableAttribute).Name;
            }
            catch
            {
                tableName = typeof(T).Name;
            }
                

            // Get all, findById
            getAllCmdText = $"SELECT * FROM {tableName}";
            findByIdCmdText = $"SELECT * FROM {tableName} WHERE Id = @id";

            // Create, update
            creationCmdText = $"sp_create_{typeof(T).Name.ToUnderscore()}";
            updateCmdText = $"sp_update_{typeof(T).Name.ToUnderscore()}";

            // Delete
            deleteCmdText = $"DELETE FROM " + tableName + " WHERE Id = @id";
        }

        public virtual List<T> GetAll()
        {

            SqlDataReader reader = DbConnection.ExecuteReader(getAllCmdText, CommandType.Text);
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

        public virtual T FindById(Object id)
        {
            SqlParameter parameterSearch = new SqlParameter("@Id", id);
            SqlDataReader reader = DbConnection.ExecuteReader(findByIdCmdText, CommandType.Text, parameterSearch);

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
            int rows = DbConnection.ExecuteNonQuery(creationCmdText, CommandType.StoredProcedure, parameters);

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
            int rows = DbConnection.ExecuteNonQuery(updateCmdText, CommandType.StoredProcedure, parameters);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }

        public virtual void Delete(Object id)
        {
            // Params
            SqlParameter parameterId = new SqlParameter("@id", id);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(deleteCmdText, CommandType.Text, parameterId);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }
    }
}
