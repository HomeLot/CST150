using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_2_Time_Conversion
{
    public partial class timeForm : Form
    {
        public timeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void convert1_Click(object sender, EventArgs e)
        {
            // Conversion from Seconds to Days, Hours, Minutes

            try // Exception handler
            {
                decimal timeSec; // Store variable from user input
                decimal round1, round2, round3; // outputs to be displayed and rounded


                if (decimal.TryParse(num1.Text, out timeSec)) // Parse and grab from texbox 'num1'

                {
                    if (timeSec >= 86400) // Check if user entered a number more than or equal to 86400
                    {
                        round1 = timeSec / 86400; // Store Value of Days
                        round2 = Math.Round(round1, 3); // Round days up to 3 deccimal places
                        MessageBox.Show(round1 + " Days."); // Display conversion
                    }
                    else if (timeSec >= 3600) // Check if user entered a number more than or equal to 3600
                    {
                        round2 = timeSec / 60; // Store value of hours
                        round2 = Math.Round(round2, 3); // Round hours up to 3 decimals
                        MessageBox.Show(round2 + " Hours."); // Display conversion
                    }

                    else if (timeSec >= 60) // Check if user entered a number more than or equal to 60
                    {
                        round3 = timeSec / 60; // Store value of minutes
                        round3 = Math.Round(round3, 3); // Round minutes up to 3 decimal placces      
                        MessageBox.Show(round3 + " Minutes."); // Display conversion
                    }

                }
                else // Error message when user inputs a string instead of an integer
                {
                    MessageBox.Show("Invalid Input. Please enter a number.");
                }

            }
            catch
            {
                MessageBox.Show("Unexpected Data Entry. Please Try again.");
            }
        }
                    
              
         
    }
           
}
