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

        int userChoice;
        int computerChoice;

        int userWins = 0;
        int computerWins = 0;

        private void GameButtons()
        {
            switch (userChoice)
            {
                case ROCK:
                    userPictureBox.Image = Properties.Resources.Rock;
                    break;

                case PAPER:
                    userPictureBox.Image = Properties.Resources.Paper;
                    break;

                case SCISSORS:
                    userPictureBox.Image = Properties.Resources.Scissors;
                    break;
            }

            Random randomNumberGenerator = new Random();
            computerChoice = randomNumberGenerator.Next(1, 4);

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
        }

        private void WhoWins()
        {
            if (userChoice == ROCK && computerChoice == PAPER)
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                computerWinsLabel.Text = computerWins.ToString();
            }

            else if (userChoice == ROCK && computerChoice == SCISSORS)
            {
                MessageBox.Show("User wins");
                userWins++;
                userWinsLabel.Text = userWins.ToString();
            }

            else if (userChoice == PAPER && computerChoice == ROCK)
            {
                MessageBox.Show("User wins");
                userWins++;
                userWinsLabel.Text = userWins.ToString();
            }

            else if (userChoice == PAPER && computerChoice == SCISSORS)
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                computerWinsLabel.Text = computerWins.ToString();
            }

            else if (userChoice == SCISSORS && computerChoice == ROCK)
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                computerWinsLabel.Text = computerWins.ToString();
            }

            else if (userChoice == SCISSORS && computerChoice == PAPER)
            {
                MessageBox.Show("User wins");
                userWins++;
                userWinsLabel.Text = userWins.ToString();
            }
            else
            {
                MessageBox.Show("It's a tie");
            }
        }

        private void PlayAgain()
        {
            userWinsLabel.Text = "";
            computerWinsLabel.Text = "";
            userPictureBox.Image = null;
            computerPictureBox.Image = null;
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            userChoice = ROCK;
            GameButtons();
            WhoWins();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            userChoice = PAPER;
            GameButtons();
            WhoWins();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            userChoice = SCISSORS;
            GameButtons();
            WhoWins();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            PlayAgain();
        }
        }
    }
