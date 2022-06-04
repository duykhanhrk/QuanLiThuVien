using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class SRole
    {
        [Column("name")]
        public string Name { get; set; }

        public List<SGrant> SGants { get; set; }

        public SRole()
        {
            Name = "";
            SGants = new List<SGrant>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
