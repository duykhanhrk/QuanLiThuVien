using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class LibraryCard
    {
        public long Id { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime EffectiveEndDate { get; set; }

        public decimal Fee { get; set; }

        public string ReaderId { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedAt { get; set; }

    }
}
