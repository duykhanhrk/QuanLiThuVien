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
        [Column("LendingSlipId")]
        public long LendingSlipId { get; set; }

        [Required]
        [DisplayName("Thời gian hoàn trả")]
        [Column("DueBackDate")]
        public DateTime DueBackDate { get; set; }

        [DisplayName("Tình trạng sách")]
        [Column("BookStatus")]
        public short BookStatus { get; set; }

        [Required]
        [DisplayName("Ghi chú")]
        [Column("Notes")]
        public string Notes { get; set; }

        [DisplayName("Nhận lại")]
        [Column("TookBack")]
        public bool TookBack { get; set; }

        [DisplayName("Thời gian nhận lại")]
        [Column("TookBackAt")]
        public DateTime TookBackAt { get; set; }

        [DisplayName("Nhận lại bởi")]
        [Column("TookBackBy")]
        public string TookBackBy { get; set; }

        [DisplayName("Gia hạn")]
        [Column("Extended")]
        public bool Extended { get; set; }

        [DisplayName("Gia hạn bởi")]
        [Column("ExtendedBy")]
        public string ExtendedBy { get; set; }

        [DisplayName("Gia hạn vào lúc")]
        [Column("ExtendedAt")]
        public string ExtendedAt { get; set; }

        public LendingSlipDetail()
        {
        }

        public LendingSlipDetail(string bookId, long lendingSlipId, DateTime dueBackDate, string notes)
        {
            BookId = bookId;
            LendingSlipId = lendingSlipId;
            DueBackDate = dueBackDate;
            Notes = notes;
        }
    }
}
