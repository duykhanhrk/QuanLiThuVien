using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Lib
{
    public static class LazyMagic
    {
        public static SqlParameter[] BuildParams(Object obj, params KeyValuePair<string, object>[] pairs)
        {
            Type type = obj.GetType();

            var properties = type.GetProperties();

            ColumnAttribute columnAttribute;
            RequiredAttribute requiredAttribute;
            SqlParameter parameter;
            List<SqlParameter> parameters = new List<SqlParameter>();
            foreach (var property in properties)
            {
                requiredAttribute = (RequiredAttribute)property.GetCustomAttribute(typeof(RequiredAttribute), true);
                if (requiredAttribute == null)
                    continue;

                columnAttribute = (ColumnAttribute)property.GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault();
                if (columnAttribute == null)
                    continue;

                parameter = new SqlParameter($"@{columnAttribute.Name.ToUnderscore()}", property.GetValue(obj));
                parameters.Add(parameter);
            }

            // Pairs
            foreach (var p in pairs)
            {
                parameter = new SqlParameter($"@{p.Key}", p.Value);
                parameters.Add(parameter);
            }

            return parameters.ToArray();
        }

        /// <summary>
        /// Build sex combobox
        /// </summary>
        /// <param name="comboBox"></param>
        public static void BuildSexCombox(ComboBox comboBox)
        {
            Dictionary<string, bool> sexes = new Dictionary<string, bool>();
            sexes.Add("Nam", true);
            sexes.Add("Nữ", false);
            comboBox.Items.Clear();
            comboBox.DataSource = new BindingSource(sexes, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void BuildComboBox(ComboBox comboBox, Object obj, string displayMember, string valueMember)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.DataSource = new BindingSource(obj, null);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Set property of Controls form Form
        /// </summary>
        /// <param name="form"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <param name="controlNames"></param>
        public static void SetPropertyOfControlsFromForm(Form form, string propertyName, bool value, params String[] controlNames)
        {
            var property = typeof(Control).GetProperty(propertyName);
            foreach (String controlName in controlNames)
            {
                Control control = form.Controls.Find(controlName, true)[0];
                property.SetValue(control, value);
            }
        }
    }
}
