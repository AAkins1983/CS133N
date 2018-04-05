using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_and_Tax_Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal foodCharge;     // Original food charge
            decimal tipPercentage = .15m;  // Tip percentage
            decimal taxPercentage = .07m;  // Tax percentage
            decimal totalCharge;    // Total food charge

            // Get food charge.
            foodCharge = decimal.Parse(foodChargeTextBox.Text);

            // Calculate tip.
            tipPercentage = tipPercentage * foodCharge;

            // Calculate tax.
            taxPercentage = taxPercentage * foodCharge;

            // Calculate total food charge.
            totalCharge = foodCharge - tipPercentage - taxPercentage;

            // Display tip total.
            tipPercentageOutputLabel.Text = tipPercentage.ToString("C");

            // Display tax total.
            taxPercentageOutputLabel.Text = taxPercentage.ToString("C");

            // Display total food charge.
            totalChargeOutputLabel.Text = totalCharge.ToString("c");
        }
    }
}
