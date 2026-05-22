namespace frs
{
    partial class PassengerDashboard
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
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblWelcome = new Label();
            tabTickets = new TabPage();
            btnPrintTicket = new Button();
            dgvMyTickets = new DataGridView();
            tabBookings = new TabPage();
            btnCancelBook = new Button();
            dgvMyBookings = new DataGridView();
            tabMain = new TabControl();
            tabFlights = new TabPage();
            dgvSeats = new DataGridView();
            btnBook = new Button();
            lblSeats = new Label();
            dgvFlights = new DataGridView();
            pnlSearch = new Panel();
            btnShowAll = new Button();
            btnSearch = new Button();
            txtTo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtFrom = new TextBox();
            l1 = new Label();
            pnlHeader.SuspendLayout();
            tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyTickets).BeginInit();
            tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyBookings).BeginInit();
            tabMain.SuspendLayout();
            tabFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(128, 128, 255);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(885, 56);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.AutoEllipsis = true;
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(806, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(79, 50);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(392, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(84, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // tabTickets
            // 
            tabTickets.Controls.Add(btnPrintTicket);
            tabTickets.Controls.Add(dgvMyTickets);
            tabTickets.Location = new Point(4, 24);
            tabTickets.Name = "tabTickets";
            tabTickets.Padding = new Padding(3);
            tabTickets.Size = new Size(877, 528);
            tabTickets.TabIndex = 2;
            tabTickets.Text = "My tickets";
            tabTickets.UseVisualStyleBackColor = true;
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.AllowDrop = true;
            btnPrintTicket.AutoEllipsis = true;
            btnPrintTicket.BackColor = Color.FromArgb(128, 128, 255);
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.ForeColor = Color.White;
            btnPrintTicket.Location = new Point(377, 401);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(104, 35);
            btnPrintTicket.TabIndex = 27;
            btnPrintTicket.Text = "Print Ticket ";
            btnPrintTicket.UseVisualStyleBackColor = false;
            btnPrintTicket.Click += btnPrintTicket_Click;
            // 
            // dgvMyTickets
            // 
            dgvMyTickets.AllowUserToAddRows = false;
            dgvMyTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyTickets.BackgroundColor = Color.White;
            dgvMyTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyTickets.Cursor = Cursors.Hand;
            dgvMyTickets.Location = new Point(8, 6);
            dgvMyTickets.Name = "dgvMyTickets";
            dgvMyTickets.ReadOnly = true;
            dgvMyTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyTickets.Size = new Size(860, 299);
            dgvMyTickets.TabIndex = 26;
            // 
            // tabBookings
            // 
            tabBookings.BorderStyle = BorderStyle.FixedSingle;
            tabBookings.Controls.Add(btnCancelBook);
            tabBookings.Controls.Add(dgvMyBookings);
            tabBookings.Location = new Point(4, 24);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3);
            tabBookings.Size = new Size(877, 528);
            tabBookings.TabIndex = 1;
            tabBookings.Text = "My Bookings";
            tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnCancelBook
            // 
            btnCancelBook.AllowDrop = true;
            btnCancelBook.AutoEllipsis = true;
            btnCancelBook.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelBook.Cursor = Cursors.Hand;
            btnCancelBook.FlatStyle = FlatStyle.Flat;
            btnCancelBook.ForeColor = Color.White;
            btnCancelBook.Location = new Point(383, 400);
            btnCancelBook.Name = "btnCancelBook";
            btnCancelBook.Size = new Size(115, 35);
            btnCancelBook.TabIndex = 39;
            btnCancelBook.Text = "Cancel Booking";
            btnCancelBook.UseVisualStyleBackColor = false;
            btnCancelBook.Click += btnCancelBooking_Click;
            // 
            // dgvMyBookings
            // 
            dgvMyBookings.AllowUserToAddRows = false;
            dgvMyBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyBookings.BackgroundColor = Color.White;
            dgvMyBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyBookings.Cursor = Cursors.Hand;
            dgvMyBookings.Location = new Point(-1, -1);
            dgvMyBookings.Name = "dgvMyBookings";
            dgvMyBookings.ReadOnly = true;
            dgvMyBookings.RowHeadersVisible = false;
            dgvMyBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyBookings.Size = new Size(874, 355);
            dgvMyBookings.TabIndex = 4;
            dgvMyBookings.CellContentClick += dgvMyTickets_CellContentClick;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabFlights);
            tabMain.Controls.Add(tabBookings);
            tabMain.Controls.Add(tabTickets);
            tabMain.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabMain.Location = new Point(0, 62);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(885, 556);
            tabMain.TabIndex = 10;
            tabMain.SelectedIndexChanged += TabMain_SelectedIndexChanged;
            // 
            // tabFlights
            // 
            tabFlights.Controls.Add(dgvSeats);
            tabFlights.Controls.Add(btnBook);
            tabFlights.Controls.Add(lblSeats);
            tabFlights.Controls.Add(dgvFlights);
            tabFlights.Controls.Add(pnlSearch);
            tabFlights.Location = new Point(4, 24);
            tabFlights.Name = "tabFlights";
            tabFlights.Padding = new Padding(3);
            tabFlights.Size = new Size(877, 528);
            tabFlights.TabIndex = 0;
            tabFlights.Text = "Search Flights";
            tabFlights.UseVisualStyleBackColor = true;
            tabFlights.Click += tabFlights_Click;
            // 
            // dgvSeats
            // 
            dgvSeats.AllowUserToAddRows = false;
            dgvSeats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSeats.BackgroundColor = Color.White;
            dgvSeats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeats.Cursor = Cursors.Hand;
            dgvSeats.Location = new Point(38, 305);
            dgvSeats.Name = "dgvSeats";
            dgvSeats.ReadOnly = true;
            dgvSeats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeats.Size = new Size(772, 176);
            dgvSeats.TabIndex = 19;
            // 
            // btnBook
            // 
            btnBook.AllowDrop = true;
            btnBook.AutoEllipsis = true;
            btnBook.BackColor = Color.FromArgb(0, 150, 0);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(388, 487);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(104, 35);
            btnBook.TabIndex = 18;
            btnBook.Text = "✈ Book Flight";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeats.ForeColor = Color.FromArgb(128, 128, 255);
            lblSeats.Location = new Point(20, 260);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(93, 15);
            lblSeats.TabIndex = 4;
            lblSeats.Text = "Available Seats:";
            lblSeats.TextAlign = ContentAlignment.MiddleRight;
            lblSeats.Click += lblSeats_Click;
            // 
            // dgvFlights
            // 
            dgvFlights.AllowUserToAddRows = false;
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFlights.BackgroundColor = Color.White;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Cursor = Cursors.Hand;
            dgvFlights.Location = new Point(38, 62);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.ReadOnly = true;
            dgvFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFlights.Size = new Size(772, 176);
            dgvFlights.TabIndex = 3;
            dgvFlights.CellContentClick += dgvFlights_CellContentClick;
            dgvFlights.SelectionChanged += DgvFlights_SelectionChanged;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.WhiteSmoke;
            pnlSearch.Controls.Add(btnShowAll);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtTo);
            pnlSearch.Controls.Add(label3);
            pnlSearch.Controls.Add(label2);
            pnlSearch.Controls.Add(txtFrom);
            pnlSearch.Controls.Add(l1);
            pnlSearch.Location = new Point(0, 6);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(876, 50);
            pnlSearch.TabIndex = 2;
            // 
            // btnShowAll
            // 
            btnShowAll.AllowDrop = true;
            btnShowAll.AutoEllipsis = true;
            btnShowAll.BackColor = Color.FromArgb(128, 128, 255);
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Location = new Point(745, 1);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 35);
            btnShowAll.TabIndex = 17;
            btnShowAll.Text = "All Flights";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.AllowDrop = true;
            btnSearch.AutoEllipsis = true;
            btnSearch.BackColor = Color.FromArgb(128, 128, 255);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(607, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTo
            // 
            txtTo.Cursor = Cursors.Hand;
            txtTo.Location = new Point(388, 15);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(150, 22);
            txtTo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 15);
            label3.Name = "label3";
            label3.Size = new Size(25, 19);
            label3.TabIndex = 7;
            label3.Text = "To";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 3;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFrom
            // 
            txtFrom.Cursor = Cursors.Hand;
            txtFrom.Location = new Point(90, 15);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(150, 22);
            txtFrom.TabIndex = 2;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l1.Location = new Point(20, 15);
            l1.Name = "l1";
            l1.Size = new Size(45, 19);
            l1.TabIndex = 1;
            l1.Text = "From:";
            l1.TextAlign = ContentAlignment.MiddleRight;
            l1.Click += l1_Click;
            // 
            // PassengerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 609);
            Controls.Add(tabMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PassengerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flight Reservation System";
            Load += PassengerDashboard_Load_1;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyTickets).EndInit();
            tabBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyBookings).EndInit();
            tabMain.ResumeLayout(false);
            tabFlights.ResumeLayout(false);
            tabFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeats).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblWelcome;
        private Button btnLogout;
        private TabPage tabTickets;
        private DataGridView dgvMyTickets;
        private TabPage tabBookings;
        private DataGridView dgvMyBookings;
        private TabControl tabMain;
        private TabPage tabFlights;
        private DataGridView dgvFlights;
        private Panel pnlSearch;
        private TextBox txtTo;
        private Label label3;
        private Label label2;
        private TextBox txtFrom;
        private Label l1;
        private Button btnShowAll;
        private Button btnSearch;
        private Label lblSeats;
        private Button btnBook;
        private Button btnCancelBook;
        private Button btnPrintTicket;
        private DataGridView dgvSeats;
    }
}