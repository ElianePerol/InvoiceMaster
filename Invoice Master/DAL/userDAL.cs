using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.BLL;

namespace Invoice_Master.DAL
{
    internal class userDAL
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
                // SQL query to select all data from the tbl_users table
                string sql = "SELECT * FROM tbl_users";

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
        public bool Insert(userBLL u)
        {
            // Checks if the data was inserted successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to insert data into the tbl_users table
                string sql = "INSERT INTO tbl_users " +
                    "(first_name, surname, email, username, password, " +
                    "contact, address, role, added_date, added_by) " +
                    "VALUES (@first_name, @surname, @email, @username, @password, " +
                    "@contact, @address, @role, @added_date, @added_by)";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@surname", u.surname);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@role", u.role);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

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
        public bool Update(userBLL u)
        {
            // Checks if the data was updated successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to update data in the tbl_users table
                string sql = "UPDATE tbl_users SET first_name=@first_name, surname=@surname, " +
                    "email=@email, username=@username, password=@password, " +
                    "contact=@contact, address=@address, role=@role, added_date=@added_date, " +
                    "added_by=@added_by WHERE id=@id;";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@surname", u.surname);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@role", u.role);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);
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
        public bool Delete(userBLL u)
        {
            // Checks if the data was deleted successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to delete data from the tbl_users table
                string sql = "DELETE FROM tbl_users WHERE id=@id;";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@id", u.id);

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

            // SQL query to search for users in the tbl_users table
            var sql = @"SELECT * FROM tbl_users 
                WHERE CONVERT(varchar(50), id) LIKE @kw 
                OR first_name LIKE @kw 
                OR surname LIKE @kw OR username LIKE @kw;";

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
    }
}
