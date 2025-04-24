using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Invoice_Master.BLL;
using Invoice_Master.DAL;
using Invoice_Master.Properties;

namespace Invoice_Master.UI
{
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dal = new DeaCustDAL();
        UserDAL udal = new UserDAL();

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            // Display all users when the window loads
            DataTable dt = dal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            dc.role = cmbDeaCustRole.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            // Getting the logged in user info
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            dc.added_by = usr.id;

            // Inserting data into database
            bool success = dal.Insert(dc);

            // Determines which role to display in MessageBox
            string entite = dc.role == "Fournisseur" ? "Fournisseur" : "Client";

            // Checking if the data was inserted successfully
            if (success == true)
            {
                // Data inserted successfully
                MessageBox.Show($"{entite} créé avec succès !");

                // Clearing the fields after successful insertion
                clear();
            }
            else
            {
                // Data insertion failed
                MessageBox.Show($"Échec, le {entite.ToLower()} n'a pas été créé.");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void clear()
        {
            txtDeaCustID.Text = "";
            cmbDeaCustRole.SelectedIndex = -1;
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Getting the row index of the clicked row
            int rowIndex = e.RowIndex;

            //Setting the values of the selected row to the textboxes
            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCustRole.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            dc.id = Convert.ToInt32(txtDeaCustID.Text);
            dc.role = cmbDeaCustRole.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            // Getting the logged in user info
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            dc.added_by = usr.id;

            // Updating data in database
            bool success = dal.Update(dc);

            // Determines which role to display in MessageBox
            string entite = dc.role == "Fournisseur" ? "Fournisseur" : "Client";

            // Checking if the data was updated successfully
            if (success == true)
            {
                // Data updated successfully
                MessageBox.Show($"{entite} mis à jour avec succès !");

                // Clearing the fields after successful update
                clear();
            }
            else
            {
                // Data update failed
                MessageBox.Show($"Échec, le {entite.ToLower()} n'a pas été mis à jour.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            dc.id = Convert.ToInt32(txtDeaCustID.Text);

            // Deleting data from database
            bool success = dal.Delete(dc);

            // Determines which role to display in MessageBox
            string entite = dc.role == "Fournisseur" ? "Fournisseur" : "Client";

            // Checking if the data was deleted successfully
            if (success == true)
            {
                // Data deleted successfully
                MessageBox.Show($"{entite} supprimé avec succès !");

                // Clearing the fields after successful deletion
                clear();
            }
            else
            {
                // Data deletion failed
                MessageBox.Show($"Échec, le {entite.ToLower()} n'a pas été supprimé.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Getting the search text
            string keywords = txtSearch.Text;

            // Checking if the search text is not empty
            if (keywords != null)
            {
                // Searching the data in the database
                DataTable dt = dal.Search(keywords);

                // Setting the data source of the DataGridView to the searched data
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                // If search text is empty, show all data
                DataTable dt = dal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
