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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên đăng nhập không thể để trắng")]
        [RegularExpression(@"^[a-zA-Z0-9]{2,50}$", ErrorMessage = "Tên đăng nhập ít nhất 2 kí tự, không chứa khoảng trắng và kí tự đặc biệt")]
        [DisplayName("Tên đăng nhập")]
        [Column("Username")]
        public string Username { get; set; }

        [Required]
        [Column("Enable")]
        public bool Enable { get; set; }

        [Column("UserableId")]
        public string UserableId { get; set; }

        [Column("UserableType")]
        public string UserableType { get; set; }

        private string passwordDigest;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mật khẩu không được để trống")]
        public string PasswordDigest
        {
            get { return passwordDigest; }
        }

        public string Password
        {
            set { passwordDigest = PasswordSecurity.Encrypt(value); }
        }

        public Account()
        {
        }
    }
}
