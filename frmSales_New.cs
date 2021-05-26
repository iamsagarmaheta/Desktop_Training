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

            if (opertationType == OperationType.New)
            {
                txtInvoiceNo.Text = InvoiceImplementation.GenerateInvoiceNo(dtpInvoiceDate.Value.GetFinancialYear());
            }
            else
            {
                LoadOldData();
            }
        }

        public void setAutoSuggestControl()
        {
            txtCustomerName.SuggestCustomSource(CustomerImplementation.Suggest_CustomerName());
            txtContactNo.SuggestCustomSource(CustomerImplementation.Suggest_ContactNumber());

            cmbGstType.DataSource = Enum.GetValues(typeof(GstType));
        }

        public void LoadOldData()
        {
            txtCustomerName.Text = invoiceData.CustomerData.CustomerName;
            txtInvoiceNo.Text = invoiceData.InvoiceNo;
            dtpInvoiceDate.Value = invoiceData.InvoiceDate;
            txtRoundOff.Value = (decimal)invoiceData.RoundOff;
            txtRemarks.Text = invoiceData.Remarks;
            cmbGstType.SelectedItem = invoiceData.Gst_Type;

            UpdateInvoiceTotal();
            SetGridViewSource();
        }

        public void UpdateInvoiceTotal()
        {
            invoiceData.RoundOff = txtRoundOff.GetDouble();
            invoiceData.Gst_Type = (GstType)cmbGstType.SelectedItem;

            txtSubTotal.Value = (decimal)invoiceData.SubTotal;
            txtDiscount.Value = (decimal)invoiceData.Discount;
            txtTaxableValue.Value = (decimal)invoiceData.TaxableValue;
            txtTaxAmount.Value = (decimal)invoiceData.TaxAmount;
            txtRoundOff.Value = (decimal)invoiceData.RoundOff;
            txtGrandTotal.Value = (decimal)invoiceData.GrandTotal;
            txtCgstAmt.Value = (decimal)invoiceData.CGSTAmount;
            txtSgstAmt.Value = (decimal)invoiceData.SGSTAmount;
            txtIgstAmt.Value = (decimal)invoiceData.IGSTAmount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //  Get Data From Controls
            txtCustomerName_Leave(null, null);
            invoiceData.InvoiceDate = dtpInvoiceDate.Value;
            invoiceData.InvoiceNo = txtInvoiceNo.GetString();
            invoiceData.Remarks = txtRemarks.GetString();
            UpdateInvoiceTotal();

            //  Save
            var resultValidation = invoiceData.Save();
            if (resultValidation.IsValid == false)
            {
                resultValidation.getError().ShowError();
                return;
            }

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

        public void SetGridViewSource()
        {
            gvSalesData.DataSource = null;
            gvSalesData.AutoGenerateColumns = false;
            gvSalesData.DataSource = invoiceData.InvoiceDetails.Where(i => i.IsDeleted == false).ToList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSales_Add();
            frm.ShowDialog();

            if (frm.IsSelected == false)
            {
                return;
            }
            invoiceData.InvoiceDetails.Add(frm.invoiceDetail);
            SetGridViewSource();
            UpdateInvoiceTotal();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (gvSalesData.SelectedRows.Count == 0)
            {
                "Please Select Details You Want To Edit.".ShowError();
                return;
            }

            InvoiceDetail _selectedItem = (InvoiceDetail)gvSalesData.SelectedRows[0].DataBoundItem;
            var data = invoiceData.InvoiceDetails.Where(i => i == _selectedItem).SingleOrDefault();
            var frm = new frmSales_Add(data);
            frm.ShowDialog();

            if (frm.IsSelected)
            {
                SetGridViewSource();
                UpdateInvoiceTotal();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (gvSalesData.SelectedRows.Count == 0)
            {
                "Please Select Details You Want To Delete.".ShowError();
                return;
            }

            if ("Are You Sure?".ConfirmDialouge() == false)
            {
                return;
            }

            InvoiceDetail _deletedItem = (InvoiceDetail)gvSalesData.SelectedRows[0].DataBoundItem;
            if (_deletedItem.Id == 0)
            {
                invoiceData.InvoiceDetails.Remove(_deletedItem);
            }
            else
            {
                invoiceData.InvoiceDetails.First(i => i == _deletedItem).IsDeleted = true;
            }
            SetGridViewSource();
            UpdateInvoiceTotal();
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            invoiceData.CustomerData = null;
            invoiceData.CustomerDataId = 0;
            if (txtCustomerName.GetStringLength() == 0)
            {
                return;
            }

            invoiceData.CustomerData = CustomerImplementation.FindByCustomerName(txtCustomerName.GetString());
            if (invoiceData.CustomerData == null)
            {
                "Please Enter Valid Customer Name.".ShowError();
                return;
            }
            invoiceData.CustomerDataId = invoiceData.CustomerData.Id;
            txtCustomerName.Text = invoiceData.CustomerName;
            txtContactNo.Text = invoiceData.CustomerData.ContactNumber;
        }

        private void dtpInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            if (invoiceData.Id == 0)
            {
                txtInvoiceNo.Text = InvoiceImplementation.GenerateInvoiceNo(dtpInvoiceDate.Value.GetFinancialYear());
            }
        }

        private void cmbGstType_Leave(object sender, EventArgs e)
        {
            UpdateInvoiceTotal();
        }

        private void txtRoundOff_Leave(object sender, EventArgs e)
        {
            UpdateInvoiceTotal();
        }

        private void gvSalesData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gvSalesData.ShowRowNumbers(gvcNo);
        }

        private void gvSalesData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditItem_Click(sender, e);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            "".ShowError();
        }
    }
}
