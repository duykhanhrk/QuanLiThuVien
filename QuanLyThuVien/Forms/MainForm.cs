using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
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
    public partial class MainForm : Form
    {
        private Form form;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetContentForm(Type type, params Object[] args)
        {
            if (type == null) return;

            if (form == null || form.GetType() != type)
                form = (Form)Activator.CreateInstance(type, args);

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(form);

            form.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            loginForm.ShowDialog();

            if (!loginForm.Logged)
                Close();

            // Save current librarian to Archive
            Archive.Save("CurrentLibrarian", loginForm.Librarian);

            // Show profile form
            SetContentForm(typeof(ProfileForm), loginForm.Librarian.Id);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(ProfileForm), (Archive.Get("CurrentLibrarian") as Librarian).Id);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(LibrarianForm));
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(BookTitleForm));
        }

        private void authorBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(AuthorForm));
        }
        
        private void readerBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(ReaderForm));
        }

        private void bookBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(BookForm));
        }

        private void lendingSlipBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(LendingSlipForm));
        }

        private void simulationBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(SimulationForm));
        }

        private void libraryCardBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(LibraryCardForm));
        }

        private void liquidatingSlipBT_Click(object sender, EventArgs e)
        {
            SetContentForm(typeof(LiquidatingSlipForm));
        }
    }
}
