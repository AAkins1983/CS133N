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

        int userWins = 0;
        int computerWins = 0;

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

                case PAPER:
                    computerPictureBox.Image = Properties.Resources.Paper;
                    break;

                case SCISSORS:
                    computerPictureBox.Image = Properties.Resources.Scissors;
                    break;
            }

            if (userChoice == computerChoice)
            {
                MessageBox.Show("It's a tie.");
            }
            
            else if (computerChoice == PAPER)
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                computerWinsLabel.Text = computerWins.ToString();
            }
            else if (computerChoice == SCISSORS)
            {
                MessageBox.Show("User wins");
                userWins++;
                userWinsLabel.Text = userWins.ToString();
            }
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            int userChoice = PAPER;
            userPictureBox.Image = Properties.Resources.Paper;

            Random randomNumberGenerator = new Random();
            int computerChoice = randomNumberGenerator.Next(1, 4);
            switch (computerChoice)
            {
                case PAPER:
                    computerPictureBox.Image = Properties.Resources.Paper;
                    break;

                case ROCK:
                    computerPictureBox.Image = Properties.Resources.Rock;
                    break;

                case SCISSORS:
                    computerPictureBox.Image = Properties.Resources.Scissors;
                    break;
            }

            if (userChoice == computerChoice)
            {
                MessageBox.Show("It's a tie.");
            }
           
            else if (computerChoice == SCISSORS)
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                computerWinsLabel.Text = computerWins.ToString();
            }
            else if (computerChoice == ROCK)
            {
                MessageBox.Show("User wins");
                userWins++;
                userWinsLabel.Text = userWins.ToString();
            }
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            int userChoice = SCISSORS;
            userPictureBox.Image = Properties.Resources.Scissors;

            Random randomNumberGenerator = new Random();
            int computerChoice = randomNumberGenerator.Next(1, 4);
            switch (computerChoice)
            {
                case SCISSORS:
                    computerPictureBox.Image = Properties.Resources.Scissors;
                    break;

                case ROCK:
                    computerPictureBox.Image = Properties.Resources.Rock;
                    break;

                case PAPER:
                    computerPictureBox.Image = Properties.Resources.Paper;
                    break;
            }

            if (userChoice == computerChoice)
            {
                MessageBox.Show("It's a tie.");
            }
            
            else if (computerChoice == ROCK)
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                computerWinsLabel.Text = computerWins.ToString();
            }
            else if (computerChoice == PAPER)
            {
                MessageBox.Show("User wins");
                userWins++;
                userWinsLabel.Text = userWins.ToString();
                
            }

        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            // Clear wins
            userWinsLabel.Text = " ";
            computerWinsLabel.Text = " ";
        }
    }
}
