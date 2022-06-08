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
    public class LibraryCard
    {
        [Required]
        [Column("Id")]
        [DisplayName("Số thẻ")]
        public long Id { get; set; }

        [Required]
        [DisplayName("Ngày bắt đầu")]
        [Column("EffectiveDate")]
        public DateTime EffectiveDate { get; set; }

        [Required]
        [DisplayName("Ngày kết thúc")]
        [Column("EffectiveEndDate")]
        public DateTime EffectiveEndDate { get; set; }

        [Required]
        [Browsable(false)]
        [Column("Fee")]
        public decimal Fee { get; set; }

        [DisplayName("Phí đã thu")]
        public string FeeDisplay
        {
            get { return String.Format("{0:n0}", Fee) + " VNĐ"; ; }
        }

        [Required]
        [DisplayName("Mã đọc giả")]
        [Column("ReaderId")]
        public string ReaderId { get; set; }

        [Required]
        [DisplayName("Mã thủ thư")]
        [Browsable(false)]
        [Column("CreatedBy")]
        public string CreatedBy { get; set; }

        [Column("CreatedAt")]
        [Browsable(false)]
        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }
    }
}
