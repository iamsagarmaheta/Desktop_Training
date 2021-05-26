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
    public partial class frmSales_List : Form
    {
        public frmSales_List()
        {
            InitializeComponent();
        }

        private void frmSales_List_Load(object sender, EventArgs e)
        {
            AutoSuggestData();
        }

        public void AutoSuggestData()
        {
            txtCustomerName.SuggestCustomSource(CustomerImplementation.Suggest_CustomerName());
            txtContactPerson.SuggestCustomSource(CustomerImplementation.Suggest_ContactPerson());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvCustomerData.SelectedRows.Count == 0)
            {
                "Please Select Details Your Want To Delete.".ShowError();
                return;
            }

            if ("Are You Sure You Want To Delete This Information ?".ConfirmDialouge() == false)
            {
                return;
            }

            int id = gvCustomerData.SelectedRows[0].Cells[gvcId.Name].GetString().ToInt();
            var result = CustomerImplementation.DeleteById(id);

            if (result == false)
            {
                "Failed To Delete Information.".ShowError();
                return;
            }

            FillGrid();
            "Details Deleted Successfully.".ShowInformation();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var form = new frmSales_New();
            form.ShowDialog();

            FillGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvCustomerData.SelectedRows.Count == 0)
            {
                "Please Select Details Your Want To Edit.".ShowError();
                return;
            }
            int id = gvCustomerData.SelectedRows[0].Cells[gvcId.Name].GetString().ToInt();
            var custData = CustomerImplementation.FindById(id);

           /* var custData = new Customer {
                Id = 12,
                JoiningDate = DateTime.Now,
                CustomerName = "abc company",
                ContactPerson = "Sagar",
                ContactNumber = "9700 5800 12",
                Address = "amber talkist",
                Email = "abc@gmail.com",
                OutstadningBalance = 2000.75,
                Remarks = "Here Some Remarks"
            };*/

            frmCustomer_New form = new frmCustomer_New(custData);
            form.ShowDialog();

            FillGrid();
        }

        private void frmSales_List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnNew_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnEdit_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                btnDelete_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnExport_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
