using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeral;
            if (int.TryParse(num1.Text, out numeral))
            {
                if (numeral == 1)
                {
                    MessageBox.Show("I");
                }
                else if (numeral == 2)
                {
                    MessageBox.Show("II");
                }
                else if (numeral == 3)
                {
                    MessageBox.Show("III");
                }
                else if (numeral == 4)
                {
                    MessageBox.Show("IV");
                }
                else if (numeral == 5)
                {
                    MessageBox.Show("V");
                }
                else if (numeral == 6)
                {
                    MessageBox.Show("VI");
                }
                else if (numeral == 7)
                {
                    MessageBox.Show("VII");
                }
                else if (numeral == 8)
                {
                    MessageBox.Show("VIII");
                }
                else if (numeral == 9)
                {
                    MessageBox.Show("IX");
                }
                else if (numeral == 10)
                {
                    MessageBox.Show("X");
                }
                else MessageBox.Show("Invalid input. Please enter a number between 1 and 10.");
            }
        }
    }
}
