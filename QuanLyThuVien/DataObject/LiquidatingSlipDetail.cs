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
    public class LiquidatingSlipDetail
    {
        [Required]
        [Column("BookId")]
        [DisplayName("Mã sách")]
        public string BookId { get; set; }

        [Required]
        [Column("LiquidatingSlipId")]
        [Browsable(false)]
        [DisplayName("Mã phiếu thanh lí")]
        public long LiquidatingSlipId { get; set; }

        [Required]
        [Browsable(false)]
        [Range(1, float.MaxValue)]
        [Column("Price")]
        public decimal Price { get; set; }

        [DisplayName("Giá")]
        public string PriceDisplay
        {
            get { return String.Format("{0:n0}", Price) + " VNĐ"; }
        }

        [Column("Notes")]
        [Browsable(false)]
        [DisplayName("Ghi chú")]
        public string Notes { get; set; }
    }
}
