using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilogramConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Constants
            const int START_KILOS = 10;                 // Starting kilograms
            const int END_KILOS = 25;                   // Ending kilograms
            const decimal POUND_CONVERSION = 2.20462m;  // Kilo to pound conversion 
            const int OUNCE_CONVERSION = 16;            // Pound to ounce conversion

            // Variables
            int kilos;       // To hold kilograms
            decimal pounds;  // To hold pounds
            decimal ounces;  // To hold ounces

            // Display table.
            outputListBox.Items.Add("Kilograms      " + "Pounds       " + "Ounces");

            for (kilos = START_KILOS; kilos <= END_KILOS; kilos++)
            {
                // Calculate pounds and ounces.
                pounds = kilos * POUND_CONVERSION;
                ounces = pounds * OUNCE_CONVERSION;

                // Display the conversion.
                outputListBox.Items.Add(kilos + "                 " + pounds.ToString("n2") + "          " + ounces.ToString("n2"));
            }
        }
    }
}
