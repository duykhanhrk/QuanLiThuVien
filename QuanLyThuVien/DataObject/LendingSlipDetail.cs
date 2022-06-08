using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class LendingSlipDetail
    {
        [Required]
        [DisplayName("Mã sách")]
        [Column("BookId")]
        public string BookId { get; set; }

        [Required]
        [DisplayName("Mã phiếu mượn")]
        [Browsable(false)]
        [Column("LendingSlipId")]
        public long LendingSlipId { get; set; }

        [Required]
        [DisplayName("Thời gian hoàn trả")]
        [Column("DueBackDate")]
        public DateTime DueBackDate { get; set; }

        [Browsable(false)]
        [DisplayName("Tình trạng sách")]
        [Column("BookStatus")]
        public short BookStatus { get; set; }

        [Browsable(false)]
        [Column("TookBack")]
        public bool TookBack { get; set; }

        [DisplayName("Đã trả")]
        public string TookBackDisplay
        {
            get { return TookBack ? "Có" : "Không"; }
        }

        [Browsable(false)]
        [DisplayName("Thời gian nhận lại")]
        [Column("TookBackAt")]
        public DateTime TookBackAt { get; set; }

        [Browsable(false)]
        [DisplayName("Nhận lại bởi")]
        [Column("TookBackBy")]
        public string TookBackBy { get; set; }

        [Browsable(false)]
        [DisplayName("Gia hạn")]
        [Column("Extended")]
        public bool Extended { get; set; }

        [Browsable(false)]
        [DisplayName("Gia hạn bởi")]
        [Column("ExtendedBy")]
        public string ExtendedBy { get; set; }

        [DisplayName("Gia hạn vào lúc")]
        [Browsable(false)]
        [Column("ExtendedAt")]
        public string ExtendedAt { get; set; }

        public LendingSlipDetail()
        {
        }
    }
}
