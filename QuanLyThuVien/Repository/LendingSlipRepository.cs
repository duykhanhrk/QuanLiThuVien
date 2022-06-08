using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace QuanLyThuVien.Repository
{
    public class LendingSlipRepository : RepositoryAction<LendingSlip, long>
    {
        public override void Create(LendingSlip obj, params KeyValuePair<string, object>[] pairs)
        {
            string bookIdsString = String.Join(",", obj.LendingSlipDetails.Select(t => t.BookId));

            base.Create(obj, "book_ids".PairWith(bookIdsString));
        }
    }
}
