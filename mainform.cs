using frs;
using System.Data.SqlClient;
namespace frs
{
    public partial class mainform : Form
    {

        public mainform()
        {
            InitializeComponent();
        }

        // Replace Form1_Load with this:
        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnection.Initialize();
            try
            {
                using (SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username = 'agent1'",
                    DBConnection.connection))
                {
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    // ✅ Only insert if agent doesn't exist — never overwrite
                    if (count == 0)
                    {
                        string hash = BCrypt.Net.BCrypt.EnhancedHashPassword("admin123");
                        using (SqlCommand insertCmd = new SqlCommand(
                            @"INSERT INTO Users 
                     (FirstName,LastName,Phone,Passport,Username,Password,Role)
                     VALUES ('Admin','Agent','0911000000','N/A','agent1',@password,'ServiceAgent')",
                            DBConnection.connection))
                        {
                            insertCmd.Parameters.AddWithValue("@password", hash);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Setup error: " + ex.Message); }
            DBConnection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernametxt_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxt_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxt.Text) ||
                string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                MessageBox.Show("Username and Password cannot be empty!");
                return;
            }


            var result = AuthService.Login(usernametxt.Text.Trim(), passwordtxt.Text);

            if (result.Success)
            {
                MessageBox.Show("Login Successful!");

                if (result.Role == "Passenger")
                {
                    PassengerDashboard p = new PassengerDashboard(result.UserID.Value);
                    p.Show();
                } 
                else if (result.Role == "ServiceAgent")
                {
                    AdminDashboard a = new AdminDashboard();
                    a.Show();
                }

                this.Hide();
            }
        }



        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.ShowDialog();
        
    }
    }

}
