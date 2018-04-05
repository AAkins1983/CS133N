using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        private bool InputIsValid(ref decimal pay, ref decimal bonus) // Declare method "bool" which means it has to return true or false.
        {
            // Flag variable to indicate whether the input is good
            bool inputGood = false; // initialize to false to handle the two else's, and it has to be returned which means it has to have a variable.

            // Try to convert both inputs to decimal.
            if (decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    // Both inputs are good.
                    inputGood = true;
                }
                else
                {
                    // Display an error message for the bonus.
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                // Display an error message for gross pay.
                MessageBox.Show("Gross pay is invalid.");
            }

                // Return the result.
                return inputGood;
            }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables for gross pay, bonus, and contributions
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref grossPay, ref bonus)) // Call to InputIsValid method that returns either true or false
            {
                // Calculate the amount of contribution.
                contributions = (grossPay + bonus) * CONTRIB_RATE;

                // Display the contribution.
                contributionLabel.Text = contributions.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
