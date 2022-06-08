using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.AuthorForms;
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
        private AuthorRepository repository = new AuthorRepository();
        private List<Author> authors = new List<Author>();

        public AuthorForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            try
            {
                authors = repository.FilterByKeyword(searchTB.Text);
                listDGV.DataSource = authors;
                listDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void AuthorForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Author author = (Author)listDGV.Rows[e.RowIndex].DataBoundItem;

            DetailForm detailForm = new DetailForm(author);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void creationBT_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            Author author = (Author)listDGV.CurrentRow.DataBoundItem;

            DetailForm detailForm = new DetailForm(author);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            Author author = (Author)listDGV.CurrentRow.DataBoundItem;

            try
            {
                repository.Delete(author.Id);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void searchTB_TextChange(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
