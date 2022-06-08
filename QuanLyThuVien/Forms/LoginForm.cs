using QuanLyThuVien.DataObject;
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
    public partial class LoginForm : Form
    {
        private Repository.AuthRepository authRepository = new Repository.AuthRepository();

        // Logged
        private bool _logged = false;
        public bool Logged
        {
            get { return _logged; }
        }

        // Librarian
        private Librarian _librarian;
        public Librarian Librarian
        {
            get { return _librarian; }
        }

        public LoginForm()
        {
            InitializeComponent();
            _logged = false;
        }

        // Login
        private void login()
        {
            try
            {
                _librarian = authRepository.Login(iDTB.Text, passwordTB.Text);
                _logged = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            // Dev
            if (iDTB.Text == "" || passwordTB.Text == "")
            {
                iDTB.Text = "LB00000011";
                passwordTB.Text = "12";
            }

            login();
        }

        private void iDTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && iDTB.Text != "" && passwordTB.Text != "")
                login();
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && iDTB.Text != "" && passwordTB.Text != "")
                login();
        }
    }
}
