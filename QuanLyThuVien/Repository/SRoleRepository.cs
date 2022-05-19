using QuanLyThuVien.Lib;
using System.Data;

namespace QuanLyThuVien.Repository
{
    public class SRoleRepository
    {
        public DataTable GetAll() => DbConnection.ExecuteAdapter("SELECT name FROM sysusers WHERE issqlrole = 1");
    }
}
