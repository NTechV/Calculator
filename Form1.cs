using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double result = 0.0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text= "";
            input += "4";
            this.textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text = input;
        } 

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text
                = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text = input;
            this.textBox1.Text = input;
                 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            op = '+';
            input = string.Empty;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            op = '+';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            op = '*';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            op = '/';
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1,num2;
            
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            switch(op)
            {

                case '+':
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    break;

                    case '-':
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    break;

               
                case '*':
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    break;

                case '/':
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    if(num1 == 0)
                    {
                        textBox1.Text = "Invalid Operation!";
                    }
                    if (num2 == 0)
                    {
                        textBox1.Text = "Invalid Operation!";
                    }
                  
                    break
                        ;
                default:
                    MessageBox.Show("INVALID OP!");
                    break;

            }
        }
    }
}
