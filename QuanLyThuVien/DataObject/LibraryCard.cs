using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class LibraryCard
    {
     
        [Required]
        [Column("Id")]
        public long Id { get; set; }

        [Required]
        [Column("EffectiveDate")]
        public DateTime EffectiveDate { get; set; }

        [Required]
        [Column("EffectiveEndDate")]
        public DateTime EffectiveEndDate { get; set; }

        [Required]
        [Column("Fee")]
        public decimal Fee { get; set; }

        [Required]
        [Column("ReaderId")]
        public string ReaderId { get; set; }

        [Required]
        [Column("CreatedBy")]
        public string CreatedBy { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}
