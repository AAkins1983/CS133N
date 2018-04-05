using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program6_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variable to hold number of days in hospital.
            int days;

		    // Variables to hold medication, surgical, lab, and physical rehab charges.
            decimal medication, surgical, lab, rehab, totalCharges;

            // Get days in hospital.
            if (!int.TryParse(daysTextBox.Text, out days) || days <= 0)
            {
                MessageBox.Show("Length of stay is invalid.");
                daysTextBox.Focus();
                return;
            }

            // Get medication charges.
            if (!decimal.TryParse(medsTextBox.Text, out medication) || medication < 0)
            {
                MessageBox.Show("Medication charges are invalid");
                medsTextBox.Focus();
                return;
            }

            // Get surgical charges.
            if (!decimal.TryParse(surgTextBox.Text, out surgical) || surgical < 0)
            {
                MessageBox.Show("Surgical charges are invalid");
                surgTextBox.Focus();
                return;
            }

            // Get lab charges.
            if (!decimal.TryParse(labTextBox.Text, out lab) || lab < 0)
            {
                MessageBox.Show("Lab charges are invalid");
                labTextBox.Focus();
                return;
            }

            // Get rehab charges.
            if (!decimal.TryParse(rehabTextBox.Text, out rehab) || rehab < 0)
            {
                MessageBox.Show("Physical Rehab charges are invalid");
                rehabTextBox.Focus();
                return;
            }

            // Calculate total charges.
            totalCharges = CalcTotalCharges(days, medication, surgical, lab, rehab);

            // Display total charges.
            outputLabel.Text = "Total cost of hospital stay: $" + totalCharges.ToString();
        }

        // Calculate charges for days in hospital * 350.
        private decimal CalcStayCharges(decimal stayCharge)
        {
            return stayCharge * 350;
        }

        // Calculate medical, surgical, lab, and physical rehab charges.
        private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal lab, decimal rehab)
        {
            return (medication + surgical + lab + rehab);
        }

        // Calculate total charges.
        private decimal CalcTotalCharges(int days, decimal medication, decimal surgical, decimal lab, decimal rehab)
        {
            return CalcStayCharges(days) + CalcMiscCharges(medication, surgical, lab, rehab);
        }
    }
}
