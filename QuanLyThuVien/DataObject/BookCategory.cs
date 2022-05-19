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
    public class BookCategory
    {
        [Column("Id")]
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        [DisplayName("Tên")]
        [Column("Name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
