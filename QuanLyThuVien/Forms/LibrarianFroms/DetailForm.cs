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

        // Repository
        private LibrarianRepository repository = new LibrarianRepository();
        private AccountRepository accountRepository = new AccountRepository();

        // Init
        public DetailForm()
        {
            librarian = new Librarian();
            InitializeComponent();
        }

        public DetailForm(Librarian librarian, int mode = 1)
        {
            this.mode = mode;
            this.librarian = librarian;

            // Get account
            try
            {
                librarian.Account = accountRepository.FindBy("UserableId".PairWith(librarian.Id), "UserableType".PairWith("Librarian"));
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

            // Only mode 0, 1
            if (mode == 0 || mode == 1)
                return;

            // Only mode 2
            if (mode == 2)
            {
                lastNameTB.Enabled = false;
                firstNameTB.Enabled = false;
                sexDD.Enabled = false;
                birthdayDP.Enabled = false;
                emailTB.Enabled = false;
                addressTB.Enabled = false;
                saveBT.Enabled = false;
                usernameTB.Enabled = false;
                passwordTB.Enabled = false;
                enableCB.Enabled = false;
            }
        }

        private void PrepareData()
        {
            // For mode 0
            if (mode == 0)
            {
                string nextId = repository.FindNextId("LB");
                iDTB.Text = nextId;
                usernameTB.Text = nextId;

                return;
            }

            // Infos
            iDTB.Text = librarian.Id;
            lastNameTB.Text = librarian.LastName;
            firstNameTB.Text = librarian.FirstName;
            sexDD.SelectedIndex = librarian.Sex ? 0 : 1;
            birthdayDP.Value = librarian.Birthday;
            emailTB.Text = librarian.Email;
            addressTB.Text = librarian.Address;
            usernameTB.Text = librarian.Account.Username;
            enableCB.Checked = librarian.Account.Enable;
        }

        private void SaveData()
        {
            // Librarian
            librarian.LastName = lastNameTB.Text;
            librarian.FirstName = firstNameTB.Text;
            librarian.Birthday = birthdayDP.Value;
            librarian.Sex = (bool)sexDD.SelectedValue;
            librarian.Address = addressTB.Text;
            librarian.Email = emailTB.Text;

            // Account
            librarian.Account.Username = usernameTB.Text;
            librarian.Account.Password = passwordTB.Text;
            librarian.Account.Enable = enableCB.Checked;

            // Execute
            try
            {
                if (mode == 0)
                {
                    librarian.Id = iDTB.Text;
                    repository.Create(librarian);
                }
                else
                {
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
    }
}
