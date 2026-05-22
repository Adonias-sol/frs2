using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    public partial class PassengerDashboard : Form
    {
        private Guid _userId;
        private Guid _selectedFlightId;
        private Guid _selectedSeatId;

        public PassengerDashboard(Guid userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        public PassengerDashboard() : this(Guid.Empty) { }

        private void PassengerDashboard_Load(object sender, EventArgs e)
        {
            // Connect events in code
            dgvFlights.SelectionChanged += DgvFlights_SelectionChanged;
            tabMain.SelectedIndexChanged += TabMain_SelectedIndexChanged;

            // Load welcome name
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT FirstName FROM Users WHERE UserID = @userId",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    string firstName = cmd.ExecuteScalar()?.ToString();
                    lblWelcome.Text = $"Welcome, {firstName}!";
                }
            }
            catch { }
            DBConnection.Close();

            // Load flights on startup
            LoadAvailableFlights();
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0: LoadAvailableFlights(); break;
                case 1: LoadMyBookings(); break;
                case 2: LoadMyTickets(); break;
            }
        }

        // ══════════════════════════════════════
        //  TAB 1 — SEARCH FLIGHTS
        // ══════════════════════════════════════
        private void LoadAvailableFlights(string from = "", string to = "")
        {
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT 
                        f.FlightId,
                        f.FlightNumber  AS [Flight No.],
                        f.Origin        AS [From],
                        f.Destination   AS [To],
                        f.Date          AS [Date],
                        f.Time          AS [Time],
                        a.Model         AS [Aircraft],
                        (SELECT COUNT(*) FROM Seats s 
                         WHERE s.FlightId = f.FlightId 
                         AND s.IsAvailable = 1) AS [Seats Available]
                      FROM Flights f
                      JOIN Aircraft a ON f.AircraftId = a.AircraftId
                      WHERE (SELECT COUNT(*) FROM Seats s 
                             WHERE s.FlightId = f.FlightId 
                             AND s.IsAvailable = 1) > 0
                      AND (@from = '' OR f.Origin      LIKE '%' + @from + '%')
                      AND (@to   = '' OR f.Destination LIKE '%' + @to   + '%')
                      ORDER BY f.DepartureTime",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvFlights.DataSource = table;

                    if (dgvFlights.Columns["FlightId"] != null)
                        dgvFlights.Columns["FlightId"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading flights: " + ex.Message); }
            DBConnection.Close();

            dgvSeats.DataSource = null;
            lblSeats.Text = "Available Seats:";
        }

        private void DgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0) return;
            if (dgvFlights.SelectedRows[0].Cells["FlightId"].Value == null) return;

            try
            {
                string flightIdStr = dgvFlights.SelectedRows[0]
                                               .Cells["FlightId"].Value.ToString();
                if (string.IsNullOrEmpty(flightIdStr)) return;

                _selectedFlightId = Guid.Parse(flightIdStr);
                LoadAvailableSeats(_selectedFlightId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seat load error: " + ex.Message);
            }
        }

        private void LoadAvailableSeats(Guid flightId)
        {
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT SeatId,
                             SeatNumber AS [Seat No.],
                             ClassType  AS [Class]
                      FROM Seats
                      WHERE FlightId    = @flightId
                      AND   IsAvailable = 1
                      ORDER BY SeatNumber",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvSeats.DataSource = table;

                    if (dgvSeats.Columns["SeatId"] != null)
                        dgvSeats.Columns["SeatId"].Visible = false;

                    lblSeats.Text = $"Available Seats: ({table.Rows.Count} available)";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading seats: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
            => LoadAvailableFlights(txtFrom.Text.Trim(), txtTo.Text.Trim());

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            LoadAvailableFlights();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight first.", "No Flight",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvSeats.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a seat first.", "No Seat",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string flightNo = dgvFlights.SelectedRows[0].Cells["Flight No."].Value.ToString();
            string seatNo = dgvSeats.SelectedRows[0].Cells["Seat No."].Value.ToString();
            string classType = dgvSeats.SelectedRows[0].Cells["Class"].Value.ToString();

            _selectedSeatId = Guid.Parse(
                dgvSeats.SelectedRows[0].Cells["SeatId"].Value.ToString());

            double amount = classType == "First" ? 1500.00 :
                            classType == "Business" ? 800.00 : 300.00;

            PaymentForm payment = new PaymentForm(flightNo, seatNo, amount);
            payment.ShowDialog();

            if (!payment.PaymentConfirmed) return;

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                Guid paymentId = Guid.NewGuid();
                using (SqlCommand payCmd = new SqlCommand(
                    @"INSERT INTO Payments(PaymentId,Amount,PayDay,Method,Status)
                      VALUES(@paymentId,@amount,GETDATE(),@method,'Completed')",
                    DBConnection.connection, transaction))
                {
                    payCmd.Parameters.AddWithValue("@paymentId", paymentId);
                    payCmd.Parameters.AddWithValue("@amount", amount);
                    payCmd.Parameters.AddWithValue("@method", payment.PaymentMethod);
                    payCmd.ExecuteNonQuery();
                }

                Guid bookingId = Guid.NewGuid();
                using (SqlCommand bookCmd = new SqlCommand(
                    @"INSERT INTO Bookings
                     (BookingId,PassengerId,FlightId,SeatId,PaymentId,Status)
                      VALUES
                     (@bookingId,@passengerId,@flightId,@seatId,@paymentId,'Confirmed')",
                    DBConnection.connection, transaction))
                {
                    bookCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    bookCmd.Parameters.AddWithValue("@passengerId", _userId);
                    bookCmd.Parameters.AddWithValue("@flightId", _selectedFlightId);
                    bookCmd.Parameters.AddWithValue("@seatId", _selectedSeatId);
                    bookCmd.Parameters.AddWithValue("@paymentId", paymentId);
                    bookCmd.ExecuteNonQuery();
                }

                using (SqlCommand seatCmd = new SqlCommand(
                    "UPDATE Seats SET IsAvailable=0 WHERE SeatId=@seatId",
                    DBConnection.connection, transaction))
                {
                    seatCmd.Parameters.AddWithValue("@seatId", _selectedSeatId);
                    seatCmd.ExecuteNonQuery();
                }

                using (SqlCommand ticketCmd = new SqlCommand(
                    @"INSERT INTO Tickets(BookingId,SeatNumber,Price,FlightId)
                      VALUES(@bookingId,@seatNo,@price,@flightId)",
                    DBConnection.connection, transaction))
                {
                    ticketCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    ticketCmd.Parameters.AddWithValue("@seatNo", seatNo);
                    ticketCmd.Parameters.AddWithValue("@price", amount);
                    ticketCmd.Parameters.AddWithValue("@flightId", _selectedFlightId);
                    ticketCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show(
                    $"Booking confirmed! ✈\nFlight: {flightNo}\nSeat: {seatNo}\nPaid: ${amount:F2} via {payment.PaymentMethod}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAvailableFlights();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Booking failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBConnection.Close();
        }

        // ══════════════════════════════════════
        //  TAB 2 — MY BOOKINGS
        // ══════════════════════════════════════
        private void LoadMyBookings()
        {
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT 
                        f.FlightNumber  AS [Flight No.],
                        f.Origin        AS [From],
                        f.Destination   AS [To],
                        f.Date          AS [Date],
                        f.Time          AS [Time],
                        s.SeatNumber    AS [Seat],
                        s.ClassType     AS [Class],
                        p.Amount        AS [Amount ($)],
                        p.Method        AS [Payment],
                        b.BookingDate   AS [Booked On],
                        b.Status        AS [Status],
                        b.BookingId     AS [BookingId]
                      FROM Bookings b
                      JOIN Flights f  ON b.FlightId  = f.FlightId
                      JOIN Seats s    ON b.SeatId     = s.SeatId
                      JOIN Payments p ON b.PaymentId  = p.PaymentId
                      WHERE b.PassengerId = @userId 
                      AND b.Status != 'Cancelled'
                      ORDER BY b.BookingDate DESC",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMyBookings.DataSource = table;

                    if (dgvMyBookings.Columns["BookingId"] != null)
                        dgvMyBookings.Columns["BookingId"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvMyBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = dgvMyBookings.SelectedRows[0].Cells["Status"].Value.ToString();
            if (status == "Cancelled")
            {
                MessageBox.Show("Already cancelled.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Cancel this booking?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            Guid bookingId = Guid.Parse(
                dgvMyBookings.SelectedRows[0].Cells["BookingId"].Value.ToString());

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                using (SqlCommand cancelCmd = new SqlCommand(
                    "UPDATE Bookings SET Status='Cancelled' WHERE BookingId=@bookingId",
                    DBConnection.connection, transaction))
                {
                    cancelCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    cancelCmd.ExecuteNonQuery();
                }

                using (SqlCommand seatCmd = new SqlCommand(
                    @"UPDATE Seats SET IsAvailable=1
                      WHERE SeatId=(SELECT SeatId FROM Bookings WHERE BookingId=@bookingId)",
                    DBConnection.connection, transaction))
                {
                    seatCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    seatCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Booking cancelled.", "Cancelled",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyBookings();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }

        // ══════════════════════════════════════
        //  TAB 3 — MY TICKETS
        // ══════════════════════════════════════
        private void LoadMyTickets()
        {
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT 
                        t.TicketId      AS [Ticket ID],
                        f.FlightNumber  AS [Flight No.],
                        f.Origin        AS [From],
                        f.Destination   AS [To],
                        t.SeatNumber    AS [Seat],
                        f.Date          AS [Date],
                        f.Time          AS [Time],
                        t.Price         AS [Price ($)],
                        t.IssueDate     AS [Issued On]
                      FROM Tickets t
                      JOIN Bookings b ON t.BookingId = b.BookingId
                      JOIN Flights f  ON t.FlightId  = f.FlightId
                      WHERE b.PassengerId = @userId
                      ORDER BY t.IssueDate DESC",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMyTickets.DataSource = table;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if (dgvMyTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ticketId = dgvMyTickets.SelectedRows[0].Cells["Ticket ID"].Value.ToString();
            string flightNo = dgvMyTickets.SelectedRows[0].Cells["Flight No."].Value.ToString();
            string from = dgvMyTickets.SelectedRows[0].Cells["From"].Value.ToString();
            string to = dgvMyTickets.SelectedRows[0].Cells["To"].Value.ToString();
            string seat = dgvMyTickets.SelectedRows[0].Cells["Seat"].Value.ToString();
            string date = dgvMyTickets.SelectedRows[0].Cells["Date"].Value.ToString();
            string time = dgvMyTickets.SelectedRows[0].Cells["Time"].Value.ToString();
            string price = dgvMyTickets.SelectedRows[0].Cells["Price ($)"].Value.ToString();
            string issued = dgvMyTickets.SelectedRows[0].Cells["Issued On"].Value.ToString();

            MessageBox.Show(
                $"════════════════════════\n" +
                $"      FLIGHT TICKET\n" +
                $"════════════════════════\n" +
                $"Ticket ID : {ticketId}\n" +
                $"Flight    : {flightNo}\n" +
                $"From      : {from}\n" +
                $"To        : {to}\n" +
                $"Seat      : {seat}\n" +
                $"Date      : {date}\n" +
                $"Time      : {time}\n" +
                $"Price     : ${price}\n" +
                $"Issued    : {issued}\n" +
                $"════════════════════════",
                "Your Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ══════════════════════════════════════
        //  LOGOUT
        // ══════════════════════════════════════
        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform login = new mainform();
            login.Show();
            this.Close();
        }

        // ── Auto-generated empty handlers ──
        private void dgvMyTickets_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblSeats_Click(object sender, EventArgs e) { }
        private void l1_Click(object sender, EventArgs e) { }
        private void tabFlights_Click(object sender, EventArgs e) { }
        private void dgvFlights_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void PassengerDashboard_Load_1(object sender, EventArgs e) { }
    }
}