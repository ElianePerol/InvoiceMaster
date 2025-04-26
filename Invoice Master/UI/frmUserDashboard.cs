using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.UI;

namespace Invoice_Master
{
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        public static string transactionType;

        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Open Login form when the admin dashboard is closed
            frmLogin login = new frmLogin();
            login.Show();

            // Hide the current form
            this.Hide();
        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }

        private void fournisseursEtClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust product = new frmDeaCust();
            product.Show();
        }

        private void achatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set value on transactionType static method
            transactionType = "ACHATS";

            frmPurchasesAndSales purchases = new frmPurchasesAndSales();
            purchases.Show();
        }

        private void ventesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set value on transactionType static method
            transactionType = "VENTES";

            frmPurchasesAndSales sales = new frmPurchasesAndSales();
            sales.Show();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void linkLblSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Sets the link label to open the default email client with a new message
            var psi = new ProcessStartInfo
            {
                FileName = "mailto:eliane.perol@gmail.com?subject=Support%20Invoice%20Master",
                UseShellExecute = true // Execute the file using the shell
            };

            Process.Start(psi); // Start the process
        }
    }
}
