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

        private void SetContentForm(Type type)
        {
            if (type == null) return;

            if (form == null || form.GetType() != type)
                form = (Form)Activator.CreateInstance(type);

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
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

            SetContentForm(typeof(ProfileForm));
        }
    }
}
