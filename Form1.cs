using System;
using System.Windows.Forms;

namespace Kalkulacka2._0
{
    public partial class Form1 : Form
    {
        string firstValue;
        string secondValue;
        string finalValue;
        string calculationOperator;
        bool firstValueCompleted = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void numberButton(object sender, EventArgs e)
        {
            string buttonValue = (sender as Button).Text;
            if (firstValueCompleted == false)
            {
                firstValue = firstValue + buttonValue;
                TextovéPole.Text = firstValue;
            }
            else
            {
                if (calculationOperator == null)
                {
                    firstValueCompleted = false;
                    firstValue = null;
                    firstValue = firstValue + buttonValue;
                    TextovéPole.Text = firstValue;
                }
                else
                {
                    secondValue = secondValue + buttonValue;
                    TextovéPole.Text = secondValue;
                }

            }

        }

        private void Equals()
        {
            if (firstValue != null && secondValue != null)
            {
                finalValue = Calculation();
                TextovéPole.Text = finalValue;
                firstValue = finalValue;
                secondValue = null;
                finalValue = null;
            }
            else if (firstValue != null && secondValue == null)
            {
                firstValueCompleted = true;

            }
        }

        private string Calculation()
        {
            if (calculationOperator == "+")
            {
                return Convert.ToString(Double.Parse(firstValue) + Double.Parse(secondValue));
            }
            if (calculationOperator == "-")
            {
                return Convert.ToString(Double.Parse(firstValue) - Double.Parse(secondValue));
            }

            if (calculationOperator == "/")
            {
                return Convert.ToString(Double.Parse(firstValue) / Double.Parse(secondValue));
            }
            if (calculationOperator == "*")
            {
                return Convert.ToString(Double.Parse(firstValue) * Double.Parse(secondValue));
            }
            return null;
        }

        private void Operator(object sender, EventArgs e)
        {

            Equals();
            if (firstValue != null && secondValue == null)
            {
                TextovéPole.Text = null;
            }
            calculationOperator = (sender as Button).Text;
        }

        private void Clear(object sender, EventArgs e)
        {
            firstValue = null;
            secondValue = null;
            finalValue = null;
            calculationOperator = null;
            firstValueCompleted = false;
            TextovéPole.Text = null;
        }

        private void DeleteOne(object sender, EventArgs e)
        {
            if (firstValueCompleted == false)
            {
                if (firstValue.Length > 0)
                {
                    firstValue = firstValue.Remove(firstValue.Length - 1);
                }
                TextovéPole.Text = firstValue;
            }
            else
            {
                if (secondValue.Length > 0)
                {
                    secondValue = secondValue.Remove(secondValue.Length - 1);
                }
                TextovéPole.Text = secondValue;
            }
        }

        private void buttonEquals(object sender, EventArgs e)
        {
            Equals();
            calculationOperator = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
