using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.BLL;
using Invoice_Master.DAL;

namespace Invoice_Master.UI
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        CategoriesDAL cdal = new CategoriesDAL();
        ProductsDAL pdal = new ProductsDAL();

        private void frmInventory_Load(object sender, EventArgs e)
        {
            // Display all the categories in the combo box
            DataTable cDT = cdal.Select();
            cmbCategory.DataSource = cDT;

            // Gives the Value Member and Display Member for the combo box
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
            cmbCategory.SelectedIndex = -1;

            // Display all the categories in the data grid view
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the value from the combo box
            string category = cmbCategory.Text;

            DataTable dt = pdal.DisplayProductByCategory(category);
            dgvProducts.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Display al the transactions
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }
    }
}
