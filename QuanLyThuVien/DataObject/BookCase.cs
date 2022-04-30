﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataObject
{
    public class BookCase
    {
        [Column("Id")]
        public int Id { get; set; }

        [DisplayName("Thông tin")]
        [Column("Description")]
        public string Description { get; set; }

        [DisplayName("Kích thước")]
        [Column("Size")]
        public int Size { get; set; }
    }
}
