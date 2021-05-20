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
    public partial class frmProduct_New : Form
    {
        Product productData;        
        OperationType opertationType;

        public frmProduct_New(Product _productData = null)
        {
            InitializeComponent();

            productData = _productData;
            opertationType = OperationType.Edit;

            if (_productData == null)
            {
                productData = new Product();
                opertationType = OperationType.New;
            }            
        }

        private void frmProduct_New_Load(object sender, EventArgs e)
        {
            setAutoSuggestControl();

            if (opertationType == OperationType.Edit)
            {
                LoadOldData();
            }
        }

        public void setAutoSuggestControl()
        {
            txtCategoryName.SuggestCustomSource(ProductImplementation.Suggest_ProudctCategory());
            txtProductName.SuggestCustomSource(ProductImplementation.Suggest_ProudctName());            
        }

        public void LoadOldData()
        {
            dtpEntryDate.Value = productData.EntryDate;
            txtCategoryName.Text = productData.CategoryName;
            txtProductName.Text = productData.ProductName;
            txtUnit.Text = productData.Unit;
            txtHsnCode.Text = productData.HsnCode;
            txtPurchaseRate.Value = (decimal)productData.PurchaseRate;
            txtSalesRate.Value = (decimal)productData.SalesRate;
            txtRemarks.Text = productData.Remarks;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            "hello".ShowError();
            "hello".ShowInformation();
            return;
            //  Get Data From Controls
            productData.EntryDate = dtpEntryDate.Value;
            productData.CategoryName = txtCategoryName.GetString();
            productData.ProductName = txtProductName.GetString();
            productData.Unit = txtUnit.GetString();
            productData.HsnCode = txtHsnCode.GetString();
            productData.PurchaseRate = txtPurchaseRate.GetDouble();
            productData.SalesRate = txtSalesRate.GetDouble();
            productData.Remarks = txtRemarks.GetString();

            //  Save
            var resultValidation = productData.Save();
            if (resultValidation.IsValid == false)
            {
                resultValidation.getError().ShowError();
                return;
            }

            "Product Saved.".ShowInformation();
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.GetString().Length == 0)
            {
                return;
            }

            if (ProductImplementation.FindByProductName(txtProductName.GetString(), productData.Id) != null)
            {
                "Duplicate Product Name!".ShowInformation();
                txtProductName.Text = "";
                txtProductName.Focus();
            }

        }

        private void frmProduct_New_Enter(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            control.Select(0, control.Text.Length);
        }
    }
}
