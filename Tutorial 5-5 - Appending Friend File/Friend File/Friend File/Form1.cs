using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Open the Friend.txt file for appending,
                // and get a StreamWriter object.
                outputFile = File.AppendText("Friend.txt");

                // Write the friend's name to a the file.
                outputFile.WriteLine(nameTextBox.Text);

                // Close the file.
                outputFile.Close();

                // Let the user know the name was written.
                MessageBox.Show("The name was written.");

                // Clear the nameTextBox control.
                nameTextBox.Text = "";

                // Give the focus to the nameTextBox control.
                nameTextBox.Focus();
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
