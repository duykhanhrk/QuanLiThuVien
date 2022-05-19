using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DataObject
{
    public class LendingSlip
    {
        [Required]
        [DisplayName("Id")]
        [Column("Id")]
        public long Id { get; set; }

        [Required]
        [DisplayName("Độc giả")]
        [Column("ReaderId")]
        public string ReaderId { get; set; }

        [Required]
        [DisplayName("Thủ thư")]
        [Column("CreatedByLibrarianId")]
        public string CreatedByLibrarianId { get; set; }

        [DisplayName("Ngày tạo")]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        public List<LendingSlipDetail> LendingSlipDetails { get; set; }

        public LendingSlip()
        {
            LendingSlipDetails = new List<LendingSlipDetail>();
        }

        public LendingSlip(string readerId, string createdByLibrarianId)
        {
            Id = 0;
            ReaderId = readerId;
            CreatedByLibrarianId = createdByLibrarianId;
            LendingSlipDetails = new List<LendingSlipDetail>();
        }
    }

}
