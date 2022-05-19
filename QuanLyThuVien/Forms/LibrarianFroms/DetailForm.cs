using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
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
        // Control
        int mode = 0; // 0: Creation, 1: update, 2: show
        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Data
        private Librarian librarian;
        private Account account;

        // Repository
        private LibrarianRepository repository = new LibrarianRepository();
        private AccountRepository accountRepository = new AccountRepository();

        // Init
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(string librarianId, int mode = 1)
        {
            this.mode = mode;

            // Get librarian data
            try
            {
                librarian = repository.FindById(librarianId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            // Get account
            try
            {
                account = accountRepository.FindAccountByLibrarianId(librarianId);
            }
            catch
            {
                // pass
            }
            

            InitializeComponent();
        }

        // Actions
        private void PrepareInterface()
        {
            // Preparse suggests of sex
            LazyMagic.BuildSexCombox(sexDD);

            // Disable controls
            iDTB.Enabled = false;

            // Only mode 0
            if (mode == 0)
            {
                changePasswordCB.Visible = false;
                changePasswordLB.Visible = false;
                return;
            }

            // Only mode 1
            if (mode == 1)
            {
                changePasswordCB.Checked = false;
                return;
            }

            // Only mode 2
            if (mode == 2)
            {
                // Disable controls
                LazyMagic.SetPropertyOfControlsFromForm(this, "Enabled", false,
                    "lastNameTB", "firstNameTB", "sexDD", "birthdayDP", "emailTB",
                    "addressTB", "saveBT", "usernameTB", "passwordTB", "passwordCfTB",
                    "enableCB", "changePasswordCB");
            }
        }

        private void PrepareData()
        {
            // For mode 0
            if (mode == 0)
            {
                int maxNum = Int32.Parse(repository.FindMaxId().Substring(2));
                iDTB.Text = "LB" + (maxNum + 1).ToString().PadLeft(8, '0');
                usernameTB.Text = "LB" + (maxNum + 1).ToString().PadLeft(8, '0');
                return;
            }

            // For mode 1, 2

            // Infos
            iDTB.Text = librarian.Id;
            lastNameTB.Text = librarian.LastName;
            firstNameTB.Text = librarian.FirstName;
            sexDD.SelectedIndex = librarian.Sex ? 0 : 1;
            birthdayDP.Value = librarian.Birthday;
            emailTB.Text = librarian.Email;
            addressTB.Text = librarian.Address;

            // Account
            if (account == null)
            {
                // Disable controls
                LazyMagic.SetPropertyOfControlsFromForm(this, "Enabled", false,
                    "usernameTB", "passwordTB", "passwordCfTB", "enableCB", "changePasswordCB");
                return;
            }

            usernameTB.Text = account.Username;
            enableCB.Checked = account.Enable;
        }

        private void SaveData()
        {
            // Librarian
            librarian = new Librarian(iDTB.Text, firstNameTB.Text, lastNameTB.Text,
                    birthdayDP.Value, ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value,
                    addressTB.Text, emailTB.Text);

            // Accout
            account = new Account(iDTB.Text, passwordTB.Text, enableCB.Checked);

            // Execute
            try
            {
                if (mode == 0)
                {
                    repository.CreateIncludeAccount(librarian, account);
                }
                else
                {
                    if (changePasswordCB.Checked)
                        repository.UpdateIncludeAccount(librarian, account);
                    else
                        repository.Update(librarian);
                }

                _successed = true;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Events
        private void DetailForm_Shown(object sender, EventArgs e)
        {
            PrepareInterface();
            PrepareData();
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changePasswordCB_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {
                usernameTB.Enabled = true;
                passwordTB.Enabled = true;
                passwordCfTB.Enabled = true;
                enableCB.Enabled = true;
            }
            else
            {
                usernameTB.Enabled = false;
                passwordTB.Enabled = false;
                passwordCfTB.Enabled = false;
                enableCB.Enabled = false;
            }
        }
    }
}
