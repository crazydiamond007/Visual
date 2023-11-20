using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider2
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                errorProvider1.Clear();
                double number = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox2.Text);
                double result = 1; 
                if (radioButton1.Checked){
                    result = number + number2;
                    button1.Text = " = " + result;
                }
                else if(radioButton2.Checked){
                    result = number - number2;
                    button1.Text = " = " + result;
                }
                else if(radioButton3.Checked){
                    for (int i = 0; i < number2; i++) {
                        result *= number;
                    }
                    
                    button1.Text = " = " + result;
                }

                else{
                    errorProvider1.SetError(radioButton3, "No operator selected");
                    for (int i = 0; i < number2; i++) {
                        result *= number;
                    }

                    button1.Text = " = " + result;
                }
            }
            catch (Exception){
               if(textBox1.Text == ""){
                    MessageBox.Show("Enter a number on textbox1 ");
                }else if(textBox2.Text == ""){
                    MessageBox.Show("Enter a number Please on textbox2");
                }

            }

            
        }
    }
}
