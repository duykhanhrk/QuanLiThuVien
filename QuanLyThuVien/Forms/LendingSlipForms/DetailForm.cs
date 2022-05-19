using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.LendingSlipForms
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

        // Repository
        private LendingSlipRepository repository = new LendingSlipRepository();
        private LendingSlipDetailRepository lendingSlipDetailRepository = new LendingSlipDetailRepository();
        private ReaderRepository readerRepository = new ReaderRepository();

        // Object
        private LendingSlip _selfObject;
        public LendingSlip SelfObject
        {
            get { return _selfObject; }
        }

        public DetailForm()
        {
            mode = 0;
            _selfObject = new LendingSlip();
            InitializeComponent();
        }

        public DetailForm(LendingSlip lendingSlip, int mode = 1)
        {
            this.mode = mode;
            _selfObject = lendingSlip;

            // Load LendingSlipDetails
            try
            {
                _selfObject.LendingSlipDetails = lendingSlipDetailRepository.GetAllOfLendingSlip(lendingSlip.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            iDTB.Enabled = false;
            LibrarianIDTB.Enabled = false;
            createdAtDP.Enabled = false;

            iDTB.Text = repository.FindNextId().ToString();
            LibrarianIDTB.Text = (Archive.Get("CurrentLibrarian") as Librarian).Id;
        }

        private void PrepareData()
        {
            var readers = new List<Reader>();

            try
            {
                // Book titles
                readers = readerRepository.GetAll();
                LazyMagic.BuildComboBox(readerDD, readers, "Id", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            if (mode == 0)
                return;

            try
            {
                // Book titles
                readerDD.SelectedItem = readers.Find(t => t.Id == _selfObject.ReaderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            iDTB.Text = _selfObject.Id.ToString();
            createdAtDP.Value = _selfObject.CreatedAt;
            LibrarianIDTB.Text = _selfObject.CreatedByLibrarianId;
        }

        private void SaveData()
        {
            // Execute
            try
            {
                _selfObject.ReaderId = (readerDD.SelectedItem as Reader).Id;

                if (mode == 0)
                {
                    _selfObject.CreatedByLibrarianId = (Archive.Get("CurrentLibrarian") as Librarian).Id;
                    repository.Create(_selfObject);
                }
                else
                {
                    repository.Update(_selfObject);
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

        private void detailsBT_Click(object sender, EventArgs e)
        {
            LendingSlipDetailForm lendingSlipDetailForm = new LendingSlipDetailForm(_selfObject.LendingSlipDetails);
            lendingSlipDetailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            lendingSlipDetailForm.ShowDialog();
        }
    }
}
