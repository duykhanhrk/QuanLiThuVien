using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.LendingSlipDetailForms;
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
    public partial class LendingSlipDetailForm : Form
    {
        // Control
        private bool onlyAction;
        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Repository
        private LendingSlipDetailRepository repository = new LendingSlipDetailRepository();
        private LendingSlipRepository lendingSlipRepository = new LendingSlipRepository();

        // Object
        private List<LendingSlipDetail> _selfObject;
        public List<LendingSlipDetail> SelfObject
        {
            get { return _selfObject; }
        }

        public LendingSlipDetailForm(List<LendingSlipDetail> list, bool onlyAction = false)
        {
            this.onlyAction = onlyAction;
            _selfObject = new List<LendingSlipDetail>(list);
            InitializeComponent();
        }

        private void RefreshData()
        {
            listDGV.DataSource = new List<LendingSlipDetail>();
            listDGV.DataSource = _selfObject;
            listDGV.Refresh();
        }

        private void LendingSlipDetailForm_Shown(object sender, EventArgs e)
        {
            if (_selfObject.Count > 0)
            {
                listDGV.DataSource = _selfObject;
                listDGV.Refresh();
            }

            if (onlyAction)
            {
                creationBT.Enabled = false;
                deleteBT.Enabled = false;
            }
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            LendingSlipDetail lendingSlipDetail = (LendingSlipDetail)listDGV.Rows[e.RowIndex].DataBoundItem;

            DetailForm detailForm = new DetailForm(lendingSlipDetail, 1, onlyAction);

            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void creationBT_Click(object sender, EventArgs e)
        {
            if (_selfObject.Count > 2)
            {
                MessageBox.Show("Số sách không vượt 3 quyển");
                return;
            }

            DetailForm detailForm = new DetailForm(onlyAction);

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

            DetailForm detailForm = new DetailForm(lendingSlipDetail, 1, onlyAction);

            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            _successed = detailForm.Successed;

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
