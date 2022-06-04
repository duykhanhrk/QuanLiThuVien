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
    public class LiquidatingSlipDetailRepository : RepositoryAction<LiquidatingSlipDetail>
    {
        public List<LiquidatingSlipDetail> GetAllOfLiquidatingSlip(long liquidatingSlipId)
        {
            string commandText = $"SELECT * FROM {tableName} WHERE LiquidatingSlipId = @liquidating_slip_id";
            SqlParameter parameterLiquidatingSlipId = new SqlParameter("@liquidating_slip_id", liquidatingSlipId);

            return Get(commandText, parameterLiquidatingSlipId);
        }
    }
}
