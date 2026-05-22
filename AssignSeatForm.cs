using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frs
{
    public partial class AssignSeatForm : Form
    {
        private Guid _bookingId;
        private Guid _flightId;
        public bool SeatAssigned { get; private set; } = false;

        public AssignSeatForm(Guid bookingId, Guid flightId,
                              string passengerName, string flightNo)
        {
            InitializeComponent();
            _bookingId = bookingId;
            _flightId = flightId;
            lblPassenger.Text = $"Passenger: {passengerName}";
            lblFlight.Text = $"Flight:    {flightNo}";
        }

        private void AssignSeatForm_Load(object sender, EventArgs e)
        {
            LoadAvailableSeats();
        }

        private void LoadAvailableSeats()
        {
            DBConnection.Initialize();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT SeatId, SeatNumber, ClassType FROM Seats
                      WHERE FlightId = @flightId AND IsAvailable = 1
                      ORDER BY SeatNumber",
                    DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@flightId", _flightId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbSeats.DataSource = dt;
                    cmbSeats.DisplayMember = "SeatNumber";
                    cmbSeats.ValueMember = "SeatId";
                    cmbSeats.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("eror: " + ex.Message); }
            DBConnection.Close();
        }

        private void btnAssignSeat_Click(object sender, EventArgs e)
        {
            if (cmbSeats.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a seat.", "No Seat Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid seatId = Guid.Parse(cmbSeats.SelectedValue.ToString());

            DBConnection.Initialize();
            SqlTransaction transaction = DBConnection.connection.BeginTransaction();
            try
            {
                // Assign seat to booking
                using (SqlCommand updateBooking = new SqlCommand(
                    "UPDATE Bookings SET SeatId = @seatId WHERE BookingId = @bookingId",
                    DBConnection.connection, transaction))
                {
                    updateBooking.Parameters.AddWithValue("@seatId", seatId);
                    updateBooking.Parameters.AddWithValue("@bookingId", _bookingId);
                    updateBooking.ExecuteNonQuery();
                }

                // Mark seat as unavailable
                using (SqlCommand updateSeat = new SqlCommand(
                    "UPDATE Seats SET IsAvailable = 0 WHERE SeatId = @seatId",
                    DBConnection.connection, transaction))
                {
                    updateSeat.Parameters.AddWithValue("@seatId", seatId);
                    updateSeat.ExecuteNonQuery();
                }

                // Update ticket seat number
                using (SqlCommand updateTicket = new SqlCommand(
                    @"UPDATE Tickets SET SeatNumber = @seatNo
                      WHERE BookingId = @bookingId",
                    DBConnection.connection, transaction))
                {
                    updateTicket.Parameters.AddWithValue("@seatNo",
                        cmbSeats.Text.ToString());
                    updateTicket.Parameters.AddWithValue("@bookingId", _bookingId);
                    updateTicket.ExecuteNonQuery();
                }

                transaction.Commit();
                SeatAssigned = true;
                MessageBox.Show("Seat assigned successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBConnection.Close();
        }

        private void btnCancelAssign_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}