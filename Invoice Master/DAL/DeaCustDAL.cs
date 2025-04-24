using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_Master.BLL;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Invoice_Master.DAL
{
    internal class DeaCustDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {
            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            // DataTable to hold the data
            DataTable dt = new DataTable();

            try
            {
                // SQL query to select all data from the tbl_dea_cust table
                string sql = "SELECT * FROM tbl_dea_cust";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // SqlDataAdapter to fill the DataTable with the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open the connection to the database
                conn.Open();

                // Fill the DataTable with the data from the database
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the connection to the database
                conn.Close();
            }
            // Return the DataTable with the data
            return dt;
        }
        #endregion

        #region Insert Data into Database
        public bool Insert(DeaCustBLL dc)
        {
            // Checks if the data was inserted successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to insert data into the tbl_dea_cust table
                string sql = "INSERT INTO tbl_dea_cust " +
                    "(role, name, email, contact, address, added_date, added_by) " +
                    "VALUES (@role, @name, @email, @contact, @address, @added_date, @added_by)";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@role", dc.role);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

                // Open the connection to the database
                conn.Open();

                // Execute the SQL query and check if it was successful
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSuccess = true; // Data inserted successfully
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the connection to the database
                conn.Close();
            }
            return isSuccess; // Return whether the data was inserted successfully or not
        }
        #endregion

        #region Update Data in Database
        public bool Update(DeaCustBLL dc)
        {
            // Checks if the data was updated successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to update data in the tbl_dea_cust table
                string sql = "UPDATE tbl_dea_cust SET role=@role, name=@name," +
                    "email=@email, contact=@contact, address=@address," +
                    "added_date=@added_date, added_by=@added_by WHERE id=@id;";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@role", dc.role);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

                // Open the connection to the database
                conn.Open();
                // Execute the SQL query and check if it was successful
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSuccess = true; // Data updated successfully
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the connection to the database
                conn.Close();
            }
            return isSuccess; // Return whether the data was updated successfully or not
        }
        #endregion

        #region Delete Data from Database
        public bool Delete(DeaCustBLL dc)
        {
            // Checks if the data was deleted successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to delete data from the tbl_dea_cust table
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id;";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@id", dc.id);

                // Open the connection to the database
                conn.Open();

                // Execute the SQL query and check if it was successful
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSuccess = true; // Data deleted successfully
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close the connection to the database
                conn.Close();
            }
            return isSuccess; // Return whether the data was deleted successfully or not
        }
        #endregion

        #region Search User in Database usingKeywords
        public DataTable Search(string keywords)
        {
            // Connection to the database
            var dt = new DataTable();

            // DataTable to hold the data
            var conn = new SqlConnection(myconnstrng);

            // SQL query to search for dealers and customers in the tbl_dea_cust table
            var sql = @"SELECT * FROM tbl_dea_cust 
                WHERE CONVERT(varchar(50), id) LIKE @kw 
                OR role LIKE @kw OR name LIKE @kw or email LIKE @kw
                OR contact LIKE @kw OR address LIKE @kw;";

            try
            {
                // SqlCommand to execute the SQL query
                var cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@kw", "%" + keywords + "%");

                // SqlDataAdapter to fill the DataTable with the data
                var adapter = new SqlDataAdapter(cmd);

                // Open the connection to the database
                conn.Open();

                // Fill the DataTable with the data from the database
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                // Show an error message if there is a SQL exception
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            catch (Exception ex)
            {
                // Show an error message if there is a general exception
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // Close the connection to the database
                conn.Close();
            }
            // Return the DataTable with the data
            return dt;
        }
        #endregion

        #region Search Dealer or Customer for Transaction module

        public DeaCustBLL SearchDealerCustomerTransaction(string keywords)
        {
            DeaCustBLL dc = new DeaCustBLL();

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            // DataTable to hold the data
            DataTable dt = new DataTable();

            // SQL query to search for dealers and customers in the tbl_dea_cust table
            var sql = @"SELECT name, email, contact, address FROM tbl_dea_cust 
                WHERE CONVERT(varchar(50), id) LIKE @kw OR name LIKE @kw;";

            try
            {
                // SqlCommand to execute the SQL query
                var cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@kw", "%" + keywords + "%");

                // SqlDataAdapter to fill the DataTable with the data
                var adapter = new SqlDataAdapter(cmd);

                // Open the connection to the database
                conn.Open();

                // Fill the DataTable with the data from the database
                adapter.Fill(dt);


                // If there are values in the DataTable, they need to be savec in the DealerCustomer BLL
                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();

                }
            }
            catch (SqlException ex)
            {
                // Show an error message if there is a SQL exception
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            catch (Exception ex)
            {
                // Show an error message if there is a general exception
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // Close the connection to the database
                conn.Close();
            }
            // Return the DataTable with the data

            return dc;

        }

        #endregion

    }
}
