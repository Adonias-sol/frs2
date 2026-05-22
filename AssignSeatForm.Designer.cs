namespace frs
{
    partial class AssignSeatForm
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
            cmbSeats = new ComboBox();
            btnAssignSeat = new Button();
            lblPassenger = new Label();
            btnCancelAssign = new Button();
            label1 = new Label();
            lblFlight = new Label();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmbSeats);
            panel1.Controls.Add(btnAssignSeat);
            panel1.Controls.Add(lblPassenger);
            panel1.Controls.Add(btnCancelAssign);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblFlight);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 322);
            panel1.TabIndex = 0;
            // 
            // cmbSeats
            // 
            cmbSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeats.FormattingEnabled = true;
            cmbSeats.Items.AddRange(new object[] { "Cash", "", "Credit Card", "", "Debit Card" });
            cmbSeats.Location = new Point(150, 206);
            cmbSeats.Name = "cmbSeats";
            cmbSeats.Size = new Size(150, 23);
            cmbSeats.TabIndex = 47;
            // 
            // btnAssignSeat
            // 
            btnAssignSeat.AllowDrop = true;
            btnAssignSeat.AutoEllipsis = true;
            btnAssignSeat.BackColor = Color.FromArgb(64, 64, 64);
            btnAssignSeat.Cursor = Cursors.Hand;
            btnAssignSeat.FlatStyle = FlatStyle.Flat;
            btnAssignSeat.ForeColor = Color.White;
            btnAssignSeat.Location = new Point(47, 275);
            btnAssignSeat.Name = "btnAssignSeat";
            btnAssignSeat.Size = new Size(87, 35);
            btnAssignSeat.TabIndex = 46;
            btnAssignSeat.Text = "Assign Seat";
            btnAssignSeat.UseVisualStyleBackColor = false;
            btnAssignSeat.Click += btnAssignSeat_Click;
            // 
            // lblPassenger
            // 
            lblPassenger.AutoSize = true;
            lblPassenger.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassenger.Location = new Point(47, 75);
            lblPassenger.Name = "lblPassenger";
            lblPassenger.Size = new Size(69, 19);
            lblPassenger.TabIndex = 44;
            lblPassenger.Text = "passenger";
            lblPassenger.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCancelAssign
            // 
            btnCancelAssign.AllowDrop = true;
            btnCancelAssign.AutoEllipsis = true;
            btnCancelAssign.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelAssign.Cursor = Cursors.Hand;
            btnCancelAssign.FlatStyle = FlatStyle.Flat;
            btnCancelAssign.ForeColor = Color.White;
            btnCancelAssign.Location = new Point(196, 275);
            btnCancelAssign.Name = "btnCancelAssign";
            btnCancelAssign.Size = new Size(87, 35);
            btnCancelAssign.TabIndex = 45;
            btnCancelAssign.Text = "Cancel";
            btnCancelAssign.UseVisualStyleBackColor = false;
            btnCancelAssign.Click += btnAssignSeat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 206);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 43;
            label1.Text = "Select Seat:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFlight
            // 
            lblFlight.AutoSize = true;
            lblFlight.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlight.Location = new Point(47, 139);
            lblFlight.Name = "lblFlight";
            lblFlight.Size = new Size(45, 19);
            lblFlight.TabIndex = 4;
            lblFlight.Text = "Flight:";
            lblFlight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(128, 128, 255);
            lblWelcome.Location = new Point(125, 11);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(102, 23);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Assign Seat";
            // 
            // AssignSeatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 347);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AssignSeatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Assign Seat";
            Load += AssignSeatForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblWelcome;
        private Label lblFlight;
        private Label lblPassenger;
        private Label label1;
        private ComboBox cmbSeats;
        private Button btnAssignSeat;
        private Button btnCancelAssign;
    }
}