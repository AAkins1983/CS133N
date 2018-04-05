using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        private double fahrenheit;
        private double celcius;
        const int NINE = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                celcius = double.Parse(temperatureTextBox.Text);

                fahrenheit = ((9*celcius)/5)+32;
                temperatureOutputLabel.Text = "Fahrenheit temperature" + fahrenheit.ToString("n1");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              try
            {
                fahrenheit = double.Parse(temperatureTextBox.Text);

                celcius = (5*(fahrenheit-32))/9;
                temperatureOutputLabel.Text = "Celcius temperature" + celcius.ToString("n1");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear output label.
            temperatureOutputLabel.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form.
            this.Close();
        }
    }
}
