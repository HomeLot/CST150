using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Magic_Dates
{
    public partial class magicNumber : Form
    {
        public magicNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double month2, day2, year2, result;
            double.TryParse(month.Text, out month2);
            double.TryParse(day.Text, out day2);
            double.TryParse(year.Text, out year2);
            result = day2 * month2;

           if (result == year2)
            {
                MessageBox.Show("Your date is magic!");
            }
           else
            {
                MessageBox.Show("Your number is not magic.");
            }
        }
    }
}
