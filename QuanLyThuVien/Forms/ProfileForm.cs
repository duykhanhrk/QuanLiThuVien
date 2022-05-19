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
        private Account account;

        // Repository
        LibrarianRepository repository = new LibrarianRepository();
        AccountRepository accountRepository = new AccountRepository();

        public ProfileForm(string id)
        {
            try
            {
                librarian = repository.FindById(id);
                account = accountRepository.FindAccountByLibrarianId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            InitializeComponent();
        }

        public ProfileForm(Librarian librarian)
        {
            this.librarian = librarian;

            try
            {
                account = accountRepository.FindAccountByLibrarianId(librarian.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            InitializeComponent();
        }

        private void ProfileForm_Shown(object sender, EventArgs e)
        {
            LazyMagic.BuildSexCombox(sexDD);

            iDTB.Text = librarian.Id;
            lastNameTB.Text = librarian.LastName;
            firstNameTB.Text = librarian.FirstName;
            sexDD.SelectedIndex = librarian.Sex ? 0 : 1;
            birthdayDP.Value = librarian.Birthday;
            emailTB.Text = librarian.Email;
            addressTB.Text = librarian.Address;
            usernameTB.Text = account.Username;
        }

        private void updateInfoBT_Click(object sender, EventArgs e)
        {
            // Librarian
            librarian = new Librarian(iDTB.Text, firstNameTB.Text, lastNameTB.Text,
                    birthdayDP.Value, ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value,
                    addressTB.Text, emailTB.Text);

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
            // Accout
            account = new Account(usernameTB.Text, passwordTB.Text);

            try
            {
                accountRepository.UpdatetByLibrarianId(librarian.Id, account);
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
            {
                updatePwBT.Enabled = false;
            }
            else
            {
                updatePwBT.Enabled = true;
            }
        }
    }
}
