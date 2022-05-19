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
    public class LibraryCardRepository : RepositoryAction<LibraryCard>
    {
        public long FindNextId()
        {
            string commandText = $"SELECT IDENT_CURRENT('{tableName}') + 1";
            long maxId = Int64.Parse(DbConnection.ExecuteScalar(commandText, CommandType.Text).ToString());

            return maxId;
        }
    }
}
