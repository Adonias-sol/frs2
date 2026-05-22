namespace frs
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtPassport = new TextBox();
            label6 = new Label();
            txtUsername = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            lnkBackToLogin = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 23);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 105);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(135, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(144, 23);
            txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 176);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(135, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(144, 23);
            txtLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(322, 105);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 5;
            label4.Text = "Phone no.";
            label4.Click += label4_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(414, 105);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(144, 23);
            txtPhone.TabIndex = 6;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(321, 180);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 7;
            label5.Text = "Passport";
            label5.Click += label5_Click;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(414, 180);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(144, 23);
            txtPassport.TabIndex = 8;
            txtPassport.TextChanged += txtPassport_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 248);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 9;
            label6.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(135, 248);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(144, 23);
            txtUsername.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(322, 248);
            label7.Name = "label7";
            label7.Size = new Size(69, 19);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(414, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(144, 23);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(271, 318);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(83, 23);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Signup";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lnkBackToLogin
            // 
            lnkBackToLogin.ActiveLinkColor = SystemColors.MenuHighlight;
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.LinkColor = Color.White;
            lnkBackToLogin.Location = new Point(208, 367);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new Size(225, 15);
            lnkBackToLogin.TabIndex = 14;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Already have an account back to login ->";
            lnkBackToLogin.LinkClicked += lnkBackToLogin_LinkClicked;
            
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(617, 401);
            Controls.Add(lnkBackToLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(txtPassport);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flight Reservation System";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtPassport;
        private Label label6;
        private TextBox txtUsername;
        private Label label7;
        private TextBox txtPassword;
        private Button btnRegister;
        private LinkLabel lnkBackToLogin;
    }
}