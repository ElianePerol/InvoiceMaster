using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.DAL;

namespace Invoice_Master.UI
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        TransactionDAL tdal = new TransactionDAL();

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            // Display al the transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Display al the transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the value from the combo box
            string type = cmbTransactionType.Text;

            DataTable dt = tdal.DisplayTransactionByType(type);
            dgvTransactions.DataSource = dt;
        }

    }
}
