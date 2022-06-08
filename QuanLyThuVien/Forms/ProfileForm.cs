using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class ProfileForm : Form
    {
        private Librarian librarian;

        // Repository
        LibrarianRepository repository = new LibrarianRepository();
        AccountRepository accountRepository = new AccountRepository();

        public ProfileForm(Librarian librarian)
        {
            this.librarian = librarian;

            // Account
            try
            {
                this.librarian.Account = accountRepository.FindBy("UserableId".PairWith(librarian.Id), "UserableType".PairWith("Librarian"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            InitializeComponent();
        }

        private void ProfileForm_Shown(object sender, EventArgs e)
        {
            sexDD.OfGender();

            iDTB.Text = librarian.Id;
            lastNameTB.Text = librarian.LastName;
            firstNameTB.Text = librarian.FirstName;
            sexDD.SelectedIndex = librarian.Sex ? 0 : 1;
            birthdayDP.Value = librarian.Birthday;
            emailTB.Text = librarian.Email;
            addressTB.Text = librarian.Address;
            usernameTB.Text = librarian.Account.Username;
        }

        private void updateInfoBT_Click(object sender, EventArgs e)
        {
            librarian.FirstName = firstNameTB.Text;
            librarian.LastName = lastNameTB.Text;
            librarian.Birthday = birthdayDP.Value;
            librarian.Sex = ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value;
            librarian.Address = addressTB.Text;
            librarian.Email = emailTB.Text;

            try
            {
                repository.Update(librarian);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatePwTB_Click(object sender, EventArgs e)
        {
            librarian.Account.Username = usernameTB.Text;
            librarian.Account.Password = passwordTB.Text;

            try
            {
                accountRepository.UpdatetByLibrarianId(librarian.Id, librarian.Account);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void passwordTB_TextChange(object sender, EventArgs e)
        {
            if (passwordTB.Text == "" || passwordTB.Text != passwordCfTB.Text)
                updatePwBT.Enabled = false;
            else
                updatePwBT.Enabled = true;
        }
    }
}
