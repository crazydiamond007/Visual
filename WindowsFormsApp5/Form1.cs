using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2;

            if (int.TryParse(textBox1.Text, out number1) && int.TryParse(textBox2.Text, out number2))
            {
                char operation = Convert.ToChar(textBox3.Text);

                try
                {
                    number1 = Convert.ToInt32(textBox1.Text);
                    number2 = Convert.ToInt32(textBox2.Text);
                    

                        
                }
                catch (Exception ex)
                {
                    if (textBox1.Text == "")
                    {
                        ErrorProvider errorProvider = new ErrorProvider();
                        errorProvider.SetError(textBox1, "Please enter a number");
                        return;
                    }
                    else if (textBox2.Text == "")
                    {
                        ErrorProvider errorProvider = new ErrorProvider();
                        errorProvider.SetError(textBox2, "Please enter a number");
                        return;
                    }
                    else if (textBox3.Text == "")
                    {
                        ErrorProvider errorProvider = new ErrorProvider();
                        errorProvider.SetError(textBox3, "Please enter an operation");
                        return;
                    }
                }
            }
            switch(operation)
            {
                case '+':
                    label2.Text = Convert.ToString(number1 + number2);
                    break;
                case '^':
                    int power = 1;
                    for (int i = 0; i < number2; i++)
                    {
                        power *= number1;
                    }
                    label2.Text = Convert.ToString(power);
                    break;
                case '*':
                    label2.Text = Convert.ToString(number1 * number2);
                    break;
                case '/':
                    // Add a check to prevent division by zero
                    if (number2 != 0)
                    {
                        label2.Text = Convert.ToString(number1 / number2);
                    }
                    else
                    {
                        label2.Text = "Error: Division by zero";
                    }
                    break;
                default:
                    label2.Text = "Error: Invalid operation";
                    break;

            }
        }
    }
}
