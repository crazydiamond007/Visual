using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = "";
            Name = textBox1.Text;
            String gender = "";
            label5.Text = "You are " + Name;
            if(radioButton1.Checked )
            {
                gender = "Male";
                label5.Text += " " + " Male";
            }else if(radioButton2.Checked )
            {
                gender = "Female";
                label5.Text += " " + " Female";
            }

            if(comboBox1.Text == "")
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(comboBox1, "Choose your age");
            }
            else
            {
                label5.Text += " " + comboBox1.Text;
            }

            if (comboBox2.Text == "")
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(comboBox2, "Choose your departement");
            }
            else
            {
                label5.Text += " " + comboBox2.Text;
            }
        }
    }
}
