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
    public partial class frmSales_Add : Form
    {
        public InvoiceDetail invoiceDetail;
        private OperationType operationType { get; set; }
        public bool IsSelected { get; set; }

        public frmSales_Add(InvoiceDetail _invoiceDetail = null)
        {
            InitializeComponent();
            invoiceDetail = _invoiceDetail;
            operationType = OperationType.Edit;
            if (_invoiceDetail == null)
            {
                invoiceDetail = new InvoiceDetail();
                operationType = OperationType.New;
            }
        }

        private void frmSales_Add_Load(object sender, EventArgs e)
        {
            AutoSuggestControl();
            if (operationType == OperationType.Edit)
            {
                LoadOldData();
            }
        }

        public void AutoSuggestControl()
        {
            txtProductName.SuggestCustomSource(ProductImplementation.Suggest_ProudctName());
        }

        public void LoadOldData()
        {
            txtProductName.Text = invoiceDetail.ProductName;
            txtQty.Value = (decimal)invoiceDetail.Quantity;
            txtSalesRate.Value = (decimal)invoiceDetail.SalesRate;
            txtDiscount.Value = (decimal)invoiceDetail.Discount;
            txtGstRate.Value = (decimal)invoiceDetail.TaxRate;
            txtRemarks.Text = invoiceDetail.Remarks;
            CalculateTotal();
        }

        private void txtSalesRate_Enter(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            control.Select(0, control.Text.Length);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGstRate_Leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        public void CalculateTotal()
        {
            invoiceDetail.SalesRate = txtSalesRate.GetDouble();
            invoiceDetail.Quantity = txtQty.GetDouble();
            invoiceDetail.Discount = txtDiscount.GetDouble();
            invoiceDetail.TaxRate = txtGstRate.GetDouble();

            txtSubTotal.Value = (decimal)invoiceDetail.SubTotal;
            txtTaxableValue.Value = (decimal)invoiceDetail.TaxableValue;
            txtGstAmount.Value = (decimal)invoiceDetail.TaxAmount;
            txtTotalAmount.Value = (decimal)invoiceDetail.TotalAmount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            invoiceDetail.Remarks = txtRemarks.GetString();
            CalculateTotal();

            OperationResult validationResult = invoiceDetail.Validate();
            if (validationResult.IsValid == false)
            {
                validationResult.getError().ShowError();
                return;
            }
            IsSelected = true;
            this.Close();
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            invoiceDetail.ProductData = null;
            invoiceDetail.ProductDataId = 0;
            if (txtProductName.GetStringLength() == 0)
            {
                return;
            }

            invoiceDetail.ProductData = ProductImplementation.FindByProductName(txtProductName.GetString());
            if (invoiceDetail.ProductData == null)
            {
                "Please Enter Valid Product Name".ShowError();
                return;
            }
            invoiceDetail.ProductDataId = invoiceDetail.ProductData.Id;
            txtProductName.Text = invoiceDetail.ProductName;
            if (operationType == OperationType.New)
            {
                txtSalesRate.Value = (decimal)invoiceDetail.ProductData.SalesRate;
                txtGstRate.Value = (decimal)invoiceDetail.ProductData.GstRate;
            }            
        }
    }
}
