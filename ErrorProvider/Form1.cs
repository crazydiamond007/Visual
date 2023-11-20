using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox2.Text);
                char operation = Convert.ToChar(textBox3.Text);
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = number1 + number2;
                        label2.Text = " Answer: "+ result.ToString();
                        break;
                    case '-':
                        result = number1 - number2;
                        label2.Text = " Answer: " + result.ToString();  
                        break;
                    case '*':
                        result = number1 * number2;
                        label2.Text = " Answer: " + result.ToString();  
                        break;
                    case '/':
                        if (number2 == 0)
                        {
                            errorProvider1.SetError(textBox2, "Cannot divide by zero");
                        }
                        else
                        {
                            result = number1 / number2;
                            label2.Text += result.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Please enter a number");
                }
                else if (textBox2.Text == "")
                {
                    errorProvider1.SetError(textBox2, "Please enter a number");
                }
                else if (textBox3.Text == "")
                {
                    errorProvider1.SetError(textBox3, "Please enter an operation");
                }
            }
        }
        
    }
}
