namespace frs
{
    partial class ChangePasswordForm
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
            txtOldPassword = new TextBox();
            label2 = new Label();
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            btnUpdatePassword = new Button();
            label4 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 128);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 0;
            label1.Text = "Old Password";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(242, 128);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(147, 23);
            txtOldPassword.TabIndex = 1;
            txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 179);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(242, 179);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(147, 23);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 232);
            label3.Name = "label3";
            label3.Size = new Size(122, 19);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            label3.Click += label3_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(242, 232);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(147, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.AllowDrop = true;
            btnUpdatePassword.AutoEllipsis = true;
            btnUpdatePassword.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdatePassword.Cursor = Cursors.Hand;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.Location = new Point(203, 285);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(110, 41);
            btnUpdatePassword.TabIndex = 15;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(173, 22);
            label4.Name = "label4";
            label4.Size = new Size(158, 22);
            label4.TabIndex = 16;
            label4.Text = "Change Password";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(btnUpdatePassword);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtOldPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 344);
            panel1.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(242, 77);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(147, 23);
            txtUsername.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 81);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 17;
            label5.Text = "Username";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 347);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtOldPassword;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Button btnUpdatePassword;
        private Label label4;
        private Panel panel1;
        private TextBox txtUsername;
        private Label label5;
    }
}