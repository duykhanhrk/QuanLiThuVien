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

namespace QuanLyThuVien.Forms.BookTitleForms
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

        // Object
        private BookTitle bookTitle;

        // Repository
        private BookTitleRepository repository = new BookTitleRepository();
        private PublisherRepository publisherRepository = new PublisherRepository();
        private BookCategoryRepository bookCategoryRepository = new BookCategoryRepository();
        private AuthorRepository authorRepository = new AuthorRepository();

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(string readerId, int mode = 1)
        {
            this.mode = mode;

            // Get book title data
            try
            {
                bookTitle = repository.findByISBN(readerId);
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
            if (mode != 0)
                iSBNTB.Enabled = false;
        }

        private void PrepareData()
        {
            List<Publisher> publishers = new List<Publisher>();
            List<BookCategory> categories = new List<BookCategory>();
            List<Author> authors = new List<Author>();
            try
            {
                // Publisher
                publishers = publisherRepository.GetAll();
                LazyMagic.BuildComboBox(publisherDD, publishers, "Id", "Id");

                // Categories
                categories = bookCategoryRepository.GetAll();
                bookCategoryCLB.Items.AddRange(categories.ToArray());

                // Author
                authors = authorRepository.GetAll();
                authorCLB.Items.AddRange(authors.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            if (mode == 0)
                return;

            try
            {
                // Publisher
                publisherDD.SelectedItem = publishers.Find(t => t.Id == bookTitle.PublisherId);

                // Category
                var bookCategories = bookCategoryRepository.GetAllOfBookTitle(bookTitle);
                bookCategoryCLB.SetItemsCheckState<BookCategory>(bookCategories.ToArray(), "Id", CheckState.Checked);

                // Author
                var bookAuthors = authorRepository.GetAllOfBookTitle(bookTitle);
                authorCLB.SetItemsCheckState<Author>(bookAuthors.ToArray(), "Id", CheckState.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            iSBNTB.Text = bookTitle.ISBN;
            nameTB.Text = bookTitle.Name;
            pagesTB.Text = bookTitle.Pages.ToString();
            priceTB.Text = bookTitle.Price.ToString();
            releaseDateDP.Value = bookTitle.ReleaseDate;
        }

        private void SaveData()
        {
            // Execute
            try
            {
                bookTitle = new BookTitle(iSBNTB.Text, nameTB.Text, Int32.Parse(pagesTB.Text), Decimal.Parse(priceTB.Text),
                    releaseDateDP.Value, (publisherDD.SelectedItem as Publisher).Id);

                var bookCategoryIds = String.Join(",", bookCategoryCLB.CheckedItems.OfType<BookCategory>().Select(t => t.Id));
                var bookAuthorIds = String.Join(",", authorCLB.CheckedItems.OfType<Author>().Select(t => t.Id));

                if (mode == 0)
                    repository.Create(bookTitle,
                        "categories".PairWith(bookCategoryIds),
                        "authors".PairWith(bookAuthorIds));
                else
                    repository.Update(bookTitle,
                        "categories".PairWith(bookCategoryIds),
                        "authors".PairWith(bookAuthorIds));

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
