using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.Repository
{
    public class LendingSlipDetailRepository : RepositoryAction<LendingSlipDetail, long>
    {
        public List<LendingSlipDetail> GetAllOfLendingSlip(long lendingSlipId)
        {
            string commandText = "SELECT * FROM LendingSlipDetail WHERE LendingSlipId = @lending_slip_id";
            SqlParameter parameterLendingSlipId = new SqlParameter("@lending_slip_id", lendingSlipId);

            return Get(commandText, parameterLendingSlipId);
        }

        public void TookBack(LendingSlipDetail lendingSlipDetail)
        {
            string commandText = "sp_update_lending_slip_detail_took_back";

            SqlParameter parameterBookId = new SqlParameter("@book_id", lendingSlipDetail.BookId);
            SqlParameter parameterLendingSlipId = new SqlParameter("@lending_slip_id", lendingSlipDetail.LendingSlipId);
            SqlParameter parameterLibrarianId = new SqlParameter("@librarian_id", lendingSlipDetail.TookBackBy);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterBookId, parameterLendingSlipId, parameterLibrarianId);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }

        public void Extend(LendingSlipDetail lendingSlipDetail)
        {
            string commandText = "sp_update_lending_slip_detail_extended";

            SqlParameter parameterBookId = new SqlParameter("@book_id", lendingSlipDetail.BookId);
            SqlParameter parameterLendingSlipId = new SqlParameter("@lending_slip_id", lendingSlipDetail.LendingSlipId);
            SqlParameter parameterLibrarianId = new SqlParameter("@librarian_id", lendingSlipDetail.ExtendedBy);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure,
                parameterBookId, parameterLendingSlipId, parameterLibrarianId);

            // Exception
            if (rows == 0)
                throw new Exception("Cập nhật không thành công");
        }
    }
}
