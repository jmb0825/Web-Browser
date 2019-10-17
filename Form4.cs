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
    public partial class Form4 : Form
    {
        string from;
        string to;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            from = fromBox.Text;
        }

        private void toBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            to = toBox.Text;
        }

        private void getResults_Click(object sender, EventArgs e)
        {
            double number;
            double result;
            double.TryParse(input.Text, out number);
            if (from=="U.S. Dollars")
            {
                if(to=="U.S. Dollars")
                {
                    result = number;
                    textBox1.Text = Convert.ToString(result);
                }
                if(to=="Canadian Dollars")
                {
                    result = number * 1.31;
                    textBox1.Text = Convert.ToString(result);
;               }
                if(to=="Mexican Pesos")
                {
                    result = number * 19.86;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Euros")
                {
                    result = number * 0.88;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Chinese Yuan")
                {
                    result = number * 6.93;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Japanese Yen")
                {
                    result = number * 113.66;
                    textBox1.Text = Convert.ToString(result);
                }
            }
            if (from == "Canadian Dollars")
            {
                if (to == "U.S. Dollars")
                {
                    result = number*0.76;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Canadian Dollars")
                {
                    result = number;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Mexican Pesos")
                {
                    result = number * 15.14;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Euros")
                {
                    result = number * 0.67;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Chinese Yuan")
                {
                    result = number * 5.28;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Japanese Yen")
                {
                    result = number * 86.64;
                    textBox1.Text = Convert.ToString(result);
                }
            }
            if (from == "Mexican Pesos")
            {
                if (to == "U.S. Dollars")
                {
                    result = number*0.05;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Canadian Dollars")
                {
                    result = number *0.066;
                    textBox1.Text = Convert.ToString(result);
                    ;
                }
                if (to == "Mexican Pesos")
                {
                    result = number;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Euros")
                {
                    result = number * 0.044;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Chinese Yuan")
                {
                    result = number * 0.35;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Japanese Yen")
                {
                    result = number * 5.72;
                    textBox1.Text = Convert.ToString(result);
                }
            }
            if (from == "Euros")
            {
                if (to == "U.S. Dollars")
                {
                    result = number*1.14;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Canadian Dollars")
                {
                    result = number * 1.5;
                    textBox1.Text = Convert.ToString(result);
                    ;
                }
                if (to == "Mexican Pesos")
                {
                    result = number * 22.69;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Euros")
                {
                    result = number;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Chinese Yuan")
                {
                    result = number * 7.92;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Japanese Yen")
                {
                    result = number * 129.88;
                    textBox1.Text = Convert.ToString(result);
                }
            }
            if (from == "Chinese Yuan")
            {
                if (to == "U.S. Dollars")
                {
                    result = number*0.14;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Canadian Dollars")
                {
                    result = number * 0.19;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Mexican Pesos")
                {
                    result = number * 2.86;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Euros")
                {
                    result = number * 0.13;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Chinese Yuan")
                {
                    result = number;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Japanese Yen")
                {
                    result = number * 16.4;
                    textBox1.Text = Convert.ToString(result);
                }
            }
            if (from == "Japanese Yen")
            {
                if (to == "U.S. Dollars")
                {
                    result = number * 0.0088;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Canadian Dollars")
                {
                    result = number * 0.012;
                    textBox1.Text = Convert.ToString(result);
                    ;
                }
                if (to == "Mexican Pesos")
                {
                    result = number * 0.17;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Euros")
                {
                    result = number * 0.0077;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Chinese Yuan")
                {
                    result = number*0.061;
                    textBox1.Text = Convert.ToString(result);
                }
                if (to == "Japanese Yen")
                {
                    result = number;
                    textBox1.Text = Convert.ToString(result);
                }
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
