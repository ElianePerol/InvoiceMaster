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
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Open Login form when the admin dashboard is closed
            frmLogin login = new frmLogin();
            login.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
