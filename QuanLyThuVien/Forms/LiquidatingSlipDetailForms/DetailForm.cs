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

namespace QuanLyThuVien.Forms.LiquidatingSlipDetailForms
{
    public partial class DetailForm : Form
    {
        // Control
        private bool creationMode;

        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Self Object
        private LiquidatingSlipDetail _selfObject;
        public LiquidatingSlipDetail SelfObject
        {
            get { return _selfObject; }
        }

        // Repository
        private BookRepository bookRepository = new BookRepository();

        public DetailForm(bool createMode = false)
        {
            this.creationMode = createMode;
            _selfObject = new LiquidatingSlipDetail();
            InitializeComponent();
        }

        public DetailForm(LiquidatingSlipDetail liquidatingSlipDetail, bool creationMode = false)
        {
            this.creationMode = creationMode;
            _selfObject = liquidatingSlipDetail;
            InitializeComponent();
        }

        private void PrepareInterface()
        {
            if (creationMode)
                return;

            bookDD.Enabled = false;
            priceTB.Enabled = false;
            saveBT.Enabled = false;
        }

        private void PrepareData()
        {
            var books = new List<Book>();

            try
            {
                // Book cases
                books = bookRepository.GetAllBy("Status".PairWith(1), "Lending".PairWith(false));
                bookDD.QuickBuild(books, "Id", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
                Close();
                return;
            }

            if (creationMode)
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

            priceTB.Text = _selfObject.Price.ToString();
        }

        private void SaveData()
        {

            try
            {
                _selfObject.BookId = (bookDD.SelectedItem as Book).Id;
                _selfObject.Price = Decimal.Parse(priceTB.Text);
                _successed = true;
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
            Close();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
