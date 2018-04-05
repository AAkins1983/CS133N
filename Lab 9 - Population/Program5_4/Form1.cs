using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double organisms;      // To hold number of organisms
                int days;           // Number of days to to multiply
                double populationIncrease;     // Approximate population
                double population;
                double percentIncrease;

                // Get organisms, daily increase, and days to multiply
                organisms = double.Parse(organismsTextBox.Text);
                percentIncrease = double.Parse(increaseTextBox.Text);
                days = int.Parse(daysTextBox.Text);

                // Display table
                outputListBox.Items.Add("Day" + "                   Approximate Population");

                population = organisms;

                for (int index = 1; index <= days; index++)
                {
                    // Display days and population
                    outputListBox.Items.Add(index + "                       " + population);

                    // Calculate organisms daily increase in population
                    populationIncrease = population * percentIncrease;

                    population += populationIncrease;
                }             
             }
             catch (Exception ex)
             {
                // Display default error message
                MessageBox.Show(ex.Message);
             }

                // Output listbox to file
                StreamWriter outputFile; 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.CreateText(saveFileDialog1.FileName);

                    for (int index = 0; index < outputListBox.Items.Count; index++)
                    {
                        outputListBox.SelectedIndex = index;
                        outputFile.WriteLine(outputListBox.SelectedItem);
                    }

                    outputFile.Close();
                    MessageBox.Show("The data was saved.");
                }
                else
                {
                    MessageBox.Show("The Save Dialog Box was cancelled.");
                }            
            }
        }
    }

