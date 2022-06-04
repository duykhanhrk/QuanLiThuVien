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

        private void loginBT_Click(object sender, EventArgs e)
        {
            // Dev
            if (iDTB.Text == "" || passwordTB.Text == "")
            {
                iDTB.Text = "LB00000011";
                passwordTB.Text = "12";
            }

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
    }
}
