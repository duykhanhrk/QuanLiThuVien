using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class LiquidatingSlipRepository : RepositoryAction<LiquidatingSlip, long>
    {
        public override void Create(LiquidatingSlip obj, params KeyValuePair<string, object>[] pairs)
        {
            string bookIdsString = String.Join(",", obj.LiquidatingSlipDetails.Select(t => t.BookId));
            string pricesString = String.Join(",", obj.LiquidatingSlipDetails.Select(t => t.Price));

            base.Create(obj, "book_ids".PairWith(bookIdsString), "prices".PairWith(pricesString));
        }
    }
}
