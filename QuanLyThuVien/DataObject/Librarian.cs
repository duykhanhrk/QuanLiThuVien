using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class Librarian
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã không được để trắng")]
        [RegularExpression(@"^LB([0-9]{8})$", ErrorMessage = "Mã không đúng định dạng")]
        [DisplayName("Id")]
        [Column("Id")]
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Họ không được để trắng")]
        [MaxLength(50)]
        [DisplayName("Họ")]
        [Column("LastName")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên không được để trắng")]
        [MaxLength(30)]
        [DisplayName("Tên")]
        [Column("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Sinh nhật")]
        [Column("Birthday")]
        public DateTime Birthday { get; set; }

        [Required]
        [DisplayName("Giới tính")]
        [Browsable(false)]
        [Column("Sex")]
        public bool Sex { get; set; }

        [DisplayName("Giới tính")]
        public string SexDisplay
        {
            get { return Sex ? "Nam" : "Nữ"; }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email không được để trắng")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không đúng định dạng")]
        [DisplayName("Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Địa chỉ không được để trắng")]
        [DisplayName("Địa chỉ")]
        [Column("Address")]
        public string Address { get; set; }

        [Browsable(false)]
        public Account Account { get; set; }

        public Librarian()
        {
            Account = new Account();
        }
    }
}
