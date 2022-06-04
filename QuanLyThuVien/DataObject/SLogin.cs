using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class SLogin
    {
        [Column("loginname")]
        public string LoginName { get; set; }

        [Column("username")]
        public string Username { get; set; }

        public string Password { get; set; }

        public List<SRole> SRoles { get; set; }

        public SLogin()
        {
            SRoles = new List<SRole>();
        }
    }
}
