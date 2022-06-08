using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class Reader
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã không được để trắng")]
        [RegularExpression(@"^RD([0-9]{8})$", ErrorMessage = "Mã không đúng định dạng")]
        [DisplayName("Mã")]
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
        [Column("Sex")]
        [Browsable(false)]
        public bool Sex { get; set; }

        [DisplayName("Giới tính")]
        public string SexDisplay
        {
            get { return Sex ? "Nam" : "Nữ"; }
        }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Địa chỉ")]
        [Column("Address")]
        public string Address { get; set; }

        [Required]
        [DisplayName("Sinh nhật")]
        [Column("Birthday")]
        public DateTime Birthday { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không đúng định dạng")]
        [DisplayName("Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        [DisplayName("Số điện thoại")]
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Browsable(false)]
        [Column("LibrarianId")]
        public string LibrarianId { get; set; }

        [Browsable(false)]
        public string IdFullNameDisplay
        {
            get { return $"{Id} - {LastName} {FirstName}"; }
        }

        public Reader()
        {
        }

        public Reader(string id, string firstName, string lastName, bool sex, string address, DateTime birthday, string email, string phoneNumber, string librarianId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Address = address;
            Birthday = birthday;
            Email = email;
            PhoneNumber = phoneNumber;
            LibrarianId = librarianId;
        }
    }
}
