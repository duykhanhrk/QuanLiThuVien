using QuanLyThuVien.Lib;
using System.Data;
namespace QuanLyThuVien.Repository
{
    public class SLoginRepository
    {
        public DataTable GetAll() => DbConnection.ExecuteAdapter("SELECT [name] from master.sys.sql_logins");
    }
}
