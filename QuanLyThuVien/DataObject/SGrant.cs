using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class SGrant
    {
        [Column("TABLE_NAME")]
        public string TableName { get; set; }

        [Column("SELECT")]
        public bool Select { get; set; }

        [Column("INSERT")]
        public bool Insert { get; set; }

        [Column("UPDATE")]
        public bool Update { get; set; }

        [Column("DELETE")]
        public bool Delete { get; set; }
    }
}
