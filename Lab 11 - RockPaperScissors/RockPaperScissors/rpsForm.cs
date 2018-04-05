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

        int userChoice = 0;
        int computerChoice = 0;

        int userWins = 0;
        int computerWins = 0;

        private void GameButtons()
        {
            int userChoice = 0;
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
        }

        private void WhoWins(int user, int comp)
        {
            if (user == ROCK && comp == PAPER)
            {
                MessageBox.Show("Computer wins");
            }

            else if (user == ROCK && comp == SCISSORS)
            {
                MessageBox.Show("User wins");
            }

            else if (user == PAPER && comp == ROCK)
            {
                MessageBox.Show("User wins");
            }

            else if (user == PAPER && comp == SCISSORS)
            {
                MessageBox.Show("Computer wins");
            }

            else if (user == SCISSORS && comp == ROCK)
            {
                MessageBox.Show("Computer wins");
            }

            else if (user == SCISSORS && comp == PAPER)
            {
                MessageBox.Show("User wins");
            }

            else if (comp == ROCK && user == PAPER)
            {
                MessageBox.Show("User wins");
            }

            else if (comp == ROCK && user == SCISSORS)
            {
                MessageBox.Show("Computer wins");
            }

            else if (comp == PAPER && user == ROCK)
            {
                MessageBox.Show("Computer wins");
            }

            else if (comp == PAPER && user == SCISSORS)
            {
                MessageBox.Show("User wins");
            }

            else if (comp == SCISSORS && user == ROCK)
            {
                MessageBox.Show("User wins");
            }

            else if (comp == SCISSORS && user == PAPER)
            {
                MessageBox.Show("Computer wins");
            }  
            else
            {
                MessageBox.Show("It's a tie");
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            GameButtons();
            WhoWins(userChoice, computerChoice);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            GameButtons();
            WhoWins(userChoice, computerChoice);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            GameButtons();
            WhoWins(userChoice, computerChoice);
        }


        }
    }
