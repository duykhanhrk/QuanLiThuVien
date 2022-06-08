using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Repository
{
    public class CaseRepository : RepositoryAction<Case, long>
    {
        public List<Case> GetAllOfBookCase(string bookCaseId)
        {
            string commandText = "SELECT * FROM Caze WHERE BookCaseId = @book_case_id";
            SqlParameter parameterSearch = new SqlParameter("@book_case_id", bookCaseId);

            return Get(commandText, parameterSearch);
        }
    }
}
