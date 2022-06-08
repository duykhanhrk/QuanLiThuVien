using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.AuthorForms
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

        private Author author;
        private AuthorRepository repository = new AuthorRepository();

        public DetailForm()
        {
            author = new Author();
            InitializeComponent();
        }

        public DetailForm(Author author, int mode = 1)
        {
            this.mode = mode;
            this.author = author;

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            iDTB.Enabled = false;
        }

        private void PrepareData()
        {
            // Preparse suggests of gender
            sexDD.OfGender();

            // For mode 0
            if (mode == 0)
            {
                iDTB.Text = repository.FindNextId("AT");
                return;
            }

            iDTB.Text = author.Id;
            lastNameTB.Text = author.LastName;
            firstNameTB.Text = author.FirstName;
            sexDD.SelectedIndex = author.Sex ? 0 : 1;
            birthdayDP.Value = author.Birthday;
            emailTB.Text = author.Email;
            addressTB.Text = author.Address;
        }

        private void SaveData()
        {
            author.FirstName = firstNameTB.Text;
            author.LastName = lastNameTB.Text;
            author.Birthday = birthdayDP.Value;
            author.Sex = ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value;
            author.Address = addressTB.Text;
            author.Email = emailTB.Text;

            try
            {
                if (mode == 0)
                {
                    author.Id = iDTB.Text;
                    repository.Create(author);
                }
                else
                {
                    repository.Update(author);
                }

                _successed = true;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DetailForm_Shown(object sender, EventArgs e)
        {
            PrepareInterface();
            PrepareData();
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
