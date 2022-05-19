using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class Librarian
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Id không được để trắng")]
        [StringLength(10)]
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
        [Column("Sex")]
        public bool Sex { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email không được để trắng")]
        [DisplayName("Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Địa chỉ không được để trắng")]
        [DisplayName("Địa chỉ")]
        [Column("Address")]
        public string Address { get; set; }

        public Librarian()
        {
        }

        public Librarian(string id, string firstName, string lastName, DateTime birthday, bool sex, string address, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Sex = sex;
            Address = address;
            Email = email;
        }
    }
}
