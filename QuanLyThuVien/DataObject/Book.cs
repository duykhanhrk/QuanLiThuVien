using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class Book
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(10)]
        [DisplayName("Id")]
        [Column("Id")]
        public string Id { get; set; }

        [Required]
        [Browsable(false)]
        [Column("Size")]
        public short Size { get; set; }

        [DisplayName("Kích thước")]
        public string SizeDisplay
        {
            get {
                if (Size == 1)
                    return "Nhỏ";
                else if (Size == 2)
                    return "Vừa";
                else
                    return "Lớn";
            }
        }

        [Browsable(false)]
        [Column("Lending")]
        public bool Lending { get; set; }

        [DisplayName("Đang cho mượn")]
        public string LendingDisplay
        {
            get { return Lending ? "Có" : "Không"; }
        }
        
        [Required(AllowEmptyStrings = true)]
        [DisplayName("Ghi chú")]
        [Column("Notes")]
        public string Notes { get; set; }

        [Required]
        [Browsable(false)]
        [DisplayName("Trạng thái")]
        [Column("Status")]
        public short Status { get; set; }

        [Required]
        [DisplayName("ISBN")]
        [Column("BookTitleISBN")]
        public string BookTitleISBN { get; set; }

        [Required]
        [Browsable(false)]
        [Column("CaseId")]
        public long CaseId { get; set; }

        [Required]
        [DisplayName("Thủ thư")]
        [Browsable(false)]
        [Column("LibrarianId")]
        public string LibrarianId { get; set; }

        [DisplayName("Ngày tạo")]
        [Browsable(false)]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        public Book()
        {
        }
    }
}
