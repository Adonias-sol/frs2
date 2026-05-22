using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New passwords do not match.", "Mismatch",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Too Short",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection.Initialize();
            try
            {
                // Step 1 — Find user by username
                Guid userId;
                string storedHash;

                using (SqlCommand getCmd = new SqlCommand(
                    "SELECT UserID, Password FROM Users WHERE Username = @username",
                    DBConnection.connection))
                {
                    getCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    SqlDataReader reader = getCmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Username not found.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DBConnection.Close();
                        return;
                    }

                    reader.Read();
                    userId = Guid.Parse(reader["UserID"].ToString());
                    storedHash = reader["Password"].ToString();
                    reader.Close();
                }

                // Step 2 — Verify old password
                bool isCorrect = BCrypt.Net.BCrypt.EnhancedVerify(txtOldPassword.Text, storedHash);
                if (!isCorrect)
                {
                    MessageBox.Show("Old password is incorrect.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DBConnection.Close();
                    return;
                }
                // Add this after the isCorrect check:
                if (txtOldPassword.Text == txtNewPassword.Text)
                {
                    MessageBox.Show("New password must be different from old password.",
                                    "Same Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DBConnection.Close();
                    return;
                }

                // Step 3 — Hash and save new password
                string newHash = BCrypt.Net.BCrypt.EnhancedHashPassword(txtNewPassword.Text);

                using (SqlCommand updateCmd = new SqlCommand(
                    "UPDATE Users SET Password = @password WHERE UserID = @userId",
                    DBConnection.connection))
                {
                    updateCmd.Parameters.AddWithValue("@password", newHash);
                    updateCmd.Parameters.AddWithValue("@userId", userId);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password changed successfully! Please login with your new password.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}