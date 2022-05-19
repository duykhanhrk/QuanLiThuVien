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

namespace QuanLyThuVien.Forms.LibraryCardForms
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
        private LibraryCardRepository repository = new LibraryCardRepository();
        private ReaderRepository readereRepository = new ReaderRepository();

        // Objects
        private LibraryCard _selfObject;
        public LibraryCard SelfObject
        {
            get { return _selfObject; }
        }

        public DetailForm()
        {
            _selfObject = new LibraryCard();
            InitializeComponent();
        }

        public DetailForm(LibraryCard obj, int mode = 1)
        {
            this.mode = mode;
            _selfObject = obj;

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            iDTB.Enabled = false;

            if (mode == 0)
                return;

            readerDD.Enabled = false;
            feeTB.Enabled = false;
        }

        private void PrepareData()
        {
            var readers = new List<Reader>();
            try
            {
                // Readers
                readers = readereRepository.GetAll();
                readerDD.QuickBuild(readers, "Id", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            if (mode == 0)
            {
                try
                {
                    iDTB.Text = repository.FindNextId().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
                return;
            }

            try
            {
                // Readers
                readerDD.SelectedItem = readers.Find(t => t.Id == _selfObject.ReaderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            iDTB.Text = _selfObject.Id.ToString();
            effectiveDateDP.Value = _selfObject.EffectiveDate;
            effectiveEndDateDP.Value = _selfObject.EffectiveEndDate;
            notesTB.Text = "";
        }

        private void SaveData()
        {
            // Execute
            try
            {
                _selfObject.EffectiveDate = effectiveDateDP.Value;
                _selfObject.EffectiveEndDate = effectiveEndDateDP.Value;

                if (mode == 0)
                {
                    _selfObject.Fee = Decimal.Parse(feeTB.Text);
                    _selfObject.ReaderId = (readerDD.SelectedItem as Reader).Id;
                    _selfObject.CreatedBy = (Archive.Get("CurrentLibrarian") as Librarian).Id;
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
    }
}
