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

        
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Clicked.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Clicked.");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProduct_New productNew = new frmProduct_New();
            productNew.ShowDialog();
        }
    }
}
