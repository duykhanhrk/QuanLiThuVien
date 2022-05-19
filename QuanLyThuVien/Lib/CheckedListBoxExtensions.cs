using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Lib
{
    public static class CheckedListBoxExtensions
    {
        public static void SetItemsCheckState<T>(this CheckedListBox checkedListBox, Object[] items, string comparisonPropertyName, CheckState checkState)
        {

            var property = typeof(T).GetProperty(comparisonPropertyName);
            foreach (var item in items)
            {
                for (var i = 0; i < checkedListBox.Items.Count; i++)
                {
                    if (property.GetValue(checkedListBox.Items[i]).Equals(property.GetValue(item)))
                    {
                        checkedListBox.SetItemCheckState(i, checkState);
                        break;
                    }
                }
            }
        }
    }
}
