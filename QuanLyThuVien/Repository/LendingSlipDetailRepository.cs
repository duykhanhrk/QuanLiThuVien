using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class LendingSlipDetailRepository : RepositoryAction<LendingSlipDetail>
    {
        public List<LendingSlipDetail> GetAllOfLendingSlip(long lendingSlipId)
        {
            string commandText = "SELECT * FROM LendingSlipDetail WHERE LendingSlipId = @lending_slip_id";
            SqlParameter parameterLendingSlipId = new SqlParameter("@lending_slip_id", lendingSlipId);

            return Get(commandText, parameterLendingSlipId);
        }
    }
}
