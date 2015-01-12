using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Calculator aCalculator = new Calculator();
        private void additionButton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = aCalculator.Add(Convert.ToDouble(first_NumbertextBox.Text), Convert.ToDouble(second_NumbertextBox.Text)).ToString();
        
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            resulttextBox.Text = aCalculator.Subtract(Convert.ToDouble(first_NumbertextBox.Text), Convert.ToDouble(second_NumbertextBox.Text)).ToString();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {

            resulttextBox.Text = aCalculator.Multiply(Convert.ToDouble(first_NumbertextBox.Text), Convert.ToDouble(second_NumbertextBox.Text)).ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {

            resulttextBox.Text = aCalculator.Divide(Convert.ToDouble(first_NumbertextBox.Text), Convert.ToDouble(second_NumbertextBox.Text)).ToString();
        }
    }
}
