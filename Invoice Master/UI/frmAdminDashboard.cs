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
            // code à exécuter au chargement du formulaire
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // si vous n’avez rien à dessiner, laissez vide
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // gestion du clic sur lblFooter
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            // gestion du clic éventuel sur lblUser
        }

        private void lblAppFName_Click(object sender, EventArgs e)
        {
            // gestion du clic sur INVOICE
        }

        private void lblAppLName_Click(object sender, EventArgs e)
        {
            // gestion du clic sur MASTER
        }

        private void lblSHead_Click(object sender, EventArgs e)
        {
            // gestion du clic sur le sous-titre
        }
    }
}

