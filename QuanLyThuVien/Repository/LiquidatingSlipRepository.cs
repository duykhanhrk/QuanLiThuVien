using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class LiquidatingSlipRepository : RepositoryAction<LiquidatingSlip>
    {
        public long FindNextId()
        {
            string commandText = $"SELECT IDENT_CURRENT('{tableName}') + 1";
            long maxId = Int64.Parse(DbConnection.ExecuteScalar(commandText, CommandType.Text).ToString());

            return maxId;
        }

        public override void Create(LiquidatingSlip obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Detail string
            string detailsString = "";
            foreach (LiquidatingSlipDetail ld in obj.LiquidatingSlipDetails)
            {
                detailsString += $"('{ld.BookId}', @liquidating_slip_id, '{ld.Price}', '{ld.Notes}'), ";
            }

            if (detailsString.Length > 0)
            {
                detailsString = detailsString.Remove(detailsString.Length - 2);
                detailsString = "INSERT INTO LiquidatingSlipDetail (BookId, LiquidatingSlipId, Price, Notes) VALUES " + detailsString;
            }

            // Command Text
            string commandText = "DECLARE @OutputTbl TABLE (Id BIGINT) " +
                "DECLARE @liquidating_slip_id BIGINT " +
                "INSERT INTO LiquidatingSlip (CreatedBy, CreatedAt) " +
                "OUTPUT Inserted.Id INTO @OutputTbl(Id) " +
                $"VALUES ('{obj.CreatedBy}', CURRENT_TIMESTAMP) " +
                "SELECT @liquidating_slip_id = Id FROM @OutputTbl " +
                detailsString;

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

        public override void Update(LiquidatingSlip obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Detail string
            string detailsString = "";
            foreach (LiquidatingSlipDetail ld in obj.LiquidatingSlipDetails)
            {
                detailsString += $"('{ld.BookId}', '{ld.LiquidatingSlipId}', '{ld.Price}', '{ld.Notes}'), ";
            }

            if (detailsString.Length > 0)
            {
                detailsString = detailsString.Remove(detailsString.Length - 2);
                detailsString = "INSERT INTO LiquidatingSlipDetail (BookId, LiquidatingSlipId, Price, Notes) VALUES " + detailsString;
            }

            // Command Text
            string commandText = $"DELETE FROM LiquidatingDetail WHERE LiquidatingDetail = {obj.Id} " + detailsString;

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
                throw new Exception("Cập nhật không thành công");
        }
    }
}
