using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;   // To hold the name of a city

            // if the user selected something
            if (cityListBox.SelectedIndex != -1)
            {
                // Get the selected item.
                city = cityListBox.SelectedItem.ToString();

                // Determine the time zone based on the city.
                // use a switch statement
                // honolulu = Hawaii-Aleutian
                // San Francisco - Pacific
                // denver - Mountain
                // Minneapolis - Central
                // New York - Eastern
                switch (city)
                {
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;

                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;

                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;

                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;

                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                }
            }
            else
            {
                // No city was selected.
                MessageBox.Show("Select a city");
            }     
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
