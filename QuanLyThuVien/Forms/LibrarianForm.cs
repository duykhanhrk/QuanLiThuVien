using Bunifu.UI.WinForms;
using QuanLyThuVien.DataObject;
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

namespace QuanLyThuVien.Forms
{
    public partial class LibrarianForm : Form
    {
        private LibrarianRepository librarianRepository = new LibrarianRepository();
        private List<Librarian> librarians = new List<Librarian>();

        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_Shown(object sender, EventArgs e)
        {
            try
            {
                librarians = librarianRepository.GetAll();
                librarianDGV.DataSource = librarians;
                librarianDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void librarianDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string id = librarianDGV.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            Librarian librarian = librarians.First(l => l.Id == id);

            LibrarianFroms.DetailForm detailForm = new LibrarianFroms.DetailForm(librarian);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();
            
        }

        private void creationBT_Click(object sender, EventArgs e)
        {
            LibrarianFroms.DetailForm detailForm = new LibrarianFroms.DetailForm();
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (librarianDGV.SelectedRows.Count == 0)
                return;

            string id = librarianDGV.CurrentRow.Cells["Id"].Value.ToString();
            Librarian librarian = librarians.First(l => l.Id == id);

            LibrarianFroms.DetailForm detailForm = new LibrarianFroms.DetailForm(librarian);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();
        }

        private void searchTB_TextChange(object sender, EventArgs e)
        {
            try
            {
                librarians = librarianRepository.GetAll(searchTB.Text);
                librarianDGV.DataSource = librarians;
                librarianDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
