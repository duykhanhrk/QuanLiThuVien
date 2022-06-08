using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class Publisher
    {
        [Required(AllowEmptyStrings = false)]
        [Column("Id")]
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column("Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column("Address")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không đúng định dạng")]
        [Column("Email")]
        public string Email { get; set; }

        [Browsable(false)]
        public string IdNameDisplay
        {
            get { return Id + " - " + Name; }
        }
    }
}
