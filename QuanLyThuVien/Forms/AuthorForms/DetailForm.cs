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
            InitializeComponent();
        }

        public DetailForm(string authorId, int mode = 1)
        {
            this.mode = mode;

            // Get author data
            try
            {
                author = repository.FindById(authorId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            // Preparse suggests of sex
            LazyMagic.BuildSexCombox(sexDD);

            // Disable controls
            iDTB.Enabled = false;

            // Only mode 2
            if (mode == 2)
            {
                // Disable controls
                LazyMagic.SetPropertyOfControlsFromForm(this, "Enabled", false,
                    "lastNameTB", "firstNameTB", "sexDD", "birthdayDP", "emailTB",
                    "addressTB", "saveBT");
            }
        }

        private void PrepareData()
        {
            // For mode 0
            if (mode == 0)
            {
                int maxNum = Int32.Parse(repository.FindMaxId().Substring(2));
                iDTB.Text = "AT" + (maxNum + 1).ToString().PadLeft(8, '0');
                return;
            }

            // For mode 1, 2

            // Infos
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
            // Librarian
            author = new Author(iDTB.Text, firstNameTB.Text, lastNameTB.Text,
                    birthdayDP.Value, ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value,
                    addressTB.Text, emailTB.Text);

            // Execute
            try
            {
                if (mode == 0)
                    repository.Create(author);
                else
                    repository.Update(author);

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
    }
}
