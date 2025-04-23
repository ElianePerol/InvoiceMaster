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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Getting data from UI
            u.first_name = txtFirstName.Text;
            u.surname = txtSurname.Text;
            u.email = txtEmail.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.role = cmbUserRole.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1; // This should be the ID of the logged-in user

            // Inserting data into database
            bool success = dal.Insert(u);

            // Checking if the data was inserted successfully
            if (success == true)
            {
                // Data inserted successfully
                MessageBox.Show("Utilisateur créé avec succès !");

                // Clearing the fields after successful insertion
                clear();
            }
            else
            {
                // Data insertion failed
                MessageBox.Show("Échec, l'utilisateur n'a pas été créé.");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbUserRole.SelectedIndex = -1;

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Getting the row index of the clicked row
            int rowIndex = e.RowIndex;

            //Setting the values of the selected row to the textboxes
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbUserRole.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstName.Text;
            u.surname = txtSurname.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.role = cmbUserRole.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1; // This should be the ID of the logged-in user

            // Updating data in database
            bool success = dal.Update(u);

            // Checking if the data was updated successfully
            if (success == true)
            {
                // Data updated successfully
                MessageBox.Show("Utilisateur mis à jour avec succès !");

                // Clearing the fields after successful update
                clear();
            }
            else
            {
                // Data update failed
                MessageBox.Show("Échec, l'utilisateur n'a pas été mis à jour.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            u.id = Convert.ToInt32(txtUserID.Text);

            // Deleting data from database
            bool success = dal.Delete(u);

            // Checking if the data was deleted successfully
            if (success == true)
            {
                // Data deleted successfully
                MessageBox.Show("Utilisateur supprimé avec succès !");

                // Clearing the fields after successful deletion
                clear();
            }
            else
            {
                // Data deletion failed
                MessageBox.Show("Échec, l'utilisateur n'a pas été supprimé.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
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
                dgvUsers.DataSource = dt;
            }
            else
            {
                // If search text is empty, show all data
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }
    }
}
