using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_Master.UI;
using Microsoft.Data.SqlClient;

namespace Invoice_Master
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EnsureDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmLogin());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Erreur au démarrage",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        static void EnsureDatabase()
        {
            // Read the script
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "DBScript.sql");
            string sql = File.ReadAllText(path);

            // Cuts out the "GO" commands
            string[] batches = sql
                .Split(new[] { "\r\nGO", "\nGO", "\rGO" },
                       StringSplitOptions.RemoveEmptyEntries);

            // Execute the batches
            string masterConn = ConfigurationManager
                .ConnectionStrings["Master"].ConnectionString;
            using (var conn = new SqlConnection(masterConn))
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                conn.Open();
                foreach (var batch in batches)
                {
                    cmd.CommandText = batch;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
