using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7___Software_Sales
{
    public partial class softwareSales : Form
    {
        public softwareSales()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double quantity;    // To hold number of packages.
            double discount;    // To hold discount amount.
            double total;       // To hold total amount.

            // Validate the Quantity Text Box.
            if (double.TryParse(quantityTextBox.Text, out quantity))
            {
                // Calculate discount and total.
                if (quantity >= 10 && quantity <= 19)
                {
                    discount = 99 * .2;
                    total = quantity * 99 - discount;

                    // Display discount and total.
                    discountOutputLabel.Text = discount.ToString();
                    totalOutputLabel.Text = total.ToString();
                }
                else if (quantity >= 20 && quantity <= 49)
                {
                    discount = 99 * .3;
                    total = quantity * 99 - discount;

                    // Display discount amount.
                    discountOutputLabel.Text = discount.ToString();
                    totalOutputLabel.Text = total.ToString();
                }
                else if (quantity >= 50 && quantity <= 99)
                {
                    discount = 99 * .4;
                    total = quantity * 99 - discount;

                    // Display discount amount.
                    discountOutputLabel.Text = discount.ToString();
                    totalOutputLabel.Text = total.ToString();
                }
                else if (quantity >= 100)
                {
                    discount = 99 * .5;
                    total = quantity * 99 - discount;
                    
                    // Display discount amount.
                    discountOutputLabel.Text = discount.ToString();
                    totalOutputLabel.Text = total.ToString();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}