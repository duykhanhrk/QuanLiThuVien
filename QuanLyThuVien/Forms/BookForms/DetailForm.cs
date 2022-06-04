using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms.BookForms
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
        private Book book;
        private BookRepository repository = new BookRepository();
        private BookTitleRepository bookTitleRepository = new BookTitleRepository();
        private BookCaseRepository bookCaseRepository = new BookCaseRepository();
        private CaseRepository caseRepository = new CaseRepository();

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(string bookId, int mode = 1)
        {
            this.mode = mode;

            // Get book title data
            try
            {
                book = repository.FindById(bookId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Load += (s, e) => Close();
                return;
            }

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            if (mode != 0)
                iDTB.Enabled = false;
        }

        private void PrepareData()
        {
            var bookTitles = new List<BookTitle>();
            var bookCases = new List<BookCase>();
            short[] sizes = new short[] { 1, 2, 3 };
            try
            {
                // Sizes
                sizeDD.DataSource = sizes;

                // Book titles
                bookTitles = bookTitleRepository.GetAll();
                LazyMagic.BuildComboBox(bookTitleDD, bookTitles, "ISBN", "ISBN");

                // Book cases
                bookCases = bookCaseRepository.GetAll();
                LazyMagic.BuildComboBox(bookCaseDD, bookCases, "Id", "Id");
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
                // Sizes
                sizeDD.SelectedItem = sizes.First(t => (int) t == book.Size);

                // Book titles
                bookTitleDD.SelectedItem = bookTitles.Find(t => t.ISBN == book.BookTitleISBN);

                // Book cases
                var caze = caseRepository.FindById(book.CaseId);
                bookCaseDD.SelectedItem = bookCases.Find(t => t.Id == caze.BookCaseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
            }

            iDTB.Text = book.Id;
            notesTB.Text = book.Notes;
        }

        private void SaveData()
        {
            // Execute
            try
            {
                book = new Book(iDTB.Text, (short)sizeDD.SelectedItem, notesTB.Text,
                    (bookTitleDD.SelectedItem as BookTitle).ISBN, (caseDD.SelectedItem as Case).Id,
                    (Archive.Get("CurrentLibrarian") as Librarian).Id);

                if (mode == 0)
                    repository.Create(book);
                else
                    repository.Update(book);

                _successed = true;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookCaseDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cases = new List<Case>();
            try
            {
                cases = caseRepository.GetAllOfBookCase(((BookCase)bookCaseDD.SelectedItem).Id);
                LazyMagic.BuildComboBox(caseDD, cases, "Number", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            if (mode == 0)
                return;

            try
            {
                var caze = cases.Find(t => t.Id == book.CaseId);
                if (caze != null)
                {
                    caseDD.SelectedItem = caze;
                }
            }
            catch
            {
                // pass
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
