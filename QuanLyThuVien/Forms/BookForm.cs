using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.BookForms;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace QuanLyThuVien.Forms
{
    public partial class BookForm : Form
    {
        private BookRepository repository = new BookRepository();
        private List<Book> list = new List<Book>();

        public BookForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            try
            {
                list = repository.GetAll();
                listDGV.DataSource = list;
                listDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void BookForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string id = listDGV.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            DetailForm detailForm = new DetailForm(id);
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

            string id = listDGV.CurrentRow.Cells["Id"].Value.ToString();

            DetailForm detailForm = new DetailForm(id);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            string id = listDGV.CurrentRow.Cells["Id"].Value.ToString();

            try
            {
                repository.Delete(id);
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
    }
}
