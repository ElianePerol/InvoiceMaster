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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.role = cmbUserRole.Text.Trim();

            // Checking the login credential
            bool success = dal.loginCheck(l);
            if (success == true)
            {
                // Login success
                MessageBox.Show("Connexion réussie");

                // Need to open respective form based on the user role
                switch (l.role)
                {
                    case "Administrateur":

                        // Display Admin dashboard
                        frmAdminDashboard admin = new frmAdminDashboard();
                        admin.Show();

                        // Hides the login form
                        this.Hide();
                        break;

                    case "Utilisateur":

                        //Display User Dashboard
                        frmUserDashboard user = new frmUserDashboard();
                        user.Show();

                        //Hides the login form
                        this.Hide();
                        break;

                    default:

                        // Display error message for unrecognized role
                        MessageBox.Show("Rôle d'utilisateur non reconnu");
                        break;
                }

            }
            else
            {
                // Login fail
                MessageBox.Show("Échec de connexion, réessayer");
            }
        }
    }
}
