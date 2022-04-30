using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class ProfileForm : Form
    {
        private DataObject.Librarian librarian;

        public ProfileForm(DataObject.Librarian librarian)
        {
            this.librarian = librarian;
            InitializeComponent();
        }

        private void ProfileForm_Shown(object sender, EventArgs e)
        {
            Dictionary<string, bool> sexes = new Dictionary<string, bool>();
            sexes.Add("Nam", true);
            sexes.Add("Nữ", false);
            sexDD.DataSource = new BindingSource(sexes, null);
            sexDD.DisplayMember = "Key";
            sexDD.ValueMember = "Value";
            sexDD.DropDownStyle = ComboBoxStyle.DropDownList;

            iDTB.Text = librarian.Id;
            lastNameTB.Text = librarian.LastName;
            firstNameTB.Text = librarian.FirstName;
            sexDD.SelectedIndex = librarian.Sex ? 0 : 1;
            birthdayDP.Value = librarian.Birthday;
            emailTB.Text = librarian.Email;
            addressTB.Text = librarian.Address;
            usernameTB.Text = librarian.Id;
        }
    }
}
