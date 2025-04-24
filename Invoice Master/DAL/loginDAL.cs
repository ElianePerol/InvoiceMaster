using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.BLL;

namespace Invoice_Master.DAL
{
    internal class LoginDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(LoginBLL l)
        {
            bool isSuccess = false;

            // Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL query to select data from the tbl_users table
                string sql = "SELECT * FROM tbl_users WHERE " +
                    "username=@username " +
                    "AND password=@password " +
                    "AND role=@role";

                // SqlCommand to execute the SQL query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@role", l.role);

                // SqlDataAdapter to fill the DataTable with the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // DataTable to hold the data
                System.Data.DataTable dt = new System.Data.DataTable();

                // Fill the DataTable with the data from the database 
                adapter.Fill(dt);

                //Cheking if the DataTable has any rows
                if (dt.Rows.Count > 0)
                {
                    // Login sucess
                    isSuccess = true;
                }
                else
                {
                    // Login fail
                    isSuccess = false;
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
            // Return the success status
            return isSuccess;
        }
    }
}
