using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class BackupRestoreRepository
    {
        private string basePath;

        public BackupRestoreRepository()
        {
            basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            // Debug
            Debug.WriteLine("Backup: " + basePath);
        }

        public void FullBackup()
        {
            string commandText = "BACKUP DATABASE QLTV TO DISK = '" + basePath + @"\QLTV_Full.bak' WITH INIT";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void DiffBackup()
        {
            string commandText = "BACKUP DATABASE QLTV TO DISK = '" + basePath + @"\QLTV_Diff.bak' WITH DIFFERENTIAL, INIT";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void FullRestore()
        {
            string commandText = @"ALTER DATABASE QLTV SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                                   BACKUP LOG QLTV TO DISK = '" + basePath + @"\QLTV_Log.trn' WITH INIT, NORECOVERY
                                   RESTORE DATABASE QLTV FROM DISK = '" + basePath + @"\QLTV_Full.bak' WITH RECOVERY
                                   ALTER DATABASE QLTV SET MULTI_USER";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void DiffRestore()
        {
            string commandText = @"ALTER DATABASE QLTV SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                                   BACKUP LOG QLTV TO DISK = '" + basePath + @"\QLTV_Log.trn' WITH INIT, NORECOVERY
                                   RESTORE DATABASE QLTV FROM DISK = '" + basePath + @"\QLTV_Full.bak' WITH NORECOVERY
                                   RESTORE DATABASE QLTV FROM DISK = '" + basePath + @"\QLTV_Diff.bak' WITH RECOVERY
                                   ALTER DATABASE QLTV SET MULTI_USER";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }

        public void Restore()
        {
            string commandText = @"RESTORE DATABASE QLTV";

            // Execute
            DbConnection.ExecuteNonQuery("Master", commandText, CommandType.Text);
        }
    }
}
