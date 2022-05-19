using QuanLyThuVien.Lib;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

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

        [Required]
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

        public Account(string username, string password)
        {
            Debug.WriteLine(PasswordSecurity.Encrypt(password));
            Username = username;
            Password = password;
            Debug.WriteLine(Password);
        }

        public Account(string username, string password, bool enable)
        {
            Debug.WriteLine(PasswordSecurity.Encrypt(password));
            Username = username;
            Password = password;
            Enable = enable;
            Debug.WriteLine(Password);
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
