using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Lib
{
    public static class Archive
    {
        private static Dictionary<string, Object> _archives = new Dictionary<string, Object>();

        public static Object Get(string key)
        {
            return _archives[key];
        }

        public static void Save(string key, Object obj)
        {
            _archives[key] = obj;
        }

        public static void Add(string key, Object obj)
        {
            _archives.Add(key, obj);
        }

        public static void Remove(string key)
        {
            _archives.Remove(key);
        }
    }
}
