using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        //click event with private method Calculate
        private void calcButton_Click(object sender, EventArgs e)
        {
            //validation for operands
            try
            {
                if (IsValidData())
                {
                    decimal operand1 = Convert.ToDecimal(operandTextBox1.Text);
                    string operator1 = operandTextBox1.Text;
                    decimal operand2 = Convert.ToDecimal(operand2TextBox.Text);

                    Calculate(operand1, operand2);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("A format exception has occurred. Please check all entries.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occurred. Please enter smaller values.", "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Dividing by zero is not allowed. Please check operand entries.", "Entry Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // methods for IsPresent, IsDecimal, IsWithinRange, and IsOperator
        public bool IsPresent(TextBox textBox, string name)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error.");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if(Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if(number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsOperator(TextBox textBox, string name, string add, string subtract, string multiply, string divide)
        {
            string symbol = Convert.ToString(textBox.Text);
            if(symbol != add && symbol != subtract && symbol != multiply && symbol != divide)
            {
                MessageBox.Show(name + " must be +, -, *, or /.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //public method that that uses created methods to check validity
        public bool IsValidData()
        {
            return
                //validate operand 1
                IsPresent(operandTextBox1, "Operand 1") &&
                IsDecimal(operandTextBox1, "Operand 1") &&
                IsWithinRange(operandTextBox1, "Operand 1", 1, 1000000) &&

                //validate operand 2
                IsPresent(operand2TextBox, "Operand 2") &&
                IsDecimal(operand2TextBox, "Operand 2") &&
                IsWithinRange(operand2TextBox, "Operand 2", 1, 1000000) &&

                //validate operator
                IsOperator(operatorTextBox, "Operator", "+", "-", "*", "/");
        }

        //private method that does the calculations
        private void Calculate(decimal operand1, decimal operand2)
        {
            //switch statement that used the operator to perform calculations
            //also displays error message if wrong operator is used
            switch (operatorTextBox.Text)
            {
                case "+":
                    resultTextBox.Text = (operand1 + operand2).ToString("f4");
                    break;
                case "-":
                    resultTextBox.Text = (operand1 - operand2).ToString("f4");
                    break;
                case "*":
                    resultTextBox.Text = (operand1 * operand2).ToString("f4");
                    break;
                case "/":
                    resultTextBox.Text = (operand1 / operand2).ToString("f4");
                    break;
                default:
                    MessageBox.Show("You can only use +, -, *, or /");
                    break;
            }

            operandTextBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearResult(object sender, EventArgs e)
        {
            resultTextBox.Text = "";

        }
    }
}
