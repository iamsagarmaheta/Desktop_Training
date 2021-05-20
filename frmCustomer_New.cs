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
    public partial class frmCustomer_New : Form
    {
        Customer customer;
        OperationType operationType;

        public frmCustomer_New(Customer _customer = null)
        {
            InitializeComponent();

            operationType = OperationType.New;
            customer = new Customer();

            if (_customer != null)
            {
                operationType = OperationType.Edit;
                customer = _customer;
            }
        }

        private void frmCustomer_New_Load(object sender, EventArgs e)
        {
            AutoSuggestData();
            if (operationType == OperationType.Edit)
            {
                LoadOldData();
            }
        }

        public void AutoSuggestData()
        {
            txtCustomerName.SuggestCustomSource(CustomerImplementation.Suggest_CustomerName());
            txtContactPerson.SuggestCustomSource(CustomerImplementation.Suggest_ContactPerson());
        }

        public void LoadOldData()
        {
            dtpJoinDate.Value = customer.JoiningDate;
            txtCustomerName.Text = customer.CustomerName;
            txtContactPerson.Text = customer.ContactPerson;
            txtContactNumber.Text = customer.ContactNumber;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtOutstandingBalance.Value = (decimal)customer.OutstadningBalance;
            txtRemarks.Text = customer.Remarks;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOutstandingBalance_Enter(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            control.Select(0, control.Text.Length);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customer.JoiningDate = dtpJoinDate.Value;
            customer.CustomerName = txtCustomerName.GetString();
            customer.ContactPerson = txtContactPerson.GetString();
            customer.ContactNumber = txtContactNumber.GetString();
            customer.Address = txtAddress.GetString();
            customer.Email = txtEmail.GetString();
            customer.OutstadningBalance = txtOutstandingBalance.GetDouble();
            customer.Remarks = txtRemarks.GetString();

            var result = customer.Save();
            if (result.IsValid == false)
            {
                result.getError().ShowError();
                return;
            }

            "Details Saved Successfully.".ShowInformation();
            this.Close();
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (txtCustomerName.GetStringLength() == 0)
            {
                return;
            }

            var custData = CustomerImplementation.FindByCustomerName(txtCustomerName.GetString(), customer.Id);
            if (custData != null)
            {
                "Duplicate Customer Name".ShowError();
                txtCustomerName.Text = "";
                txtCustomerName.Focus();
                return;
            }
        }
    }
}
