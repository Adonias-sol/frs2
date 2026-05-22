using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnManageAircraft_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void pnlFlightFields_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtFlightNumber_Click(object sender, EventArgs e)
        {

        }
        private void pnlFlightFields_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void lblBookingCount_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void tabPassengers_Click(object sender, EventArgs e)
        {

        }
        private void txtPFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void pnlPassengerFields_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabAircraft_Click(object sender, EventArgs e)
        {

        }
        private void pnlAircraftFields_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click_2(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAircraftCombo();
            LoadFlightFilterCombo();
            LoadFlights();
            tabMain.SelectedIndexChanged += TabMain_SelectedIndexChanged;
            dgvFlights.SelectionChanged += DgvFlights_SelectionChanged;
            dgvPassengers.SelectionChanged += DgvPassengers_SelectionChanged;
            dgvAircraft.SelectionChanged += DgvAircraft_SelectionChanged;
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0: LoadFlights(); break;
                case 1: LoadBookings(); break;
                case 2: LoadPassengers(); break;
                case 3: LoadAircraft(); break;
                case 4: LoadSeats(); break;
                case 5: LoadWalkInCombos(); break;
            }
        }

        // ══════════════════════════════════════
        //  COMBOS
        // ══════════════════════════════════════
        private void LoadAircraftCombo()
        {
            DBConnection.Initialize();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT AircraftId, Model FROM Aircraft", DBConnection.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbAircraft.DataSource = dt;
                cmbAircraft.DisplayMember = "Model";
                cmbAircraft.ValueMember = "AircraftId";
                cmbAircraft.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void LoadFlightFilterCombo()
        {
            DBConnection.Initialize();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT FlightId, FlightNumber FROM Flights ORDER BY FlightNumber",
                    DBConnection.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbFlightFilter.DataSource = dt;
                cmbFlightFilter.DisplayMember = "FlightNumber";
                cmbFlightFilter.ValueMember = "FlightId";
                cmbFlightFilter.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        // ══════════════════════════════════════
        //  TAB 1 — FLIGHTS
        // ══════════════════════════════════════
        private void DgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvFlights.SelectedRows[0];
            txtFlightNumber.Text = row.Cells["Flight No."].Value?.ToString();
            txtOrigin.Text = row.Cells["From"].Value?.ToString();
            txtDestination.Text = row.Cells["To"].Value?.ToString();
            txtDate.Text = row.Cells["Date"].Value?.ToString();
            txtTime.Text = row.Cells["Time"].Value?.ToString();
        }

        private void ClearFlightFields()
        {
            txtFlightNumber.Text = "";
            txtOrigin.Text = "";
            txtDestination.Text = "";
            txtDate.Text = "";
            txtTime.Text = "";
            cmbAircraft.SelectedIndex = -1;
        }

        private void LoadFlights()
        {
            DBConnection.Initialize();
            try
            {
                string sql = @"SELECT 
                                f.FlightNumber  AS [Flight No.],
                                f.Origin        AS [From],
                                f.Destination   AS [To],
                                f.Date          AS [Date],
                                f.Time          AS [Time],
                                a.Model         AS [Aircraft],
                                a.TotalSeat     AS [Total Seats],
                                (SELECT COUNT(*) FROM Seats s 
                                 WHERE s.FlightId = f.FlightId 
                                 AND s.IsAvailable = 1) AS [Seats Available]
                               FROM Flights f
                               JOIN Aircraft a ON f.AircraftId = a.AircraftId
                               ORDER BY f.DepartureTime";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, DBConnection.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvFlights.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnSaveFlight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFlightNumber.Text) ||
                string.IsNullOrWhiteSpace(txtOrigin.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text) ||
                string.IsNullOrWhiteSpace(txtTime.Text) ||
                cmbAircraft.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                Guid aircraftId = Guid.Parse(cmbAircraft.SelectedValue.ToString());
                DateTime departure = DateTime.Parse(txtDate.Text + " " + txtTime.Text);

                // Insert flight
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Flights
             (FlightNumber,AircraftId,DepartureTime,Origin,Destination,Date,Time)
             VALUES(@flightNo,@aircraftId,@departure,@origin,@destination,@date,@time)",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@flightNo", txtFlightNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    cmd.Parameters.AddWithValue("@departure", departure);
                    cmd.Parameters.AddWithValue("@origin", txtOrigin.Text.Trim());
                    cmd.Parameters.AddWithValue("@destination", txtDestination.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", txtDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@time", txtTime.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                // Get total seats
                int totalSeats;
                using (SqlCommand getTotalCmd = new SqlCommand(
                    "SELECT TotalSeat FROM Aircraft WHERE AircraftId = @aircraftId",
                    DBConnection.connection, transaction))
                {
                    getTotalCmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    totalSeats = Convert.ToInt32(getTotalCmd.ExecuteScalar());
                }

                // Get new flight ID
                Guid flightId;
                using (SqlCommand getFlightCmd = new SqlCommand(
                    "SELECT FlightId FROM Flights WHERE FlightNumber = @flightNo",
                    DBConnection.connection, transaction))
                {
                    getFlightCmd.Parameters.AddWithValue("@flightNo", txtFlightNumber.Text.Trim());
                    flightId = Guid.Parse(getFlightCmd.ExecuteScalar().ToString());
                }

                // Generate seats
                for (int i = 1; i <= totalSeats; i++)
                {
                    string classType = i <= (totalSeats * 0.1) ? "First" :
                                       i <= (totalSeats * 0.3) ? "Business" : "Economy";

                    using (SqlCommand seatCmd = new SqlCommand(
                        @"INSERT INTO Seats(SeatNumber,ClassType,IsAvailable,FlightId)
                  VALUES(@seatNo,@class,1,@flightId)",
                        DBConnection.connection, transaction))
                    {
                        seatCmd.Parameters.AddWithValue("@seatNo", i.ToString());
                        seatCmd.Parameters.AddWithValue("@class", classType);
                        seatCmd.Parameters.AddWithValue("@flightId", flightId);
                        seatCmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                MessageBox.Show("Flight saved!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFlightFields();
                LoadFlights();
                LoadFlightFilterCombo();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFlightNumber.Text))
            {
                MessageBox.Show("Select a flight from the grid first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"UPDATE Flights SET Origin=@origin,Destination=@destination,
              Date=@date,Time=@time,DepartureTime=@departure
              WHERE FlightNumber=@flightNo",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@origin", txtOrigin.Text.Trim());
                    cmd.Parameters.AddWithValue("@destination", txtDestination.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", txtDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@time", txtTime.Text.Trim());
                    cmd.Parameters.AddWithValue("@departure", DateTime.Parse(txtDate.Text + " " + txtTime.Text));
                    cmd.Parameters.AddWithValue("@flightNo", txtFlightNumber.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Flight updated!", "Updated",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFlightFields();
                LoadFlights();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFlightNumber.Text))
            {
                MessageBox.Show("Select a flight from the grid first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Delete flight {txtFlightNumber.Text}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                // Get FlightId first
                Guid flightId;
                using (SqlCommand getCmd = new SqlCommand(
                    "SELECT FlightId FROM Flights WHERE FlightNumber = @flightNo",
                    DBConnection.connection, transaction))
                {
                    getCmd.Parameters.AddWithValue("@flightNo", txtFlightNumber.Text.Trim());
                    flightId = Guid.Parse(getCmd.ExecuteScalar().ToString());
                }

                // Delete tickets first
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Tickets WHERE FlightId = @flightId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);
                    cmd.ExecuteNonQuery();
                }

                // Delete bookings
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Bookings WHERE FlightId = @flightId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);
                    cmd.ExecuteNonQuery();
                }

                // Delete seats
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Seats WHERE FlightId = @flightId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);
                    cmd.ExecuteNonQuery();
                }

                // Delete flight
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Flights WHERE FlightId = @flightId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Flight deleted.", "Deleted",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFlightFields();
                LoadFlights();
                LoadFlightFilterCombo();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }
        private void btnClearFlight_Click(object sender, EventArgs e) => ClearFlightFields();

        // ══════════════════════════════════════
        //  TAB 2 — BOOKINGS
        // ══════════════════════════════════════
        private void LoadBookings(string passenger = "", string flightNo = "")
        {
            DBConnection.Initialize();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT u.Username AS [Passenger],
                             f.FlightNumber AS [Flight No.],
                             f.Origin AS [From],
                             f.Destination AS [To],
                             s.SeatNumber AS [Seat],
                             s.ClassType AS [Class],
                             b.BookingDate AS [Booked On],
                             b.Status AS [Status]
                      FROM Bookings b
                      JOIN Users u      ON b.PassengerId = u.UserID
                      JOIN Flights f    ON b.FlightId    = f.FlightId
                      LEFT JOIN Seats s ON b.SeatId      = s.SeatId
                      WHERE (@passenger='' OR u.Username LIKE '%'+@passenger+'%')
                      AND   (@flightNo ='' OR f.FlightNumber LIKE '%'+@flightNo+'%')
                      ORDER BY b.BookingDate DESC",
                    DBConnection.connection);
                cmd.Parameters.AddWithValue("@passenger", passenger);
                cmd.Parameters.AddWithValue("@flightNo", flightNo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvBookings.DataSource = table;
                lblBookingCount.Text = $"Total Bookings: {table.Rows.Count}";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
            => LoadBookings(txtSearchPassenger.Text.Trim(), txtSearchFlight.Text.Trim());

        private void btnShowAllBookings_Click(object sender, EventArgs e)
        {
            txtSearchPassenger.Text = "";
            txtSearchFlight.Text = "";
            LoadBookings();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a booking first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passenger = dgvBookings.SelectedRows[0].Cells["Passenger"].Value.ToString();
            string flightNo = dgvBookings.SelectedRows[0].Cells["Flight No."].Value.ToString();
            string seatNo = dgvBookings.SelectedRows[0].Cells["Seat"].Value?.ToString();

            if (MessageBox.Show($"Cancel booking for {passenger} on {flightNo}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                using (SqlCommand cancelCmd = new SqlCommand(
                    @"UPDATE Bookings SET Status='Cancelled'
              WHERE PassengerId=(SELECT UserID FROM Users WHERE Username=@passenger)
              AND FlightId=(SELECT FlightId FROM Flights WHERE FlightNumber=@flightNo)",
                    DBConnection.connection, transaction))
                {
                    cancelCmd.Parameters.AddWithValue("@passenger", passenger);
                    cancelCmd.Parameters.AddWithValue("@flightNo", flightNo);
                    cancelCmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrEmpty(seatNo))
                {
                    using (SqlCommand freeSeat = new SqlCommand(
                        @"UPDATE Seats SET IsAvailable=1
                  WHERE SeatNumber=@seatNo
                  AND FlightId=(SELECT FlightId FROM Flights WHERE FlightNumber=@flightNo)",
                        DBConnection.connection, transaction))
                    {
                        freeSeat.Parameters.AddWithValue("@seatNo", seatNo);
                        freeSeat.Parameters.AddWithValue("@flightNo", flightNo);
                        freeSeat.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                MessageBox.Show("Booking cancelled.", "Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBookings();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }
        private void btnAssignSeat_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = dgvBookings.SelectedRows[0].Cells["Status"].Value.ToString();
            if (status == "Cancelled")
            {
                MessageBox.Show("Cannot assign seat to a cancelled booking.", "Invalid",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get booking details
            string passenger = dgvBookings.SelectedRows[0].Cells["Passenger"].Value.ToString();
            string flightNo = dgvBookings.SelectedRows[0].Cells["Flight No."].Value.ToString();

            // Get BookingId and FlightId from DB
            DBConnection.Initialize();
            try
            {
                Guid bookingId;
                Guid flightId;

                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT b.BookingId, b.FlightId 
              FROM Bookings b
              JOIN Users u   ON b.PassengerId = u.UserID
              JOIN Flights f ON b.FlightId    = f.FlightId
              WHERE u.Username     = @passenger
              AND   f.FlightNumber = @flightNo",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@passenger", passenger);
                    cmd.Parameters.AddWithValue("@flightNo", flightNo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Booking not found.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DBConnection.Close();
                        return;
                    }

                    reader.Read();
                    bookingId = Guid.Parse(reader["BookingId"].ToString());
                    flightId = Guid.Parse(reader["FlightId"].ToString());
                    reader.Close();
                }

                DBConnection.Close();

                // Open assign seat form
                AssignSeatForm assignForm = new AssignSeatForm(
                    bookingId, flightId, passenger, flightNo);
                assignForm.ShowDialog();

                if (assignForm.SeatAssigned)
                    LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                DBConnection.Close();
            }
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passenger = dgvBookings.SelectedRows[0].Cells["Passenger"].Value.ToString();
            string flightNo = dgvBookings.SelectedRows[0].Cells["Flight No."].Value.ToString();
            string from = dgvBookings.SelectedRows[0].Cells["From"].Value.ToString();
            string to = dgvBookings.SelectedRows[0].Cells["To"].Value.ToString();
            string seat = dgvBookings.SelectedRows[0].Cells["Seat"].Value?.ToString() ?? "Not Assigned";
            string cls = dgvBookings.SelectedRows[0].Cells["Class"].Value?.ToString() ?? "N/A";
            string bookedOn = dgvBookings.SelectedRows[0].Cells["Booked On"].Value.ToString();
            string status = dgvBookings.SelectedRows[0].Cells["Status"].Value.ToString();

            // Get ticket details from DB
            DBConnection.Initialize();
            try
            {
                string ticketId = "N/A";
                string price = "N/A";
                string issued = "N/A";

                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT t.TicketId, t.Price, t.IssueDate
              FROM Tickets t
              JOIN Bookings b ON t.BookingId = b.BookingId
              JOIN Users u    ON b.PassengerId = u.UserID
              JOIN Flights f  ON b.FlightId    = f.FlightId
              WHERE u.Username     = @passenger
              AND   f.FlightNumber = @flightNo",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@passenger", passenger);
                    cmd.Parameters.AddWithValue("@flightNo", flightNo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        ticketId = reader["TicketId"].ToString();
                        price = reader["Price"].ToString();
                        issued = reader["IssueDate"].ToString();
                    }
                    reader.Close();
                }

                DBConnection.Close();

                MessageBox.Show(
                    $"════════════════════════\n" +
                    $"      FLIGHT TICKET\n" +
                    $"════════════════════════\n" +
                    $"Ticket ID  : {ticketId}\n" +
                    $"Passenger  : {passenger}\n" +
                    $"Flight     : {flightNo}\n" +
                    $"From       : {from}\n" +
                    $"To         : {to}\n" +
                    $"Seat       : {seat}\n" +
                    $"Class      : {cls}\n" +
                    $"Price      : ${price}\n" +
                    $"Booked On  : {bookedOn}\n" +
                    $"Issued On  : {issued}\n" +
                    $"Status     : {status}\n" +
                    $"════════════════════════",
                    "Ticket Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                DBConnection.Close();
            }
        }

        // ══════════════════════════════════════
        //  TAB 3 — PASSENGERS
        // ══════════════════════════════════════
        private void DgvPassengers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPassengers.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvPassengers.SelectedRows[0];
            txtPFirstName.Text = row.Cells["First Name"].Value?.ToString();
            txtPLastName.Text = row.Cells["Last Name"].Value?.ToString();
            txtPPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtPPassport.Text = row.Cells["Passport No."].Value?.ToString();
            txtPUsername.Text = row.Cells["Username"].Value?.ToString();
        }

        private void ClearPassengerFields()
        {
            txtPFirstName.Text = "";
            txtPLastName.Text = "";
            txtPPhone.Text = "";
            txtPPassport.Text = "";
            txtPUsername.Text = "";
        }

        private void LoadPassengers()
        {
            DBConnection.Initialize();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT FirstName AS [First Name], LastName AS [Last Name],
                             Phone AS [Phone], Passport AS [Passport No.],
                             Username AS [Username]
                      FROM Users WHERE Role='Passenger' ORDER BY FirstName",
                    DBConnection.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPassengers.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnDeletePassenger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPUsername.Text))
            {
                MessageBox.Show("Select a passenger from the grid first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Delete passenger {txtPUsername.Text}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                // Get UserID first
                Guid userId;
                using (SqlCommand getCmd = new SqlCommand(
                    "SELECT UserID FROM Users WHERE Username = @username",
                    DBConnection.connection, transaction))
                {
                    getCmd.Parameters.AddWithValue("@username", txtPUsername.Text.Trim());
                    userId = Guid.Parse(getCmd.ExecuteScalar().ToString());
                }

                // Delete tickets linked to this passenger's bookings
                using (SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM Tickets WHERE BookingId IN 
              (SELECT BookingId FROM Bookings WHERE PassengerId = @userId)",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }

                // Delete bookings
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Bookings WHERE PassengerId = @userId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }

                // Delete user
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Users WHERE UserID = @userId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Passenger deleted.", "Deleted",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPassengerFields();
                LoadPassengers();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }
        private void btnClearPassenger_Click(object sender, EventArgs e) => ClearPassengerFields();

        // ══════════════════════════════════════
        //  TAB 4 — AIRCRAFT
        // ══════════════════════════════════════
        private void DgvAircraft_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAircraft.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvAircraft.SelectedRows[0];
            txtAircraftModel.Text = row.Cells["Model"].Value?.ToString();
            txtAircraftSeats.Text = row.Cells["Total Seats"].Value?.ToString();
        }

        private void LoadAircraft()
        {
            DBConnection.Initialize();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Model AS [Model], TotalSeat AS [Total Seats] FROM Aircraft",
                    DBConnection.connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvAircraft.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnSaveAircraft_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAircraftModel.Text) ||
                string.IsNullOrWhiteSpace(txtAircraftSeats.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Aircraft(Model,TotalSeat) VALUES(@model,@seats)",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@model", txtAircraftModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@seats", int.Parse(txtAircraftSeats.Text.Trim()));
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Aircraft saved!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAircraftModel.Text = "";
                txtAircraftSeats.Text = "";
                LoadAircraft();
                LoadAircraftCombo();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }
        private void btnDeleteAircraft_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAircraftModel.Text))
            {
                MessageBox.Show("Select an aircraft from the grid first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Delete {txtAircraftModel.Text}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                // Get AircraftId
                Guid aircraftId;
                using (SqlCommand getCmd = new SqlCommand(
                    "SELECT AircraftId FROM Aircraft WHERE Model = @model",
                    DBConnection.connection, transaction))
                {
                    getCmd.Parameters.AddWithValue("@model", txtAircraftModel.Text.Trim());
                    aircraftId = Guid.Parse(getCmd.ExecuteScalar().ToString());
                }

                // Delete tickets for flights using this aircraft
                using (SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM Tickets WHERE FlightId IN
              (SELECT FlightId FROM Flights WHERE AircraftId = @aircraftId)",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    cmd.ExecuteNonQuery();
                }

                // Delete bookings
                using (SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM Bookings WHERE FlightId IN
              (SELECT FlightId FROM Flights WHERE AircraftId = @aircraftId)",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    cmd.ExecuteNonQuery();
                }

                // Delete seats
                using (SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM Seats WHERE FlightId IN
              (SELECT FlightId FROM Flights WHERE AircraftId = @aircraftId)",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    cmd.ExecuteNonQuery();
                }

                // Delete flights
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Flights WHERE AircraftId = @aircraftId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    cmd.ExecuteNonQuery();
                }

                // Delete aircraft
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Aircraft WHERE AircraftId = @aircraftId",
                    DBConnection.connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@aircraftId", aircraftId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Aircraft deleted.", "Deleted",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAircraftModel.Text = "";
                txtAircraftSeats.Text = "";
                LoadAircraft();
                LoadAircraftCombo();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            DBConnection.Close();
        }
        private void btnClearAircraft_Click(object sender, EventArgs e)
        {
            txtAircraftModel.Text = "";
            txtAircraftSeats.Text = "";
        }

        // ══════════════════════════════════════
        //  TAB 5 — SEATS
        // ══════════════════════════════════════
        private void LoadSeats(string flightId = "")
        {
            DBConnection.Initialize();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT f.FlightNumber AS [Flight No.],
                             f.Origin AS [From], f.Destination AS [To],
                             s.SeatNumber AS [Seat No.], s.ClassType AS [Class],
                             CASE WHEN s.IsAvailable=1 THEN 'Available' ELSE 'Booked' END AS [Status]
                      FROM Seats s
                      JOIN Flights f ON s.FlightId=f.FlightId
                      WHERE (@flightId='' OR CAST(f.FlightId AS NVARCHAR(50))=@flightId)
                      ORDER BY f.FlightNumber, s.SeatNumber",
                    DBConnection.connection);
                cmd.Parameters.AddWithValue("@flightId", flightId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvSeats.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnLoadSeats_Click(object sender, EventArgs e)
        {
            if (cmbFlightFilter.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadSeats(cmbFlightFilter.SelectedValue.ToString());
        }

        private void btnShowAllSeats_Click(object sender, EventArgs e)
        {
            cmbFlightFilter.SelectedIndex = -1;
            LoadSeats();
        }

        private void btnResetSeat_Click(object sender, EventArgs e)
        {
            if (dgvSeats.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a seat from the grid first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seatNo = dgvSeats.SelectedRows[0].Cells["Seat No."].Value.ToString();
            string flightNo = dgvSeats.SelectedRows[0].Cells["Flight No."].Value.ToString();
            string status = dgvSeats.SelectedRows[0].Cells["Status"].Value.ToString();

            if (status == "Available")
            {
                MessageBox.Show("This seat is already available.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBConnection.Initialize();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Seats SET IsAvailable=1
                      WHERE SeatNumber=@seatNo
                      AND FlightId=(SELECT FlightId FROM Flights WHERE FlightNumber=@flightNo)",
                    DBConnection.connection);
                cmd.Parameters.AddWithValue("@seatNo", seatNo);
                cmd.Parameters.AddWithValue("@flightNo", flightNo);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Seat reset to available.", "Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSeats();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
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

       
        // ══════════════════════════════════════
        //  TAB 6 — WALK-IN BOOKING
        // ══════════════════════════════════════
        private void LoadWalkInCombos()
        {
            // Load passengers
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT UserID, Username FROM Users WHERE Role='Passenger' ORDER BY Username",
                    DBConnection.connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cmbWalkInPassenger.DataSource = dt;
                    cmbWalkInPassenger.DisplayMember = "Username";
                    cmbWalkInPassenger.ValueMember = "UserID";
                    cmbWalkInPassenger.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading passengers: " + ex.Message); }
            DBConnection.Close();

            // Load flights separately
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT FlightId, FlightNumber FROM Flights 
              WHERE (SELECT COUNT(*) FROM Seats s 
                     WHERE s.FlightId = Flights.FlightId 
                     AND s.IsAvailable = 1) > 0
              ORDER BY FlightNumber",
                    DBConnection.connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cmbWalkInFlight.DataSource = dt;
                    cmbWalkInFlight.DisplayMember = "FlightNumber";
                    cmbWalkInFlight.ValueMember = "FlightId";
                    cmbWalkInFlight.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading flights: " + ex.Message); }
            DBConnection.Close();

            // Clear seat combo
            cmbWalkInSeat.DataSource = null;
            cmbWalkInSeat.Items.Clear();
        }

        private void cmbWalkInPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guard: skip if nothing selected or value is not a valid Guid
            if (cmbWalkInPassenger.SelectedIndex == -1) return;
            if (cmbWalkInPassenger.SelectedValue == null) return;

            if (!Guid.TryParse(cmbWalkInPassenger.SelectedValue.ToString(), out Guid userId))
                return;

            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT FirstName, LastName, Phone, Passport 
              FROM Users WHERE UserID = @userId",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        txtWalkInFirstName.Text = reader["FirstName"].ToString();
                        txtWalkInLastName.Text = reader["LastName"].ToString();
                        txtWalkInPhone.Text = reader["Phone"].ToString();
                        txtWalkInPassport.Text = reader["Passport"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnLoadWalkInSeats_Click(object sender, EventArgs e)
        {
            if (cmbWalkInFlight.SelectedIndex == -1 ||
                cmbWalkInFlight.SelectedValue == null)
            {
                MessageBox.Show("Please select a flight first.", "No Flight",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Guid.TryParse(cmbWalkInFlight.SelectedValue.ToString(), out Guid flightId))
                return;

            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT SeatId, SeatNumber, ClassType
              FROM Seats
              WHERE FlightId  = @flightId
              AND IsAvailable = 1
              ORDER BY SeatNumber",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@flightId", flightId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Build display column
                    dt.Columns.Add("SeatDisplay", typeof(string));
                    foreach (DataRow row in dt.Rows)
                        row["SeatDisplay"] = $"{row["SeatNumber"]} ({row["ClassType"]})";

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No available seats for this flight.", "No Seats",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbWalkInSeat.DataSource = null;
                        cmbWalkInSeat.Items.Clear();
                        DBConnection.Close();
                        return;
                    }

                    cmbWalkInSeat.DataSource = null;
                    cmbWalkInSeat.DataSource = dt;
                    cmbWalkInSeat.DisplayMember = "SeatDisplay";
                    cmbWalkInSeat.ValueMember = "SeatId";
                    cmbWalkInSeat.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading seats: " + ex.Message); }
            DBConnection.Close();
        }
        private void btnWalkInBook_Click(object sender, EventArgs e)
        {
            if (cmbWalkInPassenger.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a passenger.", "No Passenger",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbWalkInFlight.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flight.", "No Flight",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbWalkInSeat.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a seat.", "No Seat",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid passengerId = Guid.Parse(cmbWalkInPassenger.SelectedValue.ToString());
            Guid flightId = Guid.Parse(cmbWalkInFlight.SelectedValue.ToString());
            Guid seatId = Guid.Parse(cmbWalkInSeat.SelectedValue.ToString());
            string flightNo = cmbWalkInFlight.Text;
            string seatNo = cmbWalkInSeat.Text;

            // Get class type for pricing
            DBConnection.Initialize();
            string classType = "Economy";
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ClassType FROM Seats WHERE SeatId = @seatId",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@seatId", seatId);
                    classType = cmd.ExecuteScalar()?.ToString() ?? "Economy";
                }
            }
            catch { }
            DBConnection.Close();

            double amount = classType == "First" ? 1500.00 :
                            classType == "Business" ? 800.00 : 300.00;

            // Open payment form
            PaymentForm payment = new PaymentForm(flightNo, seatNo, amount);
            payment.ShowDialog();

            if (!payment.PaymentConfirmed) return;

            // Process booking with transaction
            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                // Insert payment
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

                // Insert booking
                Guid bookingId = Guid.NewGuid();
                using (SqlCommand bookCmd = new SqlCommand(
                    @"INSERT INTO Bookings
             (BookingId,PassengerId,FlightId,SeatId,PaymentId,Status)
              VALUES
             (@bookingId,@passengerId,@flightId,@seatId,@paymentId,'Confirmed')",
                    DBConnection.connection, transaction))
                {
                    bookCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    bookCmd.Parameters.AddWithValue("@passengerId", passengerId);
                    bookCmd.Parameters.AddWithValue("@flightId", flightId);
                    bookCmd.Parameters.AddWithValue("@seatId", seatId);
                    bookCmd.Parameters.AddWithValue("@paymentId", paymentId);
                    bookCmd.ExecuteNonQuery();
                }

                // Mark seat unavailable
                using (SqlCommand seatCmd = new SqlCommand(
                    "UPDATE Seats SET IsAvailable=0 WHERE SeatId=@seatId",
                    DBConnection.connection, transaction))
                {
                    seatCmd.Parameters.AddWithValue("@seatId", seatId);
                    seatCmd.ExecuteNonQuery();
                }

                // Generate ticket
                using (SqlCommand ticketCmd = new SqlCommand(
                    @"INSERT INTO Tickets(BookingId,SeatNumber,Price,FlightId)
              VALUES(@bookingId,@seatNo,@price,@flightId)",
                    DBConnection.connection, transaction))
                {
                    ticketCmd.Parameters.AddWithValue("@bookingId", bookingId);
                    ticketCmd.Parameters.AddWithValue("@seatNo", seatNo);
                    ticketCmd.Parameters.AddWithValue("@price", amount);
                    ticketCmd.Parameters.AddWithValue("@flightId", flightId);
                    ticketCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show(
                    $"Walk-in booking confirmed! ✈\n" +
                    $"Passenger : {cmbWalkInPassenger.Text}\n" +
                    $"Flight    : {flightNo}\n" +
                    $"Seat      : {seatNo}\n" +
                    $"Paid      : ${amount:F2} via {payment.PaymentMethod}",
                    "Booking Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset combos
                cmbWalkInPassenger.SelectedIndex = -1;
                cmbWalkInFlight.SelectedIndex = -1;
                cmbWalkInSeat.SelectedIndex = -1;
                txtWalkInFirstName.Text = "";
                txtWalkInLastName.Text = "";
                txtWalkInPhone.Text = "";
                txtWalkInPassport.Text = "";

                LoadWalkInCombos();
                LoadBookings();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Booking failed:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBConnection.Close();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void l7_Click(object sender, EventArgs e)
        {

        }

        

        // ── Auto-generated empty handlers ──

    }
}