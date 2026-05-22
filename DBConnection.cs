
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    static class DBConnection
    {
 
        private static string connectionString =
            "Server=localhost;Database=frsdb;Integrated Security=True;";

        public static SqlConnection connection = new SqlConnection(connectionString);

        public static void Initialize()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed:\n" + ex.Message,
                                "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}