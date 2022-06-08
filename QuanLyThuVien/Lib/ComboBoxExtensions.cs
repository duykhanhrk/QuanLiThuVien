using System;
using System.Collections.Generic;
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

        public static void OfGender(this ComboBox comboBox)
        {
            Dictionary<string, bool> sexes = new Dictionary<string, bool>();
            sexes.Add("Nam", true);
            sexes.Add("Nữ", false);

            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.DataSource = new BindingSource(sexes, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
