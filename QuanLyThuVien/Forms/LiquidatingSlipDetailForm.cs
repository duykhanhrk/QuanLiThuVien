using QuanLyThuVien.DataObject;
using QuanLyThuVien.Forms.LiquidatingSlipDetailForms;
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
    public partial class LiquidatingSlipDetailForm : Form
    {
        // Control
        private bool createMode;

        // Object
        private List<LiquidatingSlipDetail> _selfObject;
        public List<LiquidatingSlipDetail> SelfObject
        {
            get { return _selfObject; }
        }

        public LiquidatingSlipDetailForm(List<LiquidatingSlipDetail> list, bool createMode = false)
        {
            this.createMode = createMode;
            _selfObject = new List<LiquidatingSlipDetail>(list);
            InitializeComponent();
        }

        private void RefreshData()
        {
            listDGV.DataSource = new List<LiquidatingSlipDetail>();
            listDGV.DataSource = _selfObject;
            listDGV.Refresh();
        }

        private void LiquidatingSlipDetailForm_Shown(object sender, EventArgs e)
        {
            if (_selfObject.Count > 0)
                RefreshData();

            if (!createMode)
            {
                creationBT.Enabled = false;
                updateBT.Enabled = false;
                deleteBT.Enabled = false;
            }
        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            LiquidatingSlipDetail liquidatingSlipDetail = (LiquidatingSlipDetail)listDGV.Rows[e.RowIndex].DataBoundItem;

            DetailForm detailForm = new DetailForm(liquidatingSlipDetail, createMode);

            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void creationBT_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm(createMode);

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

            LiquidatingSlipDetail liquidatingSlipDetail = (LiquidatingSlipDetail)listDGV.CurrentRow.DataBoundItem;

            DetailForm detailForm = new DetailForm(liquidatingSlipDetail);

            detailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            detailForm.ShowDialog();

            if (detailForm.Successed)
                RefreshData();
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedRows.Count == 0)
                return;

            LiquidatingSlipDetail liquidatingSlipDetail = (LiquidatingSlipDetail)listDGV.CurrentRow.DataBoundItem;

            _selfObject.Remove(liquidatingSlipDetail);

            RefreshData();
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
