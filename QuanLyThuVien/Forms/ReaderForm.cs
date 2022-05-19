using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.ReaderForms;
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
    public partial class ReaderForm : Form
    {
        private ReaderRepository repository = new ReaderRepository();
        private List<Reader> list = new List<Reader>();

        public ReaderForm()
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

        private void ReaderForm_Shown(object sender, EventArgs e)
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

        private void searchTB_TextChange(object sender, EventArgs e)
        {
            try
            {
                list = repository.GetAll(searchTB.Text);
                listDGV.DataSource = list;
                listDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
