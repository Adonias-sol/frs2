namespace frs
{
    partial class PaymentForm
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
            panel1 = new Panel();
            txtAmount = new TextBox();
            txtSeatInfo = new TextBox();
            txtFlightInfo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbMethod = new ComboBox();
            btnConfirmPayment = new Button();
            btnDeletePassenger = new Button();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(txtSeatInfo);
            panel1.Controls.Add(txtFlightInfo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbMethod);
            panel1.Controls.Add(btnConfirmPayment);
            panel1.Controls.Add(btnDeletePassenger);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 320);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.ButtonFace;
            txtAmount.Location = new Point(127, 170);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(150, 23);
            txtAmount.TabIndex = 51;
            // 
            // txtSeatInfo
            // 
            txtSeatInfo.Location = new Point(127, 119);
            txtSeatInfo.Name = "txtSeatInfo";
            txtSeatInfo.ReadOnly = true;
            txtSeatInfo.Size = new Size(150, 23);
            txtSeatInfo.TabIndex = 50;
            // 
            // txtFlightInfo
            // 
            txtFlightInfo.Location = new Point(127, 72);
            txtFlightInfo.Name = "txtFlightInfo";
            txtFlightInfo.ReadOnly = true;
            txtFlightInfo.Size = new Size(150, 23);
            txtFlightInfo.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 170);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 48;
            label4.Text = "Amount";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 119);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 47;
            label3.Text = "Seat:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 72);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 46;
            label2.Text = "Flight:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 221);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 45;
            label1.Text = "Method";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbMethod
            // 
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card" });
            cmbMethod.Location = new Point(127, 217);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(150, 23);
            cmbMethod.TabIndex = 44;
            cmbMethod.SelectedIndexChanged += cmbMethod_SelectedIndexChanged;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.AllowDrop = true;
            btnConfirmPayment.AutoEllipsis = true;
            btnConfirmPayment.BackColor = Color.FromArgb(64, 64, 64);
            btnConfirmPayment.Cursor = Cursors.Hand;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(44, 280);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(117, 35);
            btnConfirmPayment.TabIndex = 41;
            btnConfirmPayment.Text = "Confirm Payment";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // btnDeletePassenger
            // 
            btnDeletePassenger.AllowDrop = true;
            btnDeletePassenger.AutoEllipsis = true;
            btnDeletePassenger.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletePassenger.Cursor = Cursors.Hand;
            btnDeletePassenger.FlatStyle = FlatStyle.Flat;
            btnDeletePassenger.ForeColor = Color.White;
            btnDeletePassenger.Location = new Point(207, 280);
            btnDeletePassenger.Name = "btnDeletePassenger";
            btnDeletePassenger.Size = new Size(106, 35);
            btnDeletePassenger.TabIndex = 40;
            btnDeletePassenger.Text = "Cancel Payment";
            btnDeletePassenger.UseVisualStyleBackColor = false;
            btnDeletePassenger.Click += btnCancelPayment_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(128, 128, 255);
            lblWelcome.Location = new Point(101, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(163, 23);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Complete Payment";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(401, 347);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblWelcome;
        private Button btnConfirmPayment;
        private Button btnDeletePassenger;
        private Label label1;
        private ComboBox cmbMethod;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAmount;
        private TextBox txtSeatInfo;
        private TextBox txtFlightInfo;
    }
}