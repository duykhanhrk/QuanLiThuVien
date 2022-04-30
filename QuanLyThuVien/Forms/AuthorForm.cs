using QuanLyThuVien.DataObject;
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

namespace QuanLyThuVien.Forms
{
    public partial class AuthorForm : Form
    {
        private AuthorRepository authorRepository = new AuthorRepository();
        private List<Author> authors = new List<Author>();

        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Shown(object sender, EventArgs e)
        {
            try
            {
                authors = authorRepository.GetAll();
                listDGV.DataSource = authors;
                listDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
