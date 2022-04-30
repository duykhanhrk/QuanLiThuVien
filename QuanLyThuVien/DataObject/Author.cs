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
    public class Author
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
        [DisplayName("Sinh nhật")]
        [Column("Birthday")]
        public DateTime Birthday { get; set; }

        [Required]
        [DisplayName("Giới tính")]
        [Column("Sex")]
        public bool Sex { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Địa chỉ")]
        [Column("Address")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Email")]
        [Column("Email")]
        public string Email { get; set; }

        public Author()
        {
        }

        public Author(string id, string firstName, string lastName, DateTime birthday, bool sex, string address, string email)
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
