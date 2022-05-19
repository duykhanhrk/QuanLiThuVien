using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class LendingSlipRepository : RepositoryAction<LendingSlip>
    {
        public long FindNextId()
        {
            string commandText = $"SELECT IDENT_CURRENT('{tableName}') + 1";
            long maxId = Int64.Parse(DbConnection.ExecuteScalar(commandText, CommandType.Text).ToString());

            return maxId;
        }

        public override void Create(LendingSlip obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Detail string
            string detailsString = "";
            foreach (LendingSlipDetail ld in obj.LendingSlipDetails)
            {
                detailsString += $"('{ld.BookId}', @lending_slip_id, '{ld.DueBackDate}', '{ld.Notes}'), ";
            }

            if (detailsString.Length > 0)
            {
                detailsString = detailsString.Remove(detailsString.Length - 2);
                detailsString = "INSERT INTO LendingSlipDetail (BookId, LendingSlipId, DueBackDate, Notes) VALUES " + detailsString;
            }

            // Command Text
            string commandText = "DECLARE @OutputTbl TABLE (Id BIGINT) " +
                "DECLARE @lending_slip_id BIGINT " +
                "INSERT INTO LendingSlip (ReaderId, CreatedByLibrarianId, CreatedAt) " +
                "OUTPUT Inserted.Id INTO @OutputTbl(Id) " +
                $"VALUES ('{obj.ReaderId}', '{obj.CreatedByLibrarianId}', CURRENT_TIMESTAMP) " +
                "SELECT @lending_slip_id = Id FROM @OutputTbl " +
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

        public override void Update(LendingSlip obj, params KeyValuePair<string, object>[] pairs)
        {
            // Validate
            DataValidation.Validate(obj);

            // Detail string
            string detailsString = "";
            foreach (LendingSlipDetail ld in obj.LendingSlipDetails)
            {
                detailsString += $"('{ld.BookId}', {obj.Id}, '{ld.DueBackDate}', '{ld.Notes}'), ";
            }

            if (detailsString.Length > 0)
            {
                detailsString = detailsString.Remove(detailsString.Length - 2);
                detailsString = "INSERT INTO LendingSlipDetail (BookId, LendingSlipId, DueBackDate, Notes) VALUES " + detailsString;
            }

            // Command Text
            string commandText = $"UPDATE LendingSlip SET ReaderID = '{obj.ReaderId}' WHERE Id = {obj.Id} " +
                $"DELETE FROM LendingSlipDetail WHERE LendingSlipId = {obj.Id} " +
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
                throw new Exception("Cập nhật không thành công");
        }
    }
}
