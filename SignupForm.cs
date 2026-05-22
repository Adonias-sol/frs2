using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e) { }
        private void txtPhone_TextChanged(object sender, EventArgs e) { }
        private void txtPassport_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Basic empty check
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassport.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Password length
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Weak Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Password must have at least one number and one letter
            bool hasLetter = false;
            bool hasDigit = false;
            foreach (char c in txtPassword.Text)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }
            if (!hasLetter || !hasDigit)
            {
                MessageBox.Show("Password must contain at least one letter and one number.",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Username minimum 4 chars no spaces
            if (txtUsername.Text.Trim().Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters.", "Invalid Username",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUsername.Text.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces.", "Invalid Username",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Ethiopian passport format — starts with EP followed by 7 digits
            string passport = txtPassport.Text.Trim().ToUpper();
            if (!passport.StartsWith("EP") || passport.Length != 9)
            {
                MessageBox.Show("Passport must be in Ethiopian format: EP followed by 7 digits.\nExample: EP1234567",
                                "Invalid Passport", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool passportValid = true;
            for (int i = 2; i < passport.Length; i++)
            {
                if (!char.IsDigit(passport[i]))
                {
                    passportValid = false;
                    break;
                }
            }
            if (!passportValid)
            {
                MessageBox.Show("Passport must be in Ethiopian format: EP followed by 7 digits.\nExample: EP1234567",
                                "Invalid Passport", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Phone must be numbers only and at least 9 digits
            string phone = txtPhone.Text.Trim();
            bool phoneValid = phone.Length >= 9;
            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && c != '+')
                {
                    phoneValid = false;
                    break;
                }
            }
            if (!phoneValid)
            {
                MessageBox.Show("Phone number must be at least 9 digits and contain only numbers.",
                                "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Name must be letters only
            foreach (char c in txtFirstName.Text.Trim())
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("First name must contain letters only.", "Invalid Name",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            foreach (char c in txtLastName.Text.Trim())
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Last name must contain letters only.", "Invalid Name",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Continue with DB registration...
            DBConnection.Initialize();
            try
            {
                using (SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username = @username",
                    DBConnection.connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already taken. Please choose another.",
                                        "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DBConnection.Close();
                        return;
                    }
                }

                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txtPassword.Text);

                using (SqlCommand insertCmd = new SqlCommand(
                    @"INSERT INTO Users 
             (FirstName, LastName, Phone, Passport, Username, Password, Role)
             VALUES 
             (@firstName, @lastName, @phone, @passport, @username, @password, 'Passenger')",
                    DBConnection.connection))
                {
                    insertCmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@passport", passport);
                    insertCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@password", hashedPassword);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Account created! Please login.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainform login = new mainform();
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBConnection.Close();
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainform login = new mainform();
            login.Show();
            this.Close();
        }
    }
}