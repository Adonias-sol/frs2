namespace frs
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernamelabel = new Label();
            passwordlabel = new Label();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            Loginlabel = new Label();
            Loginbutton = new Button();
            lnkCreateAccount = new LinkLabel();
            lnkChangePassword = new LinkLabel();
            SuspendLayout();
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.Location = new Point(76, 115);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(74, 19);
            usernamelabel.TabIndex = 0;
            usernamelabel.Text = "User name";
            usernamelabel.Click += usernametxt_Click;
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlabel.Location = new Point(76, 179);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(68, 19);
            passwordlabel.TabIndex = 1;
            passwordlabel.Text = "password";
            passwordlabel.Click += passwordtxt_Click;
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(198, 115);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(134, 23);
            usernametxt.TabIndex = 2;
            usernametxt.TextChanged += usernametxtbox_TextChanged;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(198, 179);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(134, 23);
            passwordtxt.TabIndex = 3;
            passwordtxt.UseSystemPasswordChar = true;
            passwordtxt.TextChanged += passwordtxtbox_TextChanged;
            // 
            // Loginlabel
            // 
            Loginlabel.AllowDrop = true;
            Loginlabel.AutoSize = true;
            Loginlabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginlabel.Location = new Point(209, 38);
            Loginlabel.Name = "Loginlabel";
            Loginlabel.Size = new Size(85, 22);
            Loginlabel.TabIndex = 4;
            Loginlabel.Text = "Welcome";
            Loginlabel.TextAlign = ContentAlignment.TopCenter;
            Loginlabel.Click += label1_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginbutton.Location = new Point(208, 243);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(102, 27);
            Loginbutton.TabIndex = 7;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.LinkColor = Color.White;
            lnkCreateAccount.Location = new Point(162, 319);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(191, 15);
            lnkCreateAccount.TabIndex = 8;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Don't have an account? Create one";
            lnkCreateAccount.TextAlign = ContentAlignment.MiddleCenter;
            lnkCreateAccount.LinkClicked += lnkCreateAccount_LinkClicked;
            // 
            // lnkChangePassword
            // 
            lnkChangePassword.ActiveLinkColor = Color.FromArgb(0, 0, 192);
            lnkChangePassword.AutoSize = true;
            lnkChangePassword.DisabledLinkColor = Color.FromArgb(0, 0, 192);
            lnkChangePassword.LinkColor = Color.White;
            lnkChangePassword.Location = new Point(209, 291);
            lnkChangePassword.Name = "lnkChangePassword";
            lnkChangePassword.Size = new Size(101, 15);
            lnkChangePassword.TabIndex = 9;
            lnkChangePassword.TabStop = true;
            lnkChangePassword.Text = "Change Password";
            lnkChangePassword.TextAlign = ContentAlignment.MiddleCenter;
            lnkChangePassword.LinkClicked += linkLabel1_LinkClicked;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(487, 352);
            Controls.Add(lnkChangePassword);
            Controls.Add(lnkCreateAccount);
            Controls.Add(Loginbutton);
            Controls.Add(Loginlabel);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(passwordlabel);
            Controls.Add(usernamelabel);
            Name = "mainform";
            Text = "Flight Reservation System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label usernamelabel;
        private Label passwordlabel;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Label Loginlabel;
        private Button button2;
        private Button Loginbutton;
        private LinkLabel lnkCreateAccount;
        private LinkLabel lnkChangePassword;
    }
}
