using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class Account
    {
        [Column("Username")]
        public string Username { get; set; }

        [Column("Enable")]
        public bool Enable { get; set; }

        [Column("UserableId")]
        public string UserableID { get; set; }

        [Column("UserableType")]
        public string UserableType { get; set; }
    }
}
