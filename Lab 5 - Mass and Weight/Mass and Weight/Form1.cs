using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_and_Weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the weight label control.
            massTextBox.Text = "";
            weightOutputLabel.Text = "";

            // Reset the focus to test1.
            massTextBox.Focus();
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
             try
            {
                double mass;    // mass variable
                double weight;  // weight variable

                // Get the mass of object from the TextBox.
                mass = double.Parse(massTextBox.Text);
                
                // Calculate weight of object in Newtons.
                weight = mass * 9.8;

                // Display the average, rounded to 2 decimal places.
                weightOutputLabel.Text = weight.ToString("n1");

                // If object weighs more than 1000 Newtons, display message indicating it's too heavy.
                if (weight > 1000)
                {
                    MessageBox.Show("Object is too heavy.");
                }
                
                 // If object weighs less than 1000 Newtons, display message indicating it's too light.
                if (weight < 10)
                {
                    MessageBox.Show("Object is too light.");
                }
            
             }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }
        }
    }
