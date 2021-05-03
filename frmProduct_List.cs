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
    public partial class frmProduct_List : Form
    {
        public frmProduct_List()
        {
            InitializeComponent();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvProductData.SelectedRows.Count == 0)
            {
                "Please Select Prodct You Want To Delete.".ShowError();
                return;
            }

            int id = gvProductData.SelectedRows[0].Cells[gvcId.Name].GetString().ToInt();
            bool result = ProductImplementation.DeleteById(id);
            if (result == true)
            {
                "Data Deleted.".ShowInformation();
            }
            else
            {
                "Failed To Delete Data".ShowError();
            }
            FillGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();   
        }

        public void FillGrid()
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProduct_New form = new frmProduct_New();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvProductData.SelectedRows.Count == 0)
            {
                "Please Select Prodct You Want To Edit.".ShowError();
                return;
            }

            int id = gvProductData.SelectedRows[0].Cells[gvcId.Name].GetString().ToInt();
            Product proData = ProductImplementation.FindById(id);

            frmProduct_New form = new frmProduct_New(proData);
            form.ShowDialog();
        }
    }
}
