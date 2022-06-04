using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.LiquidatingSlipForms;
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
    public partial class LiquidatingSlipForm : Form
    {
        private LiquidatingSlipRepository repository = new LiquidatingSlipRepository();
        private List<LiquidatingSlip> list = new List<LiquidatingSlip>();

        public LiquidatingSlipForm()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            try
            {
                list = repository.GetAll();
                listDGV.DataSource = list;
                listDGV.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void LiquidatingSlipForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            LiquidatingSlip liquidatingSlip = (LiquidatingSlip)listDGV.Rows[e.RowIndex].DataBoundItem;

            DetailForm detailForm = new DetailForm(liquidatingSlip);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void creationBT_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            LiquidatingSlip liquidatingSlip = (LiquidatingSlip)listDGV.CurrentRow.DataBoundItem;

            DetailForm detailForm = new DetailForm(liquidatingSlip);
            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            LendingSlip lendingSlip = (LendingSlip)listDGV.CurrentRow.DataBoundItem;

            try
            {
                repository.Delete(lendingSlip.Id);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
