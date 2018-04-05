using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		
		// The ShowAceSpades method makes the Ace of Spades
        // visible and the other cards invisible. It has no parameters
		// and no return value.

        // The ShowTenHearts method makes the Ten of Hearts
        // visible and the other cards invisible.

        // The ShowKingClubs method makes the King of Clubs
        // visible and the other cards invisible.

        // The ShowCard method accepts a string that names
        // the selected card, and displays that card by calling the
		// appropriate method from above.  It has one parameter 
		// and no return value

        private void showCardButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
