using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program5_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int minutes;
            decimal calories = 3.9m;
            decimal caloriesBurned;

            for (minutes = 10; minutes <= 30; minutes = minutes + 5)
            {
                caloriesBurned = minutes * calories;

                // Display the conversion.
                caloriesListBox.Items.Add(caloriesBurned + " calories burned after " + minutes + " minutes on treadmill");
            }      
      
            // Output what's in the listbox to the file
            StreamWriter outputFile;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)   
            {
                outputFile = File.CreateText(saveFileDialog.FileName);     

                for (int index = 0; index < caloriesListBox.Items.Count; index++)
                {
                    caloriesListBox.SelectedIndex = index;        
                    outputFile.WriteLine(caloriesListBox.SelectedItem);
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

