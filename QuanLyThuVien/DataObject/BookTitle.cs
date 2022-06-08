using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    [Table("BookTitle")]
    public class BookTitle
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(13)]
        [DisplayName("ISBN")]
        [Column("ISBN")]
        public string ISBN { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Tên")]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [DisplayName("Số trang")]
        [Column("Pages")]
        public int Pages { get; set; }

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

        [Required]
        [DisplayName("Ngày phát hành")]
        [Column("ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayName("Mã nhà phát hành")]
        [Column("PublisherId")]
        public string PublisherId { get; set; }

        [Browsable(false)]
        public List<BookCategory> Categories { get; set; }

        [Browsable(false)]
        public List<Author> Authors { get; set; }

        public BookTitle()
        {
            Categories = new List<BookCategory>();
            Authors = new List<Author>();
        }
    }
}
