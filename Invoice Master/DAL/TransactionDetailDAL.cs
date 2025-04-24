using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Invoice_Master.BLL;
using System.CodeDom.Compiler;

namespace Invoice_Master.DAL
{
    internal class TransactionDetailDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Transaction Detail Method
        public bool InsertTransactionDetail(TransactionDetailBLL td, out int transactionID)
        {
            // Checks if the data was inserted successfully
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Sets the out transactionID value to -1
            transactionID = -1;

            try
            {
                // SQL query to insert data into the tbl_transaction_detail table
                string sql = "INSERT INTO tbl_transaction_detail " +
                    "(product_id, rate, qty, total, dea_cust_id, added_date, added_by) " +
                    "VALUES (@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

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

            return isSuccess;
        }
        #endregion
    }
}
