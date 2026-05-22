namespace frs
{
    partial class AdminDashboard
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
            lblTitle = new Label();
            tabMain = new TabControl();
            tabFlights = new TabPage();
            dgvFlights = new DataGridView();
            pnlFlightFields = new Panel();
            btnClearFlight = new Button();
            btnDeleteFlight = new Button();
            btnUpdateFlight = new Button();
            btnSaveFlight = new Button();
            cmbAircraft = new ComboBox();
            label5 = new Label();
            txtTime = new TextBox();
            label4 = new Label();
            txtDate = new TextBox();
            label3 = new Label();
            txtDestination = new TextBox();
            label1 = new Label();
            txtOrigin = new TextBox();
            label2 = new Label();
            txtFlightNumber = new TextBox();
            l1 = new Label();
            tabBookings = new TabPage();
            btnPrintTicket = new Button();
            btnAssignSeat = new Button();
            lblBookingCount = new Label();
            pnlBookingFilter = new Panel();
            btnShowAllBookings = new Button();
            btnSearchBooking = new Button();
            txtSearchFlight = new TextBox();
            label7 = new Label();
            txtSearchPassenger = new TextBox();
            label6 = new Label();
            btnCancelBooking = new Button();
            dgvBookings = new DataGridView();
            tabPassengers = new TabPage();
            dgvPassengers = new DataGridView();
            pnlPassengerFields = new Panel();
            btnClearPassenger = new Button();
            btnDeletePassenger = new Button();
            txtPPassword = new TextBox();
            txtPUsername = new TextBox();
            label13 = new Label();
            label9 = new Label();
            txtPFirstName = new TextBox();
            label12 = new Label();
            label8 = new Label();
            txtPLastName = new TextBox();
            txtPPassport = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtPPhone = new TextBox();
            tabAircraft = new TabPage();
            dgvAircraft = new DataGridView();
            pnlAircraftFields = new Panel();
            btnClearAircraft = new Button();
            button1 = new Button();
            btnSaveAircraft = new Button();
            txtAircraftSeats = new TextBox();
            label15 = new Label();
            txtAircraftModel = new TextBox();
            label14 = new Label();
            tabSeats = new TabPage();
            btnResetSeat = new Button();
            dgvSeats = new DataGridView();
            pnlSeatFilter = new Panel();
            cmbFlightFilter = new ComboBox();
            btnShowAllSeats = new Button();
            btnLoadSeats = new Button();
            textBox1 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            tabWalkIn = new TabPage();
            btnWalkInBook = new Button();
            pnlWalkInInfo = new Panel();
            txtWalkInPhone = new TextBox();
            label21 = new Label();
            txtWalkInFirstName = new TextBox();
            label18 = new Label();
            label20 = new Label();
            txtWalkInLastName = new TextBox();
            txtWalkInPassport = new TextBox();
            label19 = new Label();
            pnlWalkIn = new Panel();
            btnLoadWalkInSeats = new Button();
            cmbWalkInSeat = new ComboBox();
            cmbWalkInPassenger = new ComboBox();
            cmbWalkInFlight = new ComboBox();
            l7 = new Label();
            l5 = new Label();
            l6 = new Label();
            btnLogout = new Button();
            tabMain.SuspendLayout();
            tabFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            pnlFlightFields.SuspendLayout();
            tabBookings.SuspendLayout();
            pnlBookingFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPassengers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).BeginInit();
            pnlPassengerFields.SuspendLayout();
            tabAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAircraft).BeginInit();
            pnlAircraftFields.SuspendLayout();
            tabSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeats).BeginInit();
            pnlSeatFilter.SuspendLayout();
            tabWalkIn.SuspendLayout();
            pnlWalkInInfo.SuspendLayout();
            pnlWalkIn.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(355, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 24);
            lblTitle.TabIndex = 0;
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabFlights);
            tabMain.Controls.Add(tabBookings);
            tabMain.Controls.Add(tabPassengers);
            tabMain.Controls.Add(tabAircraft);
            tabMain.Controls.Add(tabSeats);
            tabMain.Controls.Add(tabWalkIn);
            tabMain.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabMain.Location = new Point(-2, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(883, 560);
            tabMain.TabIndex = 9;
            tabMain.SelectedIndexChanged += TabMain_SelectedIndexChanged;
            // 
            // tabFlights
            // 
            tabFlights.Controls.Add(dgvFlights);
            tabFlights.Controls.Add(pnlFlightFields);
            tabFlights.Location = new Point(4, 24);
            tabFlights.Name = "tabFlights";
            tabFlights.Padding = new Padding(3);
            tabFlights.Size = new Size(875, 532);
            tabFlights.TabIndex = 0;
            tabFlights.Text = "Flights";
            tabFlights.UseVisualStyleBackColor = true;
            tabFlights.Click += tabPage1_Click;
            // 
            // dgvFlights
            // 
            dgvFlights.AllowUserToAddRows = false;
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFlights.BackgroundColor = Color.White;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Cursor = Cursors.Hand;
            dgvFlights.Location = new Point(0, 241);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.ReadOnly = true;
            dgvFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFlights.Size = new Size(876, 281);
            dgvFlights.TabIndex = 3;
            dgvFlights.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnlFlightFields
            // 
            pnlFlightFields.BackColor = Color.WhiteSmoke;
            pnlFlightFields.Controls.Add(btnClearFlight);
            pnlFlightFields.Controls.Add(btnDeleteFlight);
            pnlFlightFields.Controls.Add(btnUpdateFlight);
            pnlFlightFields.Controls.Add(btnSaveFlight);
            pnlFlightFields.Controls.Add(cmbAircraft);
            pnlFlightFields.Controls.Add(label5);
            pnlFlightFields.Controls.Add(txtTime);
            pnlFlightFields.Controls.Add(label4);
            pnlFlightFields.Controls.Add(txtDate);
            pnlFlightFields.Controls.Add(label3);
            pnlFlightFields.Controls.Add(txtDestination);
            pnlFlightFields.Controls.Add(label1);
            pnlFlightFields.Controls.Add(txtOrigin);
            pnlFlightFields.Controls.Add(label2);
            pnlFlightFields.Controls.Add(txtFlightNumber);
            pnlFlightFields.Controls.Add(l1);
            pnlFlightFields.Location = new Point(0, 6);
            pnlFlightFields.Name = "pnlFlightFields";
            pnlFlightFields.Size = new Size(876, 220);
            pnlFlightFields.TabIndex = 2;
            pnlFlightFields.Paint += pnlFlightFields_Paint_1;
            // 
            // btnClearFlight
            // 
            btnClearFlight.AllowDrop = true;
            btnClearFlight.AutoEllipsis = true;
            btnClearFlight.BackColor = Color.FromArgb(64, 64, 64);
            btnClearFlight.Cursor = Cursors.Hand;
            btnClearFlight.FlatStyle = FlatStyle.Flat;
            btnClearFlight.ForeColor = Color.White;
            btnClearFlight.Location = new Point(455, 184);
            btnClearFlight.Name = "btnClearFlight";
            btnClearFlight.Size = new Size(100, 35);
            btnClearFlight.TabIndex = 16;
            btnClearFlight.Text = "Clear Flight";
            btnClearFlight.UseVisualStyleBackColor = false;
            btnClearFlight.Click += btnClearFlight_Click;
            // 
            // btnDeleteFlight
            // 
            btnDeleteFlight.AllowDrop = true;
            btnDeleteFlight.AutoEllipsis = true;
            btnDeleteFlight.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteFlight.Cursor = Cursors.Hand;
            btnDeleteFlight.FlatStyle = FlatStyle.Flat;
            btnDeleteFlight.ForeColor = Color.White;
            btnDeleteFlight.Location = new Point(303, 184);
            btnDeleteFlight.Name = "btnDeleteFlight";
            btnDeleteFlight.Size = new Size(100, 35);
            btnDeleteFlight.TabIndex = 15;
            btnDeleteFlight.Text = "Delete Flight";
            btnDeleteFlight.UseVisualStyleBackColor = false;
            btnDeleteFlight.Click += btnDeleteFlight_Click;
            // 
            // btnUpdateFlight
            // 
            btnUpdateFlight.AllowDrop = true;
            btnUpdateFlight.AutoEllipsis = true;
            btnUpdateFlight.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdateFlight.Cursor = Cursors.Hand;
            btnUpdateFlight.FlatStyle = FlatStyle.Flat;
            btnUpdateFlight.ForeColor = Color.White;
            btnUpdateFlight.Location = new Point(158, 184);
            btnUpdateFlight.Name = "btnUpdateFlight";
            btnUpdateFlight.Size = new Size(100, 35);
            btnUpdateFlight.TabIndex = 14;
            btnUpdateFlight.Text = "Update Flight";
            btnUpdateFlight.UseVisualStyleBackColor = false;
            btnUpdateFlight.Click += btnUpdateFlight_Click;
            // 
            // btnSaveFlight
            // 
            btnSaveFlight.AllowDrop = true;
            btnSaveFlight.AutoEllipsis = true;
            btnSaveFlight.BackColor = Color.FromArgb(0, 150, 0);
            btnSaveFlight.FlatStyle = FlatStyle.Flat;
            btnSaveFlight.ForeColor = Color.White;
            btnSaveFlight.Location = new Point(20, 184);
            btnSaveFlight.Name = "btnSaveFlight";
            btnSaveFlight.Size = new Size(100, 35);
            btnSaveFlight.TabIndex = 13;
            btnSaveFlight.Text = "Save Flight";
            btnSaveFlight.UseVisualStyleBackColor = false;
            btnSaveFlight.Click += btnSaveFlight_Click;
            // 
            // cmbAircraft
            // 
            cmbAircraft.Cursor = Cursors.Hand;
            cmbAircraft.FormattingEnabled = true;
            cmbAircraft.Location = new Point(464, 127);
            cmbAircraft.Name = "cmbAircraft";
            cmbAircraft.Size = new Size(150, 23);
            cmbAircraft.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(401, 127);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 11;
            label5.Text = "Aircraft";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTime
            // 
            txtTime.Cursor = Cursors.Hand;
            txtTime.Location = new Point(464, 75);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(150, 22);
            txtTime.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 75);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 9;
            label4.Text = "Time";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDate
            // 
            txtDate.Cursor = Cursors.Hand;
            txtDate.Location = new Point(464, 28);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(150, 22);
            txtDate.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(401, 28);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 7;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDestination
            // 
            txtDestination.AllowDrop = true;
            txtDestination.Cursor = Cursors.Hand;
            txtDestination.Location = new Point(138, 127);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(150, 22);
            txtDestination.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 127);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 5;
            label1.Text = "Destination";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtOrigin
            // 
            txtOrigin.Cursor = Cursors.Hand;
            txtOrigin.Location = new Point(138, 72);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(150, 22);
            txtOrigin.TabIndex = 4;
            txtOrigin.TextChanged += txtOrigin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 3;
            label2.Text = "Origin";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click_1;
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Cursor = Cursors.Hand;
            txtFlightNumber.Location = new Point(138, 25);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(150, 22);
            txtFlightNumber.TabIndex = 2;
            txtFlightNumber.TextChanged += textBox1_TextChanged;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l1.Location = new Point(20, 25);
            l1.Name = "l1";
            l1.Size = new Size(96, 19);
            l1.TabIndex = 1;
            l1.Text = "Flight Number";
            l1.TextAlign = ContentAlignment.MiddleRight;
            l1.Click += txtFlightNumber_Click;
            // 
            // tabBookings
            // 
            tabBookings.BorderStyle = BorderStyle.FixedSingle;
            tabBookings.Controls.Add(btnPrintTicket);
            tabBookings.Controls.Add(btnAssignSeat);
            tabBookings.Controls.Add(lblBookingCount);
            tabBookings.Controls.Add(pnlBookingFilter);
            tabBookings.Controls.Add(btnCancelBooking);
            tabBookings.Controls.Add(dgvBookings);
            tabBookings.Location = new Point(4, 24);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3);
            tabBookings.Size = new Size(875, 532);
            tabBookings.TabIndex = 1;
            tabBookings.Text = "Bookings";
            tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.AllowDrop = true;
            btnPrintTicket.AutoEllipsis = true;
            btnPrintTicket.BackColor = Color.FromArgb(192, 192, 0);
            btnPrintTicket.Cursor = Cursors.Hand;
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.ForeColor = Color.White;
            btnPrintTicket.Location = new Point(377, 489);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(106, 35);
            btnPrintTicket.TabIndex = 16;
            btnPrintTicket.Text = "Print Ticket";
            btnPrintTicket.UseVisualStyleBackColor = false;
            btnPrintTicket.Click += btnPrintTicket_Click;
            // 
            // btnAssignSeat
            // 
            btnAssignSeat.AllowDrop = true;
            btnAssignSeat.AutoEllipsis = true;
            btnAssignSeat.BackColor = Color.FromArgb(128, 128, 255);
            btnAssignSeat.Cursor = Cursors.Hand;
            btnAssignSeat.FlatStyle = FlatStyle.Flat;
            btnAssignSeat.ForeColor = Color.White;
            btnAssignSeat.Location = new Point(231, 489);
            btnAssignSeat.Name = "btnAssignSeat";
            btnAssignSeat.Size = new Size(105, 35);
            btnAssignSeat.TabIndex = 15;
            btnAssignSeat.Text = "Assign Seat";
            btnAssignSeat.UseVisualStyleBackColor = false;
            btnAssignSeat.Click += btnAssignSeat_Click;
            // 
            // lblBookingCount
            // 
            lblBookingCount.AutoSize = true;
            lblBookingCount.Location = new Point(6, 77);
            lblBookingCount.Name = "lblBookingCount";
            lblBookingCount.Size = new Size(100, 15);
            lblBookingCount.TabIndex = 7;
            lblBookingCount.Text = "Total Bookings: 0";
            lblBookingCount.Click += lblBookingCount_Click;
            // 
            // pnlBookingFilter
            // 
            pnlBookingFilter.BackColor = Color.WhiteSmoke;
            pnlBookingFilter.Controls.Add(btnShowAllBookings);
            pnlBookingFilter.Controls.Add(btnSearchBooking);
            pnlBookingFilter.Controls.Add(txtSearchFlight);
            pnlBookingFilter.Controls.Add(label7);
            pnlBookingFilter.Controls.Add(txtSearchPassenger);
            pnlBookingFilter.Controls.Add(label6);
            pnlBookingFilter.Location = new Point(3, 6);
            pnlBookingFilter.Name = "pnlBookingFilter";
            pnlBookingFilter.Size = new Size(873, 55);
            pnlBookingFilter.TabIndex = 6;
            // 
            // btnShowAllBookings
            // 
            btnShowAllBookings.AllowDrop = true;
            btnShowAllBookings.AutoEllipsis = true;
            btnShowAllBookings.BackColor = Color.FromArgb(128, 128, 255);
            btnShowAllBookings.FlatAppearance.BorderSize = 0;
            btnShowAllBookings.FlatStyle = FlatStyle.Flat;
            btnShowAllBookings.ForeColor = Color.White;
            btnShowAllBookings.Location = new Point(745, 10);
            btnShowAllBookings.Name = "btnShowAllBookings";
            btnShowAllBookings.Size = new Size(100, 35);
            btnShowAllBookings.TabIndex = 15;
            btnShowAllBookings.Text = "Show All";
            btnShowAllBookings.UseVisualStyleBackColor = false;
            btnShowAllBookings.Click += btnShowAllBookings_Click;
            // 
            // btnSearchBooking
            // 
            btnSearchBooking.AllowDrop = true;
            btnSearchBooking.AutoEllipsis = true;
            btnSearchBooking.BackColor = Color.FromArgb(128, 64, 0);
            btnSearchBooking.FlatAppearance.BorderSize = 0;
            btnSearchBooking.FlatStyle = FlatStyle.Flat;
            btnSearchBooking.ForeColor = Color.White;
            btnSearchBooking.Location = new Point(607, 12);
            btnSearchBooking.Name = "btnSearchBooking";
            btnSearchBooking.Size = new Size(100, 35);
            btnSearchBooking.TabIndex = 14;
            btnSearchBooking.Text = "🔍 Search";
            btnSearchBooking.UseVisualStyleBackColor = false;
            btnSearchBooking.Click += btnSearchBooking_Click;
            // 
            // txtSearchFlight
            // 
            txtSearchFlight.Cursor = Cursors.Hand;
            txtSearchFlight.Location = new Point(395, 19);
            txtSearchFlight.Name = "txtSearchFlight";
            txtSearchFlight.Size = new Size(150, 22);
            txtSearchFlight.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.SizeAll;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(304, 19);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 9;
            label7.Text = "Flight No:";
            // 
            // txtSearchPassenger
            // 
            txtSearchPassenger.Cursor = Cursors.Hand;
            txtSearchPassenger.Location = new Point(111, 19);
            txtSearchPassenger.Name = "txtSearchPassenger";
            txtSearchPassenger.Size = new Size(150, 22);
            txtSearchPassenger.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.SizeAll;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 19);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 7;
            label6.Text = "Passenger:";
            label6.Click += label6_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.Location = new Point(527, 489);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(111, 35);
            btnCancelBooking.TabIndex = 5;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Cursor = Cursors.Hand;
            dgvBookings.Location = new Point(6, 104);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(842, 367);
            dgvBookings.TabIndex = 4;
            // 
            // tabPassengers
            // 
            tabPassengers.Controls.Add(dgvPassengers);
            tabPassengers.Controls.Add(pnlPassengerFields);
            tabPassengers.Location = new Point(4, 24);
            tabPassengers.Name = "tabPassengers";
            tabPassengers.Padding = new Padding(3);
            tabPassengers.Size = new Size(875, 532);
            tabPassengers.TabIndex = 2;
            tabPassengers.Text = "Passengers";
            tabPassengers.UseVisualStyleBackColor = true;
            tabPassengers.Click += tabPassengers_Click;
            // 
            // dgvPassengers
            // 
            dgvPassengers.AllowUserToAddRows = false;
            dgvPassengers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPassengers.BackgroundColor = Color.White;
            dgvPassengers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassengers.Cursor = Cursors.Hand;
            dgvPassengers.Location = new Point(18, 202);
            dgvPassengers.Name = "dgvPassengers";
            dgvPassengers.ReadOnly = true;
            dgvPassengers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPassengers.Size = new Size(836, 309);
            dgvPassengers.TabIndex = 26;
            // 
            // pnlPassengerFields
            // 
            pnlPassengerFields.BackColor = Color.WhiteSmoke;
            pnlPassengerFields.BorderStyle = BorderStyle.FixedSingle;
            pnlPassengerFields.Controls.Add(btnClearPassenger);
            pnlPassengerFields.Controls.Add(btnDeletePassenger);
            pnlPassengerFields.Controls.Add(txtPPassword);
            pnlPassengerFields.Controls.Add(txtPUsername);
            pnlPassengerFields.Controls.Add(label13);
            pnlPassengerFields.Controls.Add(label9);
            pnlPassengerFields.Controls.Add(txtPFirstName);
            pnlPassengerFields.Controls.Add(label12);
            pnlPassengerFields.Controls.Add(label8);
            pnlPassengerFields.Controls.Add(txtPLastName);
            pnlPassengerFields.Controls.Add(txtPPassport);
            pnlPassengerFields.Controls.Add(label11);
            pnlPassengerFields.Controls.Add(label10);
            pnlPassengerFields.Controls.Add(txtPPhone);
            pnlPassengerFields.Location = new Point(0, 3);
            pnlPassengerFields.Name = "pnlPassengerFields";
            pnlPassengerFields.Size = new Size(876, 180);
            pnlPassengerFields.TabIndex = 25;
            pnlPassengerFields.Paint += pnlPassengerFields_Paint;
            // 
            // btnClearPassenger
            // 
            btnClearPassenger.AllowDrop = true;
            btnClearPassenger.AutoEllipsis = true;
            btnClearPassenger.BackColor = Color.FromArgb(64, 64, 64);
            btnClearPassenger.Cursor = Cursors.Hand;
            btnClearPassenger.FlatStyle = FlatStyle.Flat;
            btnClearPassenger.ForeColor = Color.White;
            btnClearPassenger.Location = new Point(453, 122);
            btnClearPassenger.Name = "btnClearPassenger";
            btnClearPassenger.Size = new Size(115, 35);
            btnClearPassenger.TabIndex = 39;
            btnClearPassenger.Text = "Clear Passenger";
            btnClearPassenger.UseVisualStyleBackColor = false;
            btnClearPassenger.Click += btnClearPassenger_Click;
            // 
            // btnDeletePassenger
            // 
            btnDeletePassenger.AllowDrop = true;
            btnDeletePassenger.AutoEllipsis = true;
            btnDeletePassenger.BackColor = Color.FromArgb(192, 0, 0);
            btnDeletePassenger.Cursor = Cursors.Hand;
            btnDeletePassenger.FlatStyle = FlatStyle.Flat;
            btnDeletePassenger.ForeColor = Color.White;
            btnDeletePassenger.Location = new Point(297, 122);
            btnDeletePassenger.Name = "btnDeletePassenger";
            btnDeletePassenger.Size = new Size(115, 35);
            btnDeletePassenger.TabIndex = 38;
            btnDeletePassenger.Text = "Delete Passenger";
            btnDeletePassenger.UseVisualStyleBackColor = false;
            btnDeletePassenger.Click += btnDeletePassenger_Click;
            // 
            // txtPPassword
            // 
            txtPPassword.BackColor = Color.White;
            txtPPassword.Location = new Point(662, 17);
            txtPPassword.Name = "txtPPassword";
            txtPPassword.ReadOnly = true;
            txtPPassword.Size = new Size(144, 22);
            txtPPassword.TabIndex = 37;
            txtPPassword.UseSystemPasswordChar = true;
            // 
            // txtPUsername
            // 
            txtPUsername.BackColor = Color.White;
            txtPUsername.Location = new Point(662, 60);
            txtPUsername.Name = "txtPUsername";
            txtPUsername.ReadOnly = true;
            txtPUsername.Size = new Size(144, 22);
            txtPUsername.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 14);
            label13.Name = "label13";
            label13.Size = new Size(77, 19);
            label13.TabIndex = 26;
            label13.Text = "First Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(570, 60);
            label9.Name = "label9";
            label9.Size = new Size(70, 19);
            label9.TabIndex = 34;
            label9.Text = "Username";
            // 
            // txtPFirstName
            // 
            txtPFirstName.BackColor = Color.White;
            txtPFirstName.Location = new Point(110, 14);
            txtPFirstName.Name = "txtPFirstName";
            txtPFirstName.ReadOnly = true;
            txtPFirstName.Size = new Size(144, 22);
            txtPFirstName.TabIndex = 27;
            txtPFirstName.TextChanged += txtPFirstName_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 60);
            label12.Name = "label12";
            label12.Size = new Size(76, 19);
            label12.TabIndex = 28;
            label12.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(570, 17);
            label8.Name = "label8";
            label8.Size = new Size(69, 19);
            label8.TabIndex = 36;
            label8.Text = "Password";
            // 
            // txtPLastName
            // 
            txtPLastName.BackColor = Color.White;
            txtPLastName.Location = new Point(111, 60);
            txtPLastName.Name = "txtPLastName";
            txtPLastName.ReadOnly = true;
            txtPLastName.Size = new Size(144, 22);
            txtPLastName.TabIndex = 29;
            // 
            // txtPPassport
            // 
            txtPPassport.AcceptsTab = true;
            txtPPassport.BackColor = Color.White;
            txtPPassport.Location = new Point(389, 60);
            txtPPassport.Name = "txtPPassport";
            txtPPassport.ReadOnly = true;
            txtPPassport.Size = new Size(144, 22);
            txtPPassport.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(297, 14);
            label11.Name = "label11";
            label11.Size = new Size(70, 19);
            label11.TabIndex = 30;
            label11.Text = "Phone no.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(297, 60);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 32;
            label10.Text = "Passport";
            // 
            // txtPPhone
            // 
            txtPPhone.BackColor = Color.White;
            txtPPhone.Location = new Point(389, 14);
            txtPPhone.Name = "txtPPhone";
            txtPPhone.ReadOnly = true;
            txtPPhone.Size = new Size(144, 22);
            txtPPhone.TabIndex = 31;
            // 
            // tabAircraft
            // 
            tabAircraft.Controls.Add(dgvAircraft);
            tabAircraft.Controls.Add(pnlAircraftFields);
            tabAircraft.Location = new Point(4, 24);
            tabAircraft.Name = "tabAircraft";
            tabAircraft.Padding = new Padding(3);
            tabAircraft.Size = new Size(875, 532);
            tabAircraft.TabIndex = 3;
            tabAircraft.Text = "Aircraft";
            tabAircraft.UseVisualStyleBackColor = true;
            tabAircraft.Click += tabAircraft_Click;
            // 
            // dgvAircraft
            // 
            dgvAircraft.AllowUserToAddRows = false;
            dgvAircraft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAircraft.BackgroundColor = Color.White;
            dgvAircraft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAircraft.Cursor = Cursors.Hand;
            dgvAircraft.Location = new Point(16, 135);
            dgvAircraft.Name = "dgvAircraft";
            dgvAircraft.ReadOnly = true;
            dgvAircraft.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAircraft.Size = new Size(839, 361);
            dgvAircraft.TabIndex = 27;
            dgvAircraft.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // pnlAircraftFields
            // 
            pnlAircraftFields.BackColor = Color.WhiteSmoke;
            pnlAircraftFields.BorderStyle = BorderStyle.FixedSingle;
            pnlAircraftFields.Controls.Add(btnClearAircraft);
            pnlAircraftFields.Controls.Add(button1);
            pnlAircraftFields.Controls.Add(btnSaveAircraft);
            pnlAircraftFields.Controls.Add(txtAircraftSeats);
            pnlAircraftFields.Controls.Add(label15);
            pnlAircraftFields.Controls.Add(txtAircraftModel);
            pnlAircraftFields.Controls.Add(label14);
            pnlAircraftFields.Location = new Point(0, 3);
            pnlAircraftFields.Name = "pnlAircraftFields";
            pnlAircraftFields.Size = new Size(873, 100);
            pnlAircraftFields.TabIndex = 26;
            pnlAircraftFields.Paint += pnlAircraftFields_Paint;
            // 
            // btnClearAircraft
            // 
            btnClearAircraft.AllowDrop = true;
            btnClearAircraft.AutoEllipsis = true;
            btnClearAircraft.BackColor = Color.FromArgb(64, 64, 64);
            btnClearAircraft.Cursor = Cursors.Hand;
            btnClearAircraft.FlatStyle = FlatStyle.Flat;
            btnClearAircraft.ForeColor = Color.White;
            btnClearAircraft.Location = new Point(218, 60);
            btnClearAircraft.Name = "btnClearAircraft";
            btnClearAircraft.Size = new Size(81, 35);
            btnClearAircraft.TabIndex = 41;
            btnClearAircraft.Text = "Clear";
            btnClearAircraft.UseVisualStyleBackColor = false;
            btnClearAircraft.Click += btnClearAircraft_Click;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.AutoEllipsis = true;
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(114, 60);
            button1.Name = "button1";
            button1.Size = new Size(81, 35);
            button1.TabIndex = 40;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDeleteAircraft_Click;
            // 
            // btnSaveAircraft
            // 
            btnSaveAircraft.AllowDrop = true;
            btnSaveAircraft.AutoEllipsis = true;
            btnSaveAircraft.BackColor = Color.FromArgb(0, 150, 0);
            btnSaveAircraft.Cursor = Cursors.Hand;
            btnSaveAircraft.FlatStyle = FlatStyle.Flat;
            btnSaveAircraft.ForeColor = Color.White;
            btnSaveAircraft.Location = new Point(15, 60);
            btnSaveAircraft.Name = "btnSaveAircraft";
            btnSaveAircraft.Size = new Size(81, 35);
            btnSaveAircraft.TabIndex = 39;
            btnSaveAircraft.Text = "Save";
            btnSaveAircraft.UseVisualStyleBackColor = false;
            btnSaveAircraft.Click += btnSaveAircraft_Click;
            // 
            // txtAircraftSeats
            // 
            txtAircraftSeats.Cursor = Cursors.Hand;
            txtAircraftSeats.Location = new Point(393, 12);
            txtAircraftSeats.Name = "txtAircraftSeats";
            txtAircraftSeats.Size = new Size(150, 22);
            txtAircraftSeats.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(307, 15);
            label15.Name = "label15";
            label15.Size = new Size(66, 15);
            label15.TabIndex = 10;
            label15.Text = "Total Seats";
            // 
            // txtAircraftModel
            // 
            txtAircraftModel.Cursor = Cursors.Hand;
            txtAircraftModel.Location = new Point(101, 15);
            txtAircraftModel.Name = "txtAircraftModel";
            txtAircraftModel.Size = new Size(150, 22);
            txtAircraftModel.TabIndex = 9;
            txtAircraftModel.TextChanged += textBox1_TextChanged_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 15);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 0;
            label14.Text = "Model";
            // 
            // tabSeats
            // 
            tabSeats.Controls.Add(btnResetSeat);
            tabSeats.Controls.Add(dgvSeats);
            tabSeats.Controls.Add(pnlSeatFilter);
            tabSeats.Location = new Point(4, 24);
            tabSeats.Name = "tabSeats";
            tabSeats.Padding = new Padding(3);
            tabSeats.Size = new Size(875, 532);
            tabSeats.TabIndex = 4;
            tabSeats.Text = "Seats";
            tabSeats.UseVisualStyleBackColor = true;
            // 
            // btnResetSeat
            // 
            btnResetSeat.BackColor = Color.Brown;
            btnResetSeat.FlatStyle = FlatStyle.Flat;
            btnResetSeat.ForeColor = Color.White;
            btnResetSeat.Location = new Point(353, 487);
            btnResetSeat.Name = "btnResetSeat";
            btnResetSeat.Size = new Size(150, 35);
            btnResetSeat.TabIndex = 29;
            btnResetSeat.Text = "Reset Selected Seat";
            btnResetSeat.UseVisualStyleBackColor = false;
            btnResetSeat.Click += btnResetSeat_Click;
            // 
            // dgvSeats
            // 
            dgvSeats.AllowUserToAddRows = false;
            dgvSeats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSeats.BackgroundColor = Color.White;
            dgvSeats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeats.Cursor = Cursors.Hand;
            dgvSeats.Location = new Point(19, 128);
            dgvSeats.Name = "dgvSeats";
            dgvSeats.ReadOnly = true;
            dgvSeats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeats.Size = new Size(830, 345);
            dgvSeats.TabIndex = 28;
            // 
            // pnlSeatFilter
            // 
            pnlSeatFilter.BackColor = Color.WhiteSmoke;
            pnlSeatFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlSeatFilter.Controls.Add(cmbFlightFilter);
            pnlSeatFilter.Controls.Add(btnShowAllSeats);
            pnlSeatFilter.Controls.Add(btnLoadSeats);
            pnlSeatFilter.Controls.Add(textBox1);
            pnlSeatFilter.Controls.Add(label16);
            pnlSeatFilter.Controls.Add(label17);
            pnlSeatFilter.Location = new Point(3, 3);
            pnlSeatFilter.Name = "pnlSeatFilter";
            pnlSeatFilter.Size = new Size(873, 100);
            pnlSeatFilter.TabIndex = 27;
            // 
            // cmbFlightFilter
            // 
            cmbFlightFilter.Cursor = Cursors.Hand;
            cmbFlightFilter.FormattingEnabled = true;
            cmbFlightFilter.Location = new Point(114, 11);
            cmbFlightFilter.Name = "cmbFlightFilter";
            cmbFlightFilter.Size = new Size(150, 23);
            cmbFlightFilter.TabIndex = 42;
            // 
            // btnShowAllSeats
            // 
            btnShowAllSeats.AllowDrop = true;
            btnShowAllSeats.AutoEllipsis = true;
            btnShowAllSeats.BackColor = Color.FromArgb(128, 128, 255);
            btnShowAllSeats.BackgroundImageLayout = ImageLayout.None;
            btnShowAllSeats.Cursor = Cursors.Hand;
            btnShowAllSeats.FlatStyle = FlatStyle.Flat;
            btnShowAllSeats.ForeColor = Color.Black;
            btnShowAllSeats.Location = new Point(162, 60);
            btnShowAllSeats.Name = "btnShowAllSeats";
            btnShowAllSeats.Size = new Size(113, 35);
            btnShowAllSeats.TabIndex = 40;
            btnShowAllSeats.Text = "Show All Seats";
            btnShowAllSeats.UseVisualStyleBackColor = false;
            btnShowAllSeats.Click += btnShowAllSeats_Click;
            // 
            // btnLoadSeats
            // 
            btnLoadSeats.AllowDrop = true;
            btnLoadSeats.AutoEllipsis = true;
            btnLoadSeats.BackColor = Color.FromArgb(192, 192, 0);
            btnLoadSeats.Cursor = Cursors.Hand;
            btnLoadSeats.FlatStyle = FlatStyle.Flat;
            btnLoadSeats.ForeColor = Color.White;
            btnLoadSeats.Location = new Point(22, 60);
            btnLoadSeats.Name = "btnLoadSeats";
            btnLoadSeats.Size = new Size(109, 35);
            btnLoadSeats.TabIndex = 39;
            btnLoadSeats.Text = " Load Seats";
            btnLoadSeats.UseVisualStyleBackColor = false;
            btnLoadSeats.Click += btnLoadSeats_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.Hand;
            textBox1.Location = new Point(393, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 22);
            textBox1.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(307, 15);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 10;
            label16.Text = "Total Seats";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 15);
            label17.Name = "label17";
            label17.Size = new Size(88, 15);
            label17.TabIndex = 0;
            label17.Text = "Filter by Flight:";
            label17.Click += label17_Click;
            // 
            // tabWalkIn
            // 
            tabWalkIn.BackColor = Color.WhiteSmoke;
            tabWalkIn.Controls.Add(btnWalkInBook);
            tabWalkIn.Controls.Add(pnlWalkInInfo);
            tabWalkIn.Controls.Add(pnlWalkIn);
            tabWalkIn.Location = new Point(4, 24);
            tabWalkIn.Name = "tabWalkIn";
            tabWalkIn.Padding = new Padding(3);
            tabWalkIn.Size = new Size(875, 532);
            tabWalkIn.TabIndex = 5;
            tabWalkIn.Text = "Walk-In booking";
            tabWalkIn.Click += tabPage1_Click_1;
            // 
            // btnWalkInBook
            // 
            btnWalkInBook.AllowDrop = true;
            btnWalkInBook.AutoEllipsis = true;
            btnWalkInBook.BackColor = Color.FromArgb(0, 150, 0);
            btnWalkInBook.FlatStyle = FlatStyle.Flat;
            btnWalkInBook.ForeColor = Color.White;
            btnWalkInBook.Location = new Point(366, 477);
            btnWalkInBook.Name = "btnWalkInBook";
            btnWalkInBook.Size = new Size(104, 35);
            btnWalkInBook.TabIndex = 55;
            btnWalkInBook.Text = "✈ Book Flight";
            btnWalkInBook.UseVisualStyleBackColor = false;
            btnWalkInBook.Click += btnWalkInBook_Click;
            // 
            // pnlWalkInInfo
            // 
            pnlWalkInInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlWalkInInfo.Controls.Add(txtWalkInPhone);
            pnlWalkInInfo.Controls.Add(label21);
            pnlWalkInInfo.Controls.Add(txtWalkInFirstName);
            pnlWalkInInfo.Controls.Add(label18);
            pnlWalkInInfo.Controls.Add(label20);
            pnlWalkInInfo.Controls.Add(txtWalkInLastName);
            pnlWalkInInfo.Controls.Add(txtWalkInPassport);
            pnlWalkInInfo.Controls.Add(label19);
            pnlWalkInInfo.Location = new Point(255, 179);
            pnlWalkInInfo.Name = "pnlWalkInInfo";
            pnlWalkInInfo.Size = new Size(322, 270);
            pnlWalkInInfo.TabIndex = 54;
            // 
            // txtWalkInPhone
            // 
            txtWalkInPhone.Location = new Point(113, 149);
            txtWalkInPhone.Name = "txtWalkInPhone";
            txtWalkInPhone.ReadOnly = true;
            txtWalkInPhone.Size = new Size(144, 22);
            txtWalkInPhone.TabIndex = 16;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(19, 30);
            label21.Name = "label21";
            label21.Size = new Size(77, 19);
            label21.TabIndex = 9;
            label21.Text = "First Name";
            // 
            // txtWalkInFirstName
            // 
            txtWalkInFirstName.Location = new Point(112, 30);
            txtWalkInFirstName.Name = "txtWalkInFirstName";
            txtWalkInFirstName.ReadOnly = true;
            txtWalkInFirstName.Size = new Size(144, 22);
            txtWalkInFirstName.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(20, 149);
            label18.Name = "label18";
            label18.Size = new Size(62, 19);
            label18.TabIndex = 15;
            label18.Text = "Passport";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(20, 87);
            label20.Name = "label20";
            label20.Size = new Size(76, 19);
            label20.TabIndex = 11;
            label20.Text = "Last Name";
            label20.Click += label20_Click;
            // 
            // txtWalkInLastName
            // 
            txtWalkInLastName.Location = new Point(113, 87);
            txtWalkInLastName.Name = "txtWalkInLastName";
            txtWalkInLastName.ReadOnly = true;
            txtWalkInLastName.Size = new Size(144, 22);
            txtWalkInLastName.TabIndex = 12;
            // 
            // txtWalkInPassport
            // 
            txtWalkInPassport.Location = new Point(118, 212);
            txtWalkInPassport.Name = "txtWalkInPassport";
            txtWalkInPassport.ReadOnly = true;
            txtWalkInPassport.Size = new Size(144, 22);
            txtWalkInPassport.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(26, 212);
            label19.Name = "label19";
            label19.Size = new Size(70, 19);
            label19.TabIndex = 13;
            label19.Text = "Phone no.";
            // 
            // pnlWalkIn
            // 
            pnlWalkIn.BorderStyle = BorderStyle.FixedSingle;
            pnlWalkIn.Controls.Add(btnLoadWalkInSeats);
            pnlWalkIn.Controls.Add(cmbWalkInSeat);
            pnlWalkIn.Controls.Add(cmbWalkInPassenger);
            pnlWalkIn.Controls.Add(cmbWalkInFlight);
            pnlWalkIn.Controls.Add(l7);
            pnlWalkIn.Controls.Add(l5);
            pnlWalkIn.Controls.Add(l6);
            pnlWalkIn.Location = new Point(0, 0);
            pnlWalkIn.Name = "pnlWalkIn";
            pnlWalkIn.Size = new Size(875, 105);
            pnlWalkIn.TabIndex = 0;
            // 
            // btnLoadWalkInSeats
            // 
            btnLoadWalkInSeats.AllowDrop = true;
            btnLoadWalkInSeats.AutoEllipsis = true;
            btnLoadWalkInSeats.BackColor = Color.FromArgb(192, 192, 0);
            btnLoadWalkInSeats.Cursor = Cursors.Hand;
            btnLoadWalkInSeats.FlatStyle = FlatStyle.Flat;
            btnLoadWalkInSeats.ForeColor = Color.White;
            btnLoadWalkInSeats.Location = new Point(365, 65);
            btnLoadWalkInSeats.Name = "btnLoadWalkInSeats";
            btnLoadWalkInSeats.Size = new Size(93, 35);
            btnLoadWalkInSeats.TabIndex = 53;
            btnLoadWalkInSeats.Text = " Load Seats";
            btnLoadWalkInSeats.UseVisualStyleBackColor = false;
            btnLoadWalkInSeats.Click += btnLoadWalkInSeats_Click;
            // 
            // cmbWalkInSeat
            // 
            cmbWalkInSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWalkInSeat.FormattingEnabled = true;
            cmbWalkInSeat.Location = new Point(596, 17);
            cmbWalkInSeat.Name = "cmbWalkInSeat";
            cmbWalkInSeat.Size = new Size(121, 23);
            cmbWalkInSeat.TabIndex = 52;
            // 
            // cmbWalkInPassenger
            // 
            cmbWalkInPassenger.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWalkInPassenger.FormattingEnabled = true;
            cmbWalkInPassenger.Location = new Point(352, 17);
            cmbWalkInPassenger.Name = "cmbWalkInPassenger";
            cmbWalkInPassenger.Size = new Size(121, 23);
            cmbWalkInPassenger.TabIndex = 51;
            cmbWalkInPassenger.SelectedIndexChanged += cmbWalkInPassenger_SelectedIndexChanged;
            // 
            // cmbWalkInFlight
            // 
            cmbWalkInFlight.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWalkInFlight.FormattingEnabled = true;
            cmbWalkInFlight.Location = new Point(84, 17);
            cmbWalkInFlight.Name = "cmbWalkInFlight";
            cmbWalkInFlight.Size = new Size(121, 23);
            cmbWalkInFlight.TabIndex = 50;
            // 
            // l7
            // 
            l7.AutoSize = true;
            l7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l7.Location = new Point(254, 17);
            l7.Name = "l7";
            l7.Size = new Size(70, 19);
            l7.TabIndex = 49;
            l7.Text = "Passenger";
            l7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l5
            // 
            l5.AutoSize = true;
            l5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l5.Location = new Point(22, 17);
            l5.Name = "l5";
            l5.Size = new Size(45, 19);
            l5.TabIndex = 48;
            l5.Text = "Flight:";
            l5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l6
            // 
            l6.AutoSize = true;
            l6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l6.Location = new Point(523, 17);
            l6.Name = "l6";
            l6.Size = new Size(39, 19);
            l6.TabIndex = 47;
            l6.Text = "Seat:";
            l6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            btnLogout.AutoEllipsis = true;
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(811, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(82, 30);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(btnLogout);
            Controls.Add(tabMain);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flight Reservation System - Admin";
            Load += AdminDashboard_Load;
            tabMain.ResumeLayout(false);
            tabFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            pnlFlightFields.ResumeLayout(false);
            pnlFlightFields.PerformLayout();
            tabBookings.ResumeLayout(false);
            tabBookings.PerformLayout();
            pnlBookingFilter.ResumeLayout(false);
            pnlBookingFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            tabPassengers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPassengers).EndInit();
            pnlPassengerFields.ResumeLayout(false);
            pnlPassengerFields.PerformLayout();
            tabAircraft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAircraft).EndInit();
            pnlAircraftFields.ResumeLayout(false);
            pnlAircraftFields.PerformLayout();
            tabSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSeats).EndInit();
            pnlSeatFilter.ResumeLayout(false);
            pnlSeatFilter.PerformLayout();
            tabWalkIn.ResumeLayout(false);
            pnlWalkInInfo.ResumeLayout(false);
            pnlWalkInInfo.PerformLayout();
            pnlWalkIn.ResumeLayout(false);
            pnlWalkIn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabMain;
        private TabPage tabFlights;
        private TabPage tabBookings;
        private TabPage tabPassengers;
        private TabPage tabAircraft;
        private TabPage tabSeats;
        private Label l1;
        private Panel pnlFlightFields;
        private TextBox txtFlightNumber;
        private TextBox txtOrigin;
        private Label label2;
        private Label label1;
        private ComboBox cmbAircraft;
        private Label label5;
        private TextBox txtTime;
        private Label label4;
        private TextBox txtDate;
        private Label label3;
        private TextBox txtDestination;
        private Button btnSaveFlight;
        private Button btnDeleteFlight;
        private Button btnUpdateFlight;
        private Button btnClearFlight;
        private DataGridView dgvFlights;
        private Button btnCancelBooking;
        private DataGridView dgvBookings;
        private Panel pnlBookingFilter;
        private Label label6;
        private TextBox txtSearchFlight;
        private Label label7;
        private TextBox txtSearchPassenger;
        private Button btnSearchBooking;
        private Button btnShowAllBookings;
        private Label lblBookingCount;
        private Panel pnlPassengerFields;
        private TextBox txtPPassword;
        private Label label13;
        private Label label8;
        private TextBox txtPFirstName;
        private TextBox txtPUsername;
        private Label label12;
        private Label label9;
        private TextBox txtPLastName;
        private TextBox txtPPassport;
        private Label label11;
        private Label label10;
        private TextBox txtPPhone;
        private Button btnDeletePassenger;
        private Button btnClearPassenger;
        private DataGridView dgvPassengers;
        private Panel pnlAircraftFields;
        private Label label14;
        private TextBox txtAircraftModel;
        private Label label15;
        private TextBox txtAircraftSeats;
        private Button btnSaveAircraft;
        private DataGridView dgvAircraft;
        private Button btnClearAircraft;
        private Button button1;
        private Button btnLogout;
        private Panel pnlSeatFilter;
        private Button btnShowAllSeats;
        private Button btnLoadSeats;
        private TextBox textBox1;
        private Label label16;
        private Label label17;
        private ComboBox cmbFlightFilter;
        private Button btnResetSeat;
        private DataGridView dgvSeats;
        private Button btnAssignSeat;
        private Button btnPrintTicket;
        private TabPage tabWalkIn;
        private Panel pnlWalkIn;
        private Label l6;
        private Label l5;
        private Label l7;
        private ComboBox cmbWalkInPassenger;
        private ComboBox cmbWalkInFlight;
        private Button btnLoadWalkInSeats;
        private ComboBox cmbWalkInSeat;
        private Panel pnlWalkInInfo;
        private TextBox txtWalkInPhone;
        private Label label21;
        private TextBox txtWalkInFirstName;
        private Label label18;
        private TextBox txtWalkInPassport;
        private Label label19;
        private TextBox txtWalkInLastName;
        private Label label20;
        private Button btnWalkInBook;
    }
}