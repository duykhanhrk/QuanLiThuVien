using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    [Table("Account")]
    public class Account
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        [MinLength(1)]
        [Column("Username")]
        [DisplayName("Tên đăng nhập")]
        public string Username { get; set; }

        [Column("Enable")]
        public bool Enable { get; set; }

        [Column("UserableId")]
        public string UserableID { get; set; }

        [Column("UserableType")]
        public string UserableType { get; set; }

        private string password_digest;

        [Required(AllowEmptyStrings = false)]
        [MinLength(1)]
        public string Password
        {
            get { return password_digest; }
            set { password_digest = PasswordSecurity.Encrypt(value); }
        }

        public Account()
        {
        }

        public Account(string username, string password, bool enable)
        {
            Username = username;
            Password = password;
            Enable = enable;
        }

        public Account(string username, string password, bool enable, string userableID, string userableType)
        {
            Username = username;
            Password = password;
            Enable = enable;
            UserableID = userableID;
            UserableType = userableType;
        }
    }
}
