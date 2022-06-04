using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class LiquidatingSlipDetail
    {
        [Column("BookId")]
        [DisplayName("Mã sách")]
        public string BookId { get; set; }

        [Column("LiquidatingSlipId")]
        [DisplayName("Mã phiếu thanh lí")]
        public long LiquidatingSlipId { get; set; }

        [Column("Price")]
        [DisplayName("Giá")]
        public decimal Price { get; set; }

        [Column("Notes")]
        [DisplayName("Ghi chú")]
        public string Notes { get; set; }

    }
}
