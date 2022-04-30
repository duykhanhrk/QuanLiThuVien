using QuanLyThuVien.DataObject;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.LibrarianFroms
{
    public partial class DetailForm : Form
    {
        // 0: creation
        // 1: update
        // 2: show
        int mode = 0;
        private Librarian librarian;
        private Account account;
        private LibrarianRepository librarianRepository = new LibrarianRepository();

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(Librarian librarian, int mode = 1)
        {
            this.mode = mode;
            this.librarian = librarian;

            InitializeComponent();
        }

        private void DetailForm_Shown(object sender, EventArgs e)
        {
            submitBT.Text = mode == 0 ? "Tạo" : "Cập nhật";
            submitBT.Enabled = mode == 2 ? false : true;

            Dictionary<string, bool> sexes = new Dictionary<string, bool>();
            sexes.Add("Nam", true);
            sexes.Add("Nữ", false);
            sexDD.DataSource = new BindingSource(sexes, null);
            sexDD.DisplayMember = "Key";
            sexDD.ValueMember = "Value";
            sexDD.DropDownStyle = ComboBoxStyle.DropDownList;

            if (mode == 0)
            {
                // Get maxId
                string maxId;
                maxId = librarianRepository.GetMaxId();

                // Get maxNum
                int maxNum = Int32.Parse(maxId.Substring(2));

                iDTB.Text = "LB" + (maxNum + 1).ToString().PadLeft(8, '0');
                usernameTB.Text = "LB" + (maxNum + 1).ToString().PadLeft(8, '0');

                return;
            }

            iDTB.Text = librarian.Id;
            lastNameTB.Text = librarian.LastName;
            firstNameTB.Text = librarian.FirstName;
            sexDD.SelectedIndex = librarian.Sex ? 0 : 1;
            birthdayDP.Value = librarian.Birthday;
            emailTB.Text = librarian.Email;
            addressTB.Text = librarian.Address;
            usernameTB.Text = librarian.Id;
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                // Librarian
                librarian = new Librarian(iDTB.Text, firstNameTB.Text, lastNameTB.Text,
                        birthdayDP.Value, ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value,
                        addressTB.Text, emailTB.Text);

                // Accout
                account = new Account(iDTB.Text, passwordTB.Text, true);


                try
                {
                    librarianRepository.Create(librarian, account);
                    MessageBox.Show("Tạo thủ thư thành công!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
