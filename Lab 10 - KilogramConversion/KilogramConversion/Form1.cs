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

        // returns number of pounds given the number of kilograms
        private double KilogramsToPounds(double kg)
        {
            return kg * 2.20462;
        }

        // returns number of ounces given number of pounds
        private double PoundsToOunces(double lbs)
        {
            return lbs * 16;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int kilograms = 10; kilograms <= 25; kilograms++)
            {
               
                PoundsToOunces = 
        }
    }
}
