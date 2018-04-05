using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Constants
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            // Variables
            int kph;        // Kilometers per hour
            double mph;     // Miles per hour

            // Display the table of speeds.
            for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                // Calculate miles per hour.
                mph = kph * CONVERSION_FACTOR;

                // Display the conversion.
                outputListBox.Items.Add(kph + " KPH is the same as " + mph + " MPH");
            }

            // output what's in the listbox to the file
            StreamWriter outputFile;        // declare the file objecet before the loop
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)     // Let the user
            {
                outputFile = File.CreateText(saveFileDialog1.FileName);      // open

                for (int index = 0; index < outputListBox.Items.Count; index++)
                {
                    outputListBox.SelectedIndex = index;        // set the list
                    outputFile.WriteLine(outputListBox.SelectedItem);       // write the
                }

                outputFile.Close();     // Close the file after the loop
                MessageBox.Show("The data was saved.");
            }
            else
            {
                MessageBox.Show("The Save Dialog Box was cancelled.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
