using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    static class AuthService
    {
        public static (bool Success, Guid? UserID, string Role) Login(string username, string password)
        {
            Guid? userID = null;
            bool success = false;
            string role = "";

            DBConnection.Initialize();

            string sql = @"SELECT UserID, Password, Role 
                           FROM Users 
                           WHERE Username = @username";

            using (SqlCommand cmd = new SqlCommand(sql, DBConnection.connection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataReader ret = cmd.ExecuteReader();

                    if (!ret.HasRows)
                    {
                        ret.Close();
                        MessageBox.Show("Username not found.", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DBConnection.Close();
                        return (false, null, "");
                    }

                    ret.Read();

                    string storedHash = ret["Password"].ToString();
                    role = ret["Role"].ToString();

                    success = BCrypt.Net.BCrypt.EnhancedVerify(password, storedHash);

                    if (success)
                        userID = Guid.Parse(ret["UserID"].ToString());
                    else
                        MessageBox.Show("Wrong password.", "Login Failed",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    ret.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DATABASE ERROR:\n" + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }
            }

            DBConnection.Close();
            return (success, userID, role);
        }
    }
}