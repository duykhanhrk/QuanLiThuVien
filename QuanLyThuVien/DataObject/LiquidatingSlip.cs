using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class LiquidatingSlip
    {
        public long Id { get; set; }

        public DateTime LiquidatedAt { get; set; }

        public string LiquidatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

    }
}
