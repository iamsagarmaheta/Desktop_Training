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

        public frmProduct_New()
        {
            InitializeComponent();

            productData = new Product();
        }

        private void frmProduct_New_Load(object sender, EventArgs e)
        {
            if (productData.Id != 0)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //  Get Data From Controls
            productData.EntryDate = dtpEntryDate.Value;
            productData.CategoryName = txtCategoryName.Text.Trim();
            productData.ProductName = txtProductName.Text.Trim();
            productData.Unit = txtUnit.Text.Trim();
            productData.HsnCode = txtHsnCode.Text.Trim();
            productData.PurchaseRate = (double)txtPurchaseRate.Value;
            productData.SalesRate = (double)txtSalesRate.Value;
            productData.Remarks = txtRemarks.Text.Trim();

            //  Validation
            

            //  Data Save

            MessageBox.Show("Category Name " + productData.CategoryName + ", Product Name : " + productData.ProductName);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
