using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Mass_and_Weight_Problem
{
    public partial class weightCalculator : Form
    {
        public weightCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight, mass;
            double.TryParse(num1.Text, out mass);
            weight = mass * 9.8;

            if (weight <= 10)
            {
                MessageBox.Show("Your object is too light.");
            }
            else if (weight >= 1000)
            {
                MessageBox.Show("Your object is too heavy.");
            }
            else
            {
                MessageBox.Show("The weight of your object is " + weight);
            }
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
             
            
        }
    }
}
