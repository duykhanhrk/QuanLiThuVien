using System;
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
        [Range(1, float.MaxValue)]
        [DisplayName("Giá")]
        [Column("Price")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Ngày phát hành")]
        [Column("ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayName("Mã nhà phát hành")]
        [Column("PublisherId")]
        public string PublisherId { get; set; }

        // ..

        public BookTitle()
        {
        }

        public BookTitle(string iSBN, string name, int pages, decimal price, DateTime releaseDate, string publisherId)
        {
            ISBN = iSBN;
            Name = name;
            Pages = pages;
            Price = price;
            ReleaseDate = releaseDate;
            PublisherId = publisherId;
        }
    }
}
