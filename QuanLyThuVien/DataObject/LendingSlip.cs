using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class LendingSlip
    {
        public long Id { get; set; }

        public string ReaderId { get; set; }

        public string CreatedByLibrarianId { get; set; }

        public DateTime CreatedAt { get; set; }

    }

}
