using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.ReaderForms
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

        private Reader reader;
        private ReaderRepository repository = new ReaderRepository();

        public DetailForm()
        {
            reader = new Reader();
            InitializeComponent();
        }

        public DetailForm(Reader reader, int mode = 1)
        {
            this.mode = mode;
            this.reader = reader;

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            iDTB.Enabled = false;
        }

        private void PrepareData()
        {
            sexDD.OfGender();

            if (mode == 0)
            {
                iDTB.Text = repository.FindNextId("RD");
                return;
            }

            iDTB.Text = reader.Id;
            lastNameTB.Text = reader.LastName;
            firstNameTB.Text = reader.FirstName;
            sexDD.SelectedIndex = reader.Sex ? 0 : 1;
            birthdayDP.Value = reader.Birthday;
            emailTB.Text = reader.Email;
            addressTB.Text = reader.Address;
            phoneNumberTB.Text = reader.PhoneNumber;
        }

        private void SaveData()
        {
            reader.FirstName = firstNameTB.Text;
            reader.LastName = lastNameTB.Text;
            reader.Sex = ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value;
            reader.Address = addressTB.Text;
            reader.Birthday = birthdayDP.Value;
            reader.Email = emailTB.Text;
            reader.PhoneNumber = phoneNumberTB.Text;

            // Execute
            try
            {
                if (mode == 0)
                {
                    reader.Id = iDTB.Text;
                    reader.LibrarianId = (Archive.Get("CurrentLibrarian") as Librarian).Id;
                    repository.Create(reader);
                }
                else
                {
                    repository.Update(reader);
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
