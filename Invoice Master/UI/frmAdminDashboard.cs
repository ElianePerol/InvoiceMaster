using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.UI;

namespace Invoice_Master
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAppFName_Click(object sender, EventArgs e)
        {
           
        }

        private void lblAppLName_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSHead_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Open Login form when the admin dashboard is closed
            frmLogin login = new frmLogin();
            login.Show();

            // Hide the current form
            this.Hide();
        }

        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            product.Show();
        }

        private void fournisseursEtClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust deaCust = new frmDeaCust();
            deaCust.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions transaction = new frmTransactions();
            transaction.Show();
        }

        private void inventairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }
    }
}
