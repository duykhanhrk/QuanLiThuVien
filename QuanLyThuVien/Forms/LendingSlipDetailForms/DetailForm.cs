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

namespace QuanLyThuVien.Forms.LendingSlipDetailForms
{
    public partial class DetailForm : Form
    {
        // Control
        private int mode; // 0 : creation , 1: update
        private bool onlyAction;

        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Self Object
        private LendingSlipDetail _selfObject;
        public LendingSlipDetail SelfObject
        {
            get { return _selfObject; }
        }

        // Repository
        private LendingSlipDetailRepository repository = new LendingSlipDetailRepository();
        private BookRepository bookRepository = new BookRepository();

        public DetailForm(bool onlyAction = false)
        {
            this.onlyAction = onlyAction;
            mode = 0;
            _selfObject = new LendingSlipDetail();
            InitializeComponent();
        }

        public DetailForm(LendingSlipDetail lendingSlipDetail, int mode = 1, bool onlyAction = false)
        {
            this.onlyAction = onlyAction;
            this.mode = mode;
            _selfObject = lendingSlipDetail;
            InitializeComponent();
        }

        private void PrepareInterface()
        {
            if (!onlyAction)
            {
                tookBackBT.Enabled = false;
                extendedTB.Enabled = false;

                return;
            }

            bookDD.Enabled = false;
            notesTB.Enabled = false;
            dueBackDP.Enabled = false;
            saveBT.Enabled = false;

            if (_selfObject.TookBack)
            {
                tookBackBT.Enabled = false;
                extendedTB.Enabled = false;
                return;
            }


            if (_selfObject.Extended)
                extendedTB.Enabled = false;

        }

        private void PrepareData()
        {
            var books = new List<Book>();

            try
            {
                // Book cases
                books = bookRepository.GetAllBy("Lending", false);
                bookDD.QuickBuild(books, "Id", "Id");
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
                // Book
                bookDD.SelectedItem = books.Find(t => t.Id == _selfObject.BookId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            dueBackDP.Value = _selfObject.DueBackDate;
        }

        private void SaveData()
        {
            _selfObject.BookId = (bookDD.SelectedItem as Book).Id;
            _selfObject.DueBackDate = dueBackDP.Value;

            _successed = true;
        }

        private void DetailForm_Shown(object sender, EventArgs e)
        {
            PrepareInterface();
            PrepareData();
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void extendedTB_Click(object sender, EventArgs e)
        {
            try
            {
                _selfObject.ExtendedBy = (Archive.Get("CurrentLibrarian") as Librarian).Id;
                repository.Extend(SelfObject);

                extendedTB.Enabled = false;
                _selfObject.Extended = true;
                _successed = true;
                dueBackDP.Value = _selfObject.DueBackDate.AddDays(7);
                MessageBox.Show("Gia hạn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tookBackBT_Click(object sender, EventArgs e)
        {
            try
            {
                _selfObject.TookBackBy = (Archive.Get("CurrentLibrarian") as Librarian).Id;
                repository.TookBack(SelfObject);

                tookBackBT.Enabled = false;
                _selfObject.TookBack = true;
                _successed = true;
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
