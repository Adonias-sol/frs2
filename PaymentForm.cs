using System;
using System.Windows.Forms;

namespace frs
{
    public partial class PaymentForm : Form
    {
        public bool PaymentConfirmed { get; private set; } = false;
        public string PaymentMethod { get; private set; } = "";

        private string _flightNumber;
        private string _seatNumber;
        private double _amount;

        public PaymentForm(string flightNumber, string seatNumber, double amount)
        {
            InitializeComponent();
            _flightNumber = flightNumber;
            _seatNumber = seatNumber;
            _amount = amount;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // ✅ Now using ReadOnly TextBoxes
            txtFlightInfo.Text = _flightNumber;
            txtSeatInfo.Text = _seatNumber;
            txtAmount.Text = $"${_amount:F2}";
            cmbMethod.SelectedIndex = 0;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PaymentConfirmed = true;
            PaymentMethod = cmbMethod.SelectedItem.ToString();
            this.Close();
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            PaymentConfirmed = false;
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
