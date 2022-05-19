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
        [DisplayName("Kích thước")]
        [Column("Size")]
        public short Size { get; set; }

        [DisplayName("Đang cho mượn")]
        [Column("Lending")]
        public bool Lending { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        [DisplayName("Ghi chú")]
        [Column("Notes")]
        public string Notes { get; set; }

        [Required]
        [DisplayName("Trạng thái")]
        [Column("Status")]
        public short Status { get; set; }

        [Required]
        [DisplayName("ISBN")]
        [Column("BookTitleISBN")]
        public string BookTitleISBN { get; set; }

        [Required]
        [Column("CaseId")]
        public long CaseId { get; set; }

        [Required]
        [DisplayName("Thủ thư")]
        [Column("LibrarianId")]
        public string LibrarianId { get; set; }

        [DisplayName("Ngày tạo")]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        public Book()
        {
        }

        public Book(string id, short size, string notes, string bookTitleISBN, long caseId, string librarianId)
        {
            Id = id;
            Size = size;
            Notes = notes;
            BookTitleISBN = bookTitleISBN;
            CaseId = caseId;
            LibrarianId = librarianId;
            CreatedAt = DateTime.Now;
            Status = 1;
        }
    }
}
