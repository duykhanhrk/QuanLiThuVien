using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Lib
{
    public static class DataValidation
    {
        public static void Validate(Object obj)
        {
            var context = new ValidationContext(obj, null, null);
            var result = new List<ValidationResult>();
            bool IsValid = Validator.TryValidateObject(obj, context, result, true);

            if (!IsValid)
                throw new Exception(result.First().ErrorMessage);
        }
    }
}
