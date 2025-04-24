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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        CategoriesDAL cdal = new CategoriesDAL();
        ProductsBLL p = new ProductsBLL();
        ProductsDAL dal = new ProductsDAL();
        UserDAL udal = new UserDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // Create DataTable to hold the categories from the Database
            DataTable categoriesDT = cdal.Select();

            //Specify DataSource for Category ComboBox
            cmbCategory.DataSource = categoriesDT;

            //Specify Diplay Member and Value Member for ComboBox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            // The ComboBox is showing by default not prefilled
            cmbCategory.SelectedIndex = -1;

            // Display all users when the window loads
            DataTable dt = dal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            // Getting the logged in user info
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            p.added_by = usr.id;

            // Inserting data into database
            bool success = dal.Insert(p);

            // Checking if the data was inserted successfully
            if (success == true)
            {
                // Data inserted successfully
                MessageBox.Show("Produit créé avec succès !");

                // Clearing the fields after successful insertion
                clear();
            }
            else
            {
                // Data insertion failed
                MessageBox.Show("Échec, le produit n'a pas été créé.");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvProducts.DataSource = dt;
        }

        private void clear()
        {
            txtProductID.Text = "";
            txtName.Text = "";
            cmbCategory.SelectedIndex = -1;
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Getting the row index of the clicked row
            int rowIndex = e.RowIndex;

            //Setting the values of the selected row to the textboxes
            txtProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            p.id = Convert.ToInt32(txtProductID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            // Getting the logged in user info
            string loggedUser = frmLogin.loggedIn;
            UserBLL usr = udal.GetIDFromUsername(loggedUser);

            p.added_by = usr.id;

            // Updating data in database
            bool success = dal.Update(p);

            // Checking if the data was updated successfully
            if (success == true)
            {
                // Data updated successfully
                MessageBox.Show("Produit mis à jour avec succès !");

                // Clearing the fields after successful update
                clear();
            }
            else
            {
                // Data update failed
                MessageBox.Show("Échec, le produit n'a pas été mis à jour.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            p.id = Convert.ToInt32(txtProductID.Text);

            // Deleting data from database
            bool success = dal.Delete(p);

            // Checking if the data was deleted successfully
            if (success == true)
            {
                // Data deleted successfully
                MessageBox.Show("Produit supprimé avec succès !");

                // Clearing the fields after successful deletion
                clear();
            }
            else
            {
                // Data deletion failed
                MessageBox.Show("Échec, le produit n'a pas été supprimé.");
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvProducts.DataSource = dt;
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
                dgvProducts.DataSource = dt;
            }
            else
            {
                // If search text is empty, show all data
                DataTable dt = dal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
