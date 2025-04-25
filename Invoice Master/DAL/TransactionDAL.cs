using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Invoice_Master.BLL;
using System.Windows.Forms;
using System.Data;

namespace Invoice_Master.DAL
{
    internal class TransactionDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Transaction Method
        public bool InsertTransaction(TransactionsBLL t, out int transactionID)
        {
            // Checks if the data was inserted successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Sets the out transactionID value to -1
            transactionID = -1;

            try
            {
                // SQL query to insert data into the tbl_transactions table
                string sql = "INSERT INTO tbl_transactions " +
                    "(type, dea_cust_id, grand_total, transaction_date, vat, discount, added_by) " +
                    "VALUES (@type, @dea_cust_id, @grand_total, @transaction_date, @vat, @discount, @added_by);" +
                    "SELECT @@IDENTITY;";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
                cmd.Parameters.AddWithValue("@grand_total", t.grand_total);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@vat", t.vat);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                // Open the connection to the database
                conn.Open();

                // Execute the query
                object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    // Query executed successfully
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
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

            return isSuccess;
        }
        #endregion

        #region Display all the Transaction
        public DataTable DisplayAllTransactions()
        {
            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            // DataTable to hold the data
            DataTable dt = new DataTable();

            try
            {
                // SQL query to select all data from the tbl_products table
                string sql = "SELECT * FROM tbl_transactions";

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

        #region Display Transaction by Type
        public DataTable DisplayTransactionByType(string type)
        {
            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            // DataTable to hold the data
            DataTable dt = new DataTable();

            try
            {
                // SQL query to select all data from the tbl_products table
                string sql = "SELECT * FROM tbl_transactions WHERE type=@t";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@t", type);

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
    }
}
