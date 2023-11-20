using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
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
                if (textBox1.Text != "")
                {
                    int grade = Convert.ToInt32(textBox1.Text);

                    if (grade > 100)
                    {
                        // Throw an exception if the grade is greater than 100
                        throw new Exception("Grade cannot be greater than 100.");
                    }
                    else if (grade > 90)
                    {
                        label2.Text = "A";
                    }

                    else if( grade < 90)
                    {
                        label2.Text = "Your grade is Not A";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}