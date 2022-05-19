using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Lib
{
    public static class ComboBoxExtensions
    {
        public static void QuickBuild(this ComboBox comboBox, Object obj, string displayMember, string valueMember)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.DataSource = new BindingSource(obj, null);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
