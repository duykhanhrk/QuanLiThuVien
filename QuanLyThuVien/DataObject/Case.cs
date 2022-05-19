using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    [Table("Caze")]
    public class Case
    {
        [DisplayName("Id")]
        [Column("Id")]
        public long Id { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [DisplayName("Number")]
        [Column("Number")]
        public long Number { get; set; }

        [Required]
        [DisplayName("BookCaseId")]
        [Column("BookCaseId")]
        public string BookCaseId { get; set; }

    }
}
