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
    public partial class SimulationForm : Form
    {
        // Repository
        private SRoleRepository sRoleRepository = new SRoleRepository();
        private SLoginRepository sLoginRepository = new SLoginRepository();

        public SimulationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SimulationForm_Shown(object sender, EventArgs e)
        {
            rolesDGV.DataSource = sRoleRepository.GetAll();
            rolesDGV.Refresh();

            loginsDGV.DataSource = sLoginRepository.GetAll();
            loginsDGV.Refresh();
        }

        private void refreshRoleBT_Click(object sender, EventArgs e)
        {
            try
            {
                rolesDGV.DataSource = sRoleRepository.GetAll();
                rolesDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
