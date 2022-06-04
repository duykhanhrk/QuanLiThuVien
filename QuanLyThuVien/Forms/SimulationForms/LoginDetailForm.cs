using QuanLyThuVien.DataObject;
using QuanLyThuVien.Lib;
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

namespace QuanLyThuVien.Forms.SimulationForms
{
    public partial class LoginDetailForm : Form
    {

        // Control
        int mode = 0; // 0: Creation, 1: update, 2: show
        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Repository
        private SLoginRepository repository = new SLoginRepository();
        private SRoleRepository sRoleRepository = new SRoleRepository();

        // Object
        private SLogin _selfObject;
        public SLogin SelfObject
        {
            get { return _selfObject; }
        }

        public LoginDetailForm()
        {
            mode = 0;
            _selfObject = new SLogin();

            InitializeComponent();
        }

        public LoginDetailForm(SLogin sLogin, short mode = 1)
        {
            this.mode = mode;
            _selfObject = sLogin;

            // Load SGants
            try
            {
                _selfObject.SRoles = sRoleRepository.GetAllOfLogin(sLogin.LoginName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            if (mode != 0)
                nameTB.Enabled = false;
        }

        private void PrepareData()
        {
            List<SRole> sRoles = new List<SRole>();

            try
            {
                sRoles = sRoleRepository.GetAll();
                roleCB.Items.AddRange(sRoles.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            if (mode == 0)
                return;

            try
            {
                var userRoles = sRoleRepository.GetAllOfLogin(_selfObject.LoginName);
                roleCB.SetItemsCheckState<SRole>(userRoles.ToArray(), "Name", CheckState.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            nameTB.Text = _selfObject.LoginName;
        }

        private void SaveData()
        {
            try
            {
                if (mode == 0)
                {
                    _selfObject.LoginName = nameTB.Text;
                    _selfObject.Username = nameTB.Text;
                    _selfObject.Password = passTB.Text;
                    _selfObject.SRoles = roleCB.CheckedItems.OfType<SRole>().ToList();
                    repository.Create(_selfObject);
                }
                else
                {
                    _selfObject.Password = passTB.Text.Trim();
                    _selfObject.SRoles = roleCB.CheckedItems.OfType<SRole>().ToList();
                    repository.Update(_selfObject);
                }

                _successed = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginDetailForm_Shown(object sender, EventArgs e)
        {
            PrepareInterface();
            PrepareData();
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
