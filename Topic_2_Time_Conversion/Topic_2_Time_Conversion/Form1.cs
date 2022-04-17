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
            double timeSec; // Store Variable
            if (double.TryParse(num1.Text, out timeSec)) // Parse and grab from texbox 'num1'
            {
                if (timeSec >= 86400)
                {
                    MessageBox.Show(timeSec / 86400 + " Days.");
                }
                else if (timeSec >= 3600) 
                {
                    MessageBox.Show(timeSec / 60 + " Hours.");
                }
         
                else if (timeSec >= 60)
                {
                    MessageBox.Show(timeSec / 60 + " Minutes.");
                }
                
            }
            else // Error message when user inputs a string instead of an integer
            {
                MessageBox.Show("Invalid Input. Please enter a number.");
            }
   
        }
    }
}
