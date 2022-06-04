using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class SRoleRepository : RepositoryAction<SRole>
    {
        public override List<SRole> GetAll()
        {
            string commandText = "SELECT name FROM sysusers WHERE issqlrole = 1";

            return Get(commandText);
        }

        public List<SRole> GetAllOfLogin(string loginname)
        {
            string commandText = "sp_get_all_roles_of_user";
            SqlParameter parameterLoginName = new SqlParameter("@loginname", loginname);
            SqlDataReader reader = DbConnection.ExecuteReader(commandText, CommandType.StoredProcedure, parameterLoginName);
            List<SRole> list = new List<SRole>();
            DataAdapter.Fill(reader, list);

            return list;
        }

        public override void Create(SRole obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Detail string
            string grantsString = "";
            string actionString = "";
            foreach (SGrant sg in obj.SGants)
            {
                actionString += sg.Select ? "SELECT, " : "";
                actionString += sg.Update ? "UPDATE, " : "";
                actionString += sg.Insert ? "INSERT, " : "";
                actionString += sg.Delete ? "DELETE, " : "";

                if (actionString == "")
                    continue;

                actionString = actionString.Remove(actionString.Length - 2);

                grantsString += $"GRANT {actionString} ON {sg.TableName} TO {obj.Name}\n";

                actionString = "";
            }

            // Command Text
            string commandText = $"CREATE ROLE {obj.Name}\n" + grantsString;

            // Transaction
            string sqlTransaction = $"BEGIN TRY BEGIN TRANSACTION {commandText} COMMIT TRANSACTION END " +
                "TRY BEGIN CATCH ROLLBACK TRANSACTION " +
                "DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT " +
                "SET @ErrorMessage  = ERROR_MESSAGE() SET @ErrorSeverity = ERROR_SEVERITY() SET @ErrorState = ERROR_STATE() " +
                "RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState) END CATCH";

            // Execute
            int rows = DbConnection.ExecuteNonQuery(sqlTransaction, CommandType.Text);

            // Exception
            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        public override void Update(SRole obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Detail string
            string grantsString = "";
            string actionString = "";
            foreach (SGrant sg in obj.SGants)
            {
                actionString += sg.Select ? "SELECT, " : "";
                actionString += sg.Update ? "UPDATE, " : "";
                actionString += sg.Insert ? "INSERT, " : "";
                actionString += sg.Delete ? "DELETE, " : "";

                if (actionString == "")
                    continue;

                actionString = actionString.Remove(actionString.Length - 2);

                grantsString += $"REVOKE ALL ON {sg.TableName} FROM {obj.Name}\nGRANT {actionString} ON {sg.TableName} TO {obj.Name}\n";

                actionString = "";
            }

            // Command Text
            string commandText = grantsString;

            // Transaction
            string sqlTransaction = $"BEGIN TRY BEGIN TRANSACTION {commandText} COMMIT TRANSACTION END " +
                "TRY BEGIN CATCH ROLLBACK TRANSACTION " +
                "DECLARE @ErrorMessage VARCHAR(MAX), @ErrorSeverity INT, @ErrorState INT " +
                "SET @ErrorMessage  = ERROR_MESSAGE() SET @ErrorSeverity = ERROR_SEVERITY() SET @ErrorState = ERROR_STATE() " +
                "RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState) END CATCH";

            // Execute
            int rows = DbConnection.ExecuteNonQuery(sqlTransaction, CommandType.Text);

            // Exception
            if (rows == 0)
                throw new Exception("Tạo không thành công");
        }

        public override void Delete(object id)
        {
            // Command text
            string commandText = $"DROP ROLE {id}";

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.Text);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }
    }
}
