using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.LibraryCardForms;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class LibraryCardForm : Form
    {
        private LibraryCardRepository repository = new LibraryCardRepository();
        private List<LibraryCard> list = new List<LibraryCard>();

        public LibraryCardForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            try
            {
                list = repository.FilterByKeyword(searchTB.Text);
                listDGV.DataSource = list;
                listDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void LibraryCardForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            LibraryCard libraryCard = (LibraryCard)listDGV.Rows[e.RowIndex].DataBoundItem;

            DetailForm detailForm = new DetailForm(libraryCard);
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

            LibraryCard libraryCard = (LibraryCard)listDGV.CurrentRow.DataBoundItem;

            DetailForm detailForm = new DetailForm(libraryCard);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            LibraryCard libraryCard = (LibraryCard)listDGV.CurrentRow.DataBoundItem;

            try
            {
                repository.Delete(libraryCard.Id);
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
