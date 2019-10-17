using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobBabiksBrowser
{
    public partial class Form2 : Form
    {
        double number1;
        string choice;
        public Form2()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" && textBox1!=null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            choice = "+";
        }
        private void bSub_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            choice = "-";
        }
        private void bMult_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            choice = "*";
        }
        private void bDiv_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            choice = "/";
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            double result;
            double number2;
            number2 = Convert.ToDouble(textBox1.Text);
            if(choice=="+")
            {
                result = (number1 + number2);
                textBox1.Text = Convert.ToString(result);
                number1 = result;
            }
            if (choice == "-")
            {
                result = (number1 - number2);
                textBox1.Text = Convert.ToString(result);
                number1 = result;
            }
            if(choice=="*")
            {
                result = (number1 * number2);
                textBox1.Text = Convert.ToString(result);
                number1 = result;
            }
            if(choice=="/")
            {
                if(number2==0)
                {
                    textBox1.Text = "Error: Division by 0";
                }
                else
                {
                    result = (number1 / number2);
                    textBox1.Text = Convert.ToString(result);
                    number1 = result;
                }
            }
        }
    }
}
