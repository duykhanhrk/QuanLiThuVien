using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class BackupRestoreRepository
    {
        public void FullBackup()
        {
            string commandText = @"BACKUP DATABASE QLTV TO DISK = 'D:\Backup\QLTV_FullBackup.bak' WITH INIT";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void DiffBackup()
        {
            string commandText = @"BACKUP DATABASE QLTV TO DISK = 'D:\Backup\QLTV_Differential.bak' WITH DIFFERENTIAL, INIT";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void FullRestore()
        {
            string commandText = @"ALTER DATABASE QLTV SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                   RESTORE DATABASE QLTV FROM DISK = 'D:\Backup\QLTV_FullBackup.bak' WITH REPLACE, NORECOVERY;
                                   ALTER DATABASE QLTV SET MULTI_USER";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void DiffRestore()
        {
            string commandText = @"ALTER DATABASE QLTV SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                   RESTORE DATABASE QLTV FROM DISK = 'D:\Backup\QLTV_Differential.bak' WITH RECOVERY;
                                   ALTER DATABASE QLTV SET MULTI_USER";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }
    }
}
