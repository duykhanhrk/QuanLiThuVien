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

namespace QuanLyThuVien.Forms.SimulationForms
{
    public partial class RoleDetailForm : Form
    {
        // Control
        int mode = 0; // 0: Creation, 1: update, 2: show
        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Repository
        private SRoleRepository repository = new SRoleRepository();
        private SGantRepository sGantRepository = new SGantRepository();

        // Object
        private SRole _selfObject;
        public SRole SelfObject
        {
            get { return _selfObject; }
        }

        public RoleDetailForm()
        {
            mode = 0;
            _selfObject = new SRole();

            // Load SGants
            try
            {
                _selfObject.SGants = sGantRepository.GetAllOfSRole("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            InitializeComponent();
        }

        public RoleDetailForm(SRole sRole, short mode = 1)
        {
            this.mode = mode;
            _selfObject = sRole;

            // Load SGants
            try
            {
                _selfObject.SGants = sGantRepository.GetAllOfSRole(sRole.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            InitializeComponent();
        }

        private void SaveData()
        {
            try
            {
                if (mode == 0)
                {
                    _selfObject.Name = nameTB.Text;
                    repository.Create(_selfObject);
                }
                else
                {
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

        private void RoleDetailForm_Shown(object sender, EventArgs e)
        {
            nameTB.Text = _selfObject.Name;
            tableDGV.DataSource = _selfObject.SGants;
            tableDGV.Refresh();
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
