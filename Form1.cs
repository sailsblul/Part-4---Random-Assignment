using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            if (numMax.Value > numMin.Value) {
                int number = generator.Next(Convert.ToInt32(numMin.Value), Convert.ToInt32(numMax.Value) + 1);
                lblNumber.Text = $"{number}";
            }
            else
            {
                lblNumber.Text = "ERROR";
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (numMax.Value > numMin.Value) {
                double number = Convert.ToDouble(numMin.Value) + (generator.NextDouble() * Convert.ToDouble(numMax.Value - numMin.Value));
                lblNumber.Text = $"{Math.Round(number, Convert.ToInt32(numPrecision.Value))}";
            }
            else
            {
                lblNumber.Text = "ERROR";
            }
        }

        private void numPrecision_ValueChanged(object sender, EventArgs e)
        {
            numMin.DecimalPlaces = Convert.ToInt32(numPrecision.Value);
            numMax.DecimalPlaces = Convert.ToInt32(numPrecision.Value);
        }
    }
}
