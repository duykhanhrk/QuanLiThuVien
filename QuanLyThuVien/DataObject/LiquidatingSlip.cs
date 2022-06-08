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
    public class LiquidatingSlip
    {
        [DisplayName("Mã")]
        [Column("Id")]
        public long Id { get; set; }

        [DisplayName("Ngày tạo")]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DisplayName("Tạo bởi")]
        [Column("CreatedBy")]
        public string CreatedBy { get; set; }

        public List<LiquidatingSlipDetail> LiquidatingSlipDetails { get; set; }

        public LiquidatingSlip()
        {
            LiquidatingSlipDetails = new List<LiquidatingSlipDetail>();
        }
    }
}
