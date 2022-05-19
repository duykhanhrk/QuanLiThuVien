using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyThuVien.Lib
{
    public static class StringExtensions
    {
        public static string ToUnderscore(this string str)
        {
            return Regex.Replace(str, "[a-z][A-Z]", m => m.Value[0] + "_" + m.Value[1]).ToLower();
        }

        public static KeyValuePair<string, object> PairWith(this string str, object value)
        {
            return new KeyValuePair<string, object>(str, value);
        }
    }
}
