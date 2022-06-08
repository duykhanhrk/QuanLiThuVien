using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyThuVien.Repository
{
    public class BookTitleRepository : RepositoryAction<BookTitle, string>
    {
        public override void Create(BookTitle obj, params KeyValuePair<string, object>[] pairs)
        {
            var bookCategoryIds = String.Join(",", obj.Categories.Select(t => t.Id));
            var bookAuthorIds = String.Join(",", obj.Authors.Select(t => t.Id));

            base.Create(obj, "categories".PairWith(bookCategoryIds), "authors".PairWith(bookAuthorIds));
        }

        public override void Update(BookTitle obj, params KeyValuePair<string, object>[] pairs)
        {
            var bookCategoryIds = String.Join(",", obj.Categories.Select(t => t.Id));
            var bookAuthorIds = String.Join(",", obj.Authors.Select(t => t.Id));

            base.Update(obj, "categories".PairWith(bookCategoryIds), "authors".PairWith(bookAuthorIds));
        }

        public override void Delete(string iSBN)
        {
            // Command Text
            string commandText = "sp_delete_book_title";

            // Params
            SqlParameter parameterISBN = new SqlParameter("@isbn", iSBN);

            // Execute
            int rows = DbConnection.ExecuteNonQuery(commandText, CommandType.StoredProcedure, parameterISBN);

            // Exception
            if (rows == 0)
                throw new Exception("Xóa không thành công");
        }
    }
}
