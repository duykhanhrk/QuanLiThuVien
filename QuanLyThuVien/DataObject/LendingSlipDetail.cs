using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class LendingSlipDetail
    {
        public string BookId { get; set; }

        public long LendingSlipId { get; set; }

        public DateTime DueBackDate { get; set; }

        public short BookStatus { get; set; }

        public string Notes { get; set; }

        public bool TookBack { get; set; }

        public DateTime TookBackAt { get; set; }

        public string TookBackBy { get; set; }

        public bool Extended { get; set; }

        public string ExtendedBy { get; set; }

        public string ExtendedAt { get; set; }

    }
}
