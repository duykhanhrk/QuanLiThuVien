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
        int mode = 0; // 0 : creation , 1: update

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
        private BookRepository bookRepository = new BookRepository();

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(LendingSlipDetail lendingSlipDetail, int mode = 1)
        {
            this.mode = mode;
            _selfObject = lendingSlipDetail;
            InitializeComponent();
        }

        private void PrepareInterface()
        {
            // pass
        }

        private void PrepareData()
        {
            var books = new List<Book>();

            try
            {
                // Book cases
                books = bookRepository.GetAll();
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
            notesTB.Text = _selfObject.Notes;
        }

        private void SaveData()
        {
            _selfObject = new LendingSlipDetail((bookDD.SelectedItem as Book).Id, 0, dueBackDP.Value, notesTB.Text);
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
    }
}
