using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try {
                int userInput, i;
                double Pi = 4, num1 = 4, den = 3;
                userInput = Convert.ToInt32(inputLabel1.Text);
                for (i = 0; i <= userInput; i++)
                {

                    if (i % 2 == 0)
                    {
                        Pi -= num1 / den;
                    }
                    else
                    {
                        Pi += num1 / den;
                    }
                    den += 2;
                }
                inputLabel2.Text = "Approximate value of pi after " + userInput + " terms";
                solution.Text = "= " + Pi;
            }
            catch { MessageBox.Show("Please enter a number."); }
            }
    }
}
