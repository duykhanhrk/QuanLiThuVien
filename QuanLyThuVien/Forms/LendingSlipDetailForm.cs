using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.LendingSlipDetailForms;
using QuanLyThuVien.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuVien.Forms
{
    public partial class LendingSlipDetailForm : Form
    {
        // Control
        private short mode = 0;

        // Repository
        private LendingSlipDetailRepository repository = new LendingSlipDetailRepository();
        private LendingSlipRepository lendingSlipRepository = new LendingSlipRepository();

        // Object
        private List<LendingSlipDetail> _selfObject;
        public List<LendingSlipDetail> SelfObject
        {
            get { return _selfObject; }
        }

        public LendingSlipDetailForm()
        {
            mode = 0;
            _selfObject = new List<LendingSlipDetail>();
            InitializeComponent();
        }

        public LendingSlipDetailForm(List<LendingSlipDetail> list, short mode = 0)
        {
            this.mode = mode;
            _selfObject = list;
            InitializeComponent();
        }

        private void RefreshData()
        {
            listDGV.DataSource = null;
            listDGV.DataSource = _selfObject;
            listDGV.Refresh();
        }

        private void LendingSlipDetailForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            LendingSlipDetail lendingSlipDetail = (LendingSlipDetail)listDGV.Rows[e.RowIndex].DataBoundItem;

            DetailForm detailForm = new DetailForm(lendingSlipDetail);

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
            {
                _selfObject.Add(detailForm.SelfObject);
                RefreshData();
            }
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            LendingSlipDetail lendingSlipDetail = (LendingSlipDetail)listDGV.CurrentRow.DataBoundItem;

            DetailForm detailForm = new DetailForm(lendingSlipDetail);

            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            LendingSlipDetail lendingSlipDetail = (LendingSlipDetail)listDGV.CurrentRow.DataBoundItem;

            _selfObject.Remove(lendingSlipDetail);
            RefreshData();
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
