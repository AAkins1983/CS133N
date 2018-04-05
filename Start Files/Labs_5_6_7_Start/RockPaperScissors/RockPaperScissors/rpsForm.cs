using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program6_10
{
    public partial class rpsForm : Form
    {
        public rpsForm()
        {
            InitializeComponent();
        }

        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;

        private void rockButton_Click(object sender, EventArgs e)
        {
            int userChoice = ROCK;
            userPictureBox.Image = Properties.Resources.Rock;

            Random randomNumberGenerator = new Random();
            int computerChoice = randomNumberGenerator.Next(1, 4);
            switch (computerChoice)
            {
                case ROCK:
                    computerPictureBox.Image = Properties.Resources.Rock;
                    break;
                // this is meant as a sample ... you're not done yet!
            }

            if (userChoice == computerChoice)
                MessageBox.Show("It's a tie.");
            // this is meant as a sample ... you're not done yet!


        }
    }
}
