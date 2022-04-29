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

        private bool _logged;
        public bool Logged
        {
            get { return _logged; }
        }

        public LoginForm()
        {
            InitializeComponent();
            _logged = false;
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            try
            {
                DataObject.Librarian librarian = authRepository.Login(iDTB.Text, passwordTB.Text);
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
