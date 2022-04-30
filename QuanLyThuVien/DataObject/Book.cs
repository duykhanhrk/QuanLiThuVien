using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class Book
    {
        public string Id { get; set; }

        public short Size { get; set; }

        public short Lending { get; set; }

        public string Notes { get; set; }

        public short Status { get; set; }

        public string BookTitleISBN { get; set; }

        public long CaseId { get; set; }

        public string LibrarianId { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
