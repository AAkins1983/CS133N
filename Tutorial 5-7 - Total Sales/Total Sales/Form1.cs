using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                decimal sales;      // To hold a sales amount
                decimal total = 0m; // Accumulator, set to 0

                // Declare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Sales.txt");

                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    // Get a sales amount.
                    sales = decimal.Parse(inputFile.ReadLine());

                    // Add the sales amount to total.
                    total += sales;
                }

                // Close the file.
                inputFile.Close();

                // Display the total.
                totalLabel.Text = total.ToString("C");

            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
