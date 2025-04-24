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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        CategoriesBLL c = new CategoriesBLL();
        CategoriesDAL dal = new CategoriesDAL();
        UserDAL udal = new UserDAL();

        private void frmCategories_Load(object sender, EventArgs e)
        {
            // Display all users when the window loads
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            // Getting the logged in user info
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            c.added_by = usr.id;

            // Inserting data into database
            bool success = dal.Insert(c);

            // Checking if the data was inserted successfully
            if (success == true)
            {
                // Data inserted successfully
                MessageBox.Show("Catégorie créée avec succès !");

                // Clearing the fields after successful insertion
                clear();
            }
            else
            {
                // Data insertion failed
                MessageBox.Show("Échec, la catégorie n'a pas été créée.");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }
       
        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Getting the row index of the clicked row
            int rowIndex = e.RowIndex;

            //Setting the values of the selected row to the textboxes
            txtCategoryID.Text = dgvCategories.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            c.id = Convert.ToInt32(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            // Getting the logged in user info
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            c.added_by = usr.id;

            // Updating data in database
            bool success = dal.Update(c);

            // Checking if the data was updated successfully
            if (success == true)
            {
                // Data updated successfully
                MessageBox.Show("Catégorie mise à jour avec succès !");

                // Clearing the fields after successful update
                clear();
            }
            else
            {
                // Data update failed
                MessageBox.Show("Échec, la catégorie n'a pas été mise à jour.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            c.id = Convert.ToInt32(txtCategoryID.Text);

            // Deleting data from database
            bool success = dal.Delete(c);

            // Checking if the data was deleted successfully
            if (success == true)
            {
                // Data deleted successfully
                MessageBox.Show("Catégorie supprimée avec succès !");

                // Clearing the fields after successful deletion
                clear();
            }
            else
            {
                // Data deletion failed
                MessageBox.Show("Échec, la catégorie n'a pas été supprimée.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
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
                dgvCategories.DataSource = dt;
            }
            else
            {
                // If search text is empty, show all data
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }

        private void lblFirstName_Click(object sender, EventArgs e) { }
    }

}