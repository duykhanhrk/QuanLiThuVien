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
            InitializeComponent();
        }

        public DetailForm(string readerId, int mode = 1)
        {
            this.mode = mode;

            // Get reader data
            try
            {
                reader = repository.FindById(readerId);
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
                    "addressTB", "phonenubmerTB", "saveBT");
            }
        }

        private void PrepareData()
        {
            // For mode 0
            if (mode == 0)
            {
                int maxNum = Int32.Parse(repository.FindMaxId().Substring(2));
                iDTB.Text = "RD" + (maxNum + 1).ToString().PadLeft(8, '0');
                return;
            }

            // For mode 1, 2

            // Infos
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
            // Librarian
            reader = new Reader(iDTB.Text, firstNameTB.Text, lastNameTB.Text,
                    ((KeyValuePair<string, bool>)sexDD.SelectedItem).Value,
                    addressTB.Text, birthdayDP.Value, emailTB.Text, phoneNumberTB.Text,
                    (Archive.Get("CurrentLibrarian") as Librarian).Id);

            // Execute
            try
            {
                if (mode == 0)
                    repository.Create(reader);
                else
                    repository.Update(reader);

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
