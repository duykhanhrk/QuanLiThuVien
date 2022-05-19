using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class Reader
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(10)]
        [DisplayName("Id")]
        [Column("Id")]
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(30)]
        [DisplayName("Tên")]
        [Column("FirstName")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        [DisplayName("Họ")]
        [Column("LastName")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Giới tính")]
        [Column("Sex")]
        public bool Sex { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Địa chỉ")]
        [Column("Address")]
        public string Address { get; set; }

        [Required]
        [DisplayName("Sinh nhật")]
        [Column("Birthday")]
        public DateTime Birthday { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("PhoneNumber")]
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("LibrarianId")]
        [Column("LibrarianId")]
        public string LibrarianId { get; set; }

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
