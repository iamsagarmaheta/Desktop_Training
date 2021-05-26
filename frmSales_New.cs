using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTBilling
{
    public partial class frmSales_New : Form
    {
        Invoice invoiceData;
        OperationType opertationType;

        public frmSales_New(Invoice _invoiceData = null)
        {
            InitializeComponent();

            invoiceData = _invoiceData;
            opertationType = OperationType.Edit;

            if (_invoiceData == null)
            {
                invoiceData = new Invoice();
                opertationType = OperationType.New;
            }
        }

        private void frmSales_New_Load(object sender, EventArgs e)
        {
            setAutoSuggestControl();

            if (opertationType == OperationType.Edit)
            {
                LoadOldData();
            }
        }

        public void setAutoSuggestControl()
        {
            txtCustomerName.SuggestCustomSource(CustomerImplementation.Suggest_CustomerName());
            txtContactNo.SuggestCustomSource(CustomerImplementation.Suggest_ContactNumber());
        }

        public void LoadOldData()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //  Get Data From Controls


            //  Save
            /*var resultValidation = productData.Save();
            if (resultValidation.IsValid == false)
            {
                resultValidation.getError().ShowError();
                return;
            }*/

            "Invoice Details Saved.".ShowInformation();
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRoundOff_Enter(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            control.Select(0, control.Text.Length);
        }
    }
}
