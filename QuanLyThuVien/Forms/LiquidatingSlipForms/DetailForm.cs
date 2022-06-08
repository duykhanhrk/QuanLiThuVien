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

namespace QuanLyThuVien.Forms.LiquidatingSlipForms
{
    public partial class DetailForm : Form
    {
        // Control
        private bool createMode;
        private bool _successed = false;
        public bool Successed
        {
            get { return _successed; }
        }

        // Repository
        private LiquidatingSlipRepository repository = new LiquidatingSlipRepository();
        private LiquidatingSlipDetailRepository liquidatingSlipDetailRepository = new LiquidatingSlipDetailRepository();

        // Object
        private LiquidatingSlip _selfObject;
        public LiquidatingSlip SelfObject
        {
            get { return _selfObject; }
        }

        public DetailForm()
        {
            createMode = true;
            _selfObject = new LiquidatingSlip();
            InitializeComponent();
        }

        public DetailForm(LiquidatingSlip liquidatingSlip)
        {
            createMode = false;
            _selfObject = liquidatingSlip;

            try
            {
                _selfObject.LiquidatingSlipDetails = liquidatingSlipDetailRepository.GetAllOfLiquidatingSlip(liquidatingSlip.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

            InitializeComponent();
        }

        private void PrepareInterface()
        {
            iDTB.Enabled = false;
            LibrarianIDTB.Enabled = false;
            createdAtDP.Enabled = false;

            if (!createMode)
            {
                saveBT.Enabled = false;
            }
        }

        private void PrepareData()
        {
            iDTB.Text = repository.FindNextId().ToString();
            LibrarianIDTB.Text = (Archive.Get("CurrentLibrarian") as Librarian).Id;

            if (createMode)
                return;

            iDTB.Text = _selfObject.Id.ToString();
            createdAtDP.Value = _selfObject.CreatedAt;
            LibrarianIDTB.Text = _selfObject.CreatedBy;
        }

        private void SaveData()
        {
            // Execute
            try
            {
                _selfObject.CreatedBy = (Archive.Get("CurrentLibrarian") as Librarian).Id;
                repository.Create(_selfObject);

                _successed = true;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DetailForm_Shown(object sender, EventArgs e)
        {
            PrepareInterface();
            PrepareData();
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void detailsBT_Click(object sender, EventArgs e)
        {
            LiquidatingSlipDetailForm liquidatingSlipDetailForm = new LiquidatingSlipDetailForm(_selfObject.LiquidatingSlipDetails, createMode);
            liquidatingSlipDetailForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            liquidatingSlipDetailForm.ShowDialog();

            _selfObject.LiquidatingSlipDetails = liquidatingSlipDetailForm.SelfObject;
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
