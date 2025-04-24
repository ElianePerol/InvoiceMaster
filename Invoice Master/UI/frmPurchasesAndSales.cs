using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Master.UI
{
    public partial class frmPurchasesAndSales : Form
    {
        public frmPurchasesAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPurchasesAndSales_Load(object sender, EventArgs e)
        {
            // Get the transactionType value from frmUserDashboard
            string type = frmUserDashboard.transactionType;

            // Set the value on lblTop
            lblTop.Text = type;
        }
    }
}
