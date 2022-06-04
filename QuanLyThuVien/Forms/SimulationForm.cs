using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.SimulationForms;
using QuanLyThuVien.Repository;
using System;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class SimulationForm : Form
    {
        // Repository
        private SRoleRepository sRoleRepository = new SRoleRepository();
        private SLoginRepository sLoginRepository = new SLoginRepository();
        private BackupRestoreRepository backupRestoreRepository = new BackupRestoreRepository();

        public SimulationForm()
        {
            InitializeComponent();
        }

        // Refresh
        private void RefreshRoleData()
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

        private void RefreshLoginData()
        {
            try
            {
                loginsDGV.DataSource = sLoginRepository.GetAll();
                loginsDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SimulationForm_Shown(object sender, EventArgs e)
        {
            // Role
            RefreshRoleData();

            // Login
            RefreshLoginData();
        }

        private void refreshRoleBT_Click(object sender, EventArgs e)
        {
            RefreshRoleData();
        }

        private void rolesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SRole sRole = (SRole)rolesDGV.Rows[e.RowIndex].DataBoundItem;

            RoleDetailForm detailForm = new RoleDetailForm(sRole);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshRoleData();
        }

        private void addRoleBT_Click(object sender, EventArgs e)
        {
            RoleDetailForm detailForm = new RoleDetailForm();
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshRoleData();
        }

        private void removeRoleBT_Click(object sender, EventArgs e)
        {
            if (rolesDGV.SelectedRows.Count == 0)
                return;

            SRole sRole = (SRole)rolesDGV.CurrentRow.DataBoundItem;

            try
            {
                sRoleRepository.Delete(sRole.Name);
                RefreshRoleData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateRoleBT_Click(object sender, EventArgs e)
        {
            if (rolesDGV.SelectedRows.Count == 0)
                return;

            SRole sRole = (SRole)rolesDGV.CurrentRow.DataBoundItem;

            RoleDetailForm detailForm = new RoleDetailForm(sRole);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshRoleData();
        }

        private void addLoginBT_Click(object sender, EventArgs e)
        {
            LoginDetailForm detailForm = new LoginDetailForm();
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshLoginData();
        }

        private void loginsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SLogin sLogin = (SLogin)loginsDGV.Rows[e.RowIndex].DataBoundItem;

            LoginDetailForm detailForm = new LoginDetailForm(sLogin);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshLoginData();
        }

        private void deleteLoginBT_Click(object sender, EventArgs e)
        {
            if (loginsDGV.SelectedRows.Count == 0)
                return;

            SLogin sLogin = (SLogin)loginsDGV.CurrentRow.DataBoundItem;

            try
            {
                sLoginRepository.Delete(sLogin.LoginName);
                RefreshLoginData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateLoginBT_Click(object sender, EventArgs e)
        {
            if (loginsDGV.SelectedRows.Count == 0)
                return;

            SLogin sLogin = (SLogin)loginsDGV.CurrentRow.DataBoundItem;

            LoginDetailForm detailForm = new LoginDetailForm(sLogin);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshLoginData();
        }

        private void refreshLoginsButton_Click(object sender, EventArgs e)
        {
            RefreshLoginData();
        }

        private void fullBKBT_Click(object sender, EventArgs e)
        {
            try
            {
                backupRestoreRepository.FullBackup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void diffBKBT_Click(object sender, EventArgs e)
        {
            try
            {
                backupRestoreRepository.DiffBackup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fullRSBT_Click(object sender, EventArgs e)
        {
            try
            {
                backupRestoreRepository.FullRestore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void diffRSBT_Click(object sender, EventArgs e)
        {
            try
            {
                backupRestoreRepository.DiffRestore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
