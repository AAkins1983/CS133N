using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string userSymbol = "X";
        const string computerSymbol = "O";
        const string empty = "";

        private Label GetSquare(int row, int column)
        {
            int labelNumber = row * 3 + column + 1;
            return (Label)(this.Controls["label" + labelNumber.ToString()]);
        }

        private void GetRowAndColumn(Label l, out int row, out int column)
        {
            int position = int.Parse(l.Name.Substring(5));
            row = (position - 1) / 3;
            column = (position - 1) % 3;
        }

        private void ResetBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Label l = GetSquare(r, c);
                    l.Text = "";
                    l.Enabled = true;
                    l.ForeColor = Color.Black;
                }
            }
        }

        private void HightlightColumn(int col)
        {
            for (int row = 0; row < 3; row++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }

        private void HightlightDiagonal1()
        {

        }

        private void HightlightDiagonal2()
        {

        }

        private void HightlightRow(int row)
        {

        }
        
        private void MakeComputerMove()
        {
            // do
            //      pick a random number between 0 and 2 for row
            //      and another random number between 0 and 2 for column     
            // Repeat this process if that square has a value in it
            // FYI use GetSquare method to "find" the label at row, column
            // disable the square
            // set the text to the computer's symbol
            // if computer won (IsWinner)
            //    display a message box
            // else if it's a tie 
            //    display a message box
        }

        private bool IsRowWinner(int row)
        {
            // if square(row, 0) = square(row, 1) = square(row, 2) AND square(row, 0) is not empty
            //      highlight the row
            //      return true
            // else
            //      return false
        }

        private bool IsAnyRowWinner()
        {
        }

        private bool IsColumnWinner(int col)
        {
        }

        private bool IsAnyColumnWinner()
        {
        }

        private bool IsAnyDiagonalWinner()
        {
        }

        private bool IsWinner()
        {
        }

        private bool IsFull()
        {
        }

        private bool IsTie()
        {
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            if (clickedLabel.Text == "")
            {
                int row, column;
                GetRowAndColumn(clickedLabel, out row, out column);

                clickedLabel.Text = userSymbol.ToString();
                clickedLabel.Enabled = false;

                if (IsWinner())
                    MessageBox.Show("You win!");
                else if (IsFull())
                    MessageBox.Show("It's a Tie!");
                else
                    MakeComputerMove();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

    }
}
