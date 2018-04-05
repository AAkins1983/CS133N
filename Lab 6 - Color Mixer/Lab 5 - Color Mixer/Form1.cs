using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5___Color_Mixer
{
    public partial class colorMixer : Form
    {
        public colorMixer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mixing colors.
            if (redRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (redRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blueRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (blueRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (yellowRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.PaleGoldenrod;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
