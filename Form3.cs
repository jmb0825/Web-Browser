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
    public partial class Form3 : Form
    {
        string from;
        string to;
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            from = comboBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Imperial1_SelectedIndexChanged(object sender, EventArgs e)
        {
            to= Imperial1.Text;
        }

        private void results1_Click(object sender, EventArgs e)
        {
            double number;
            double result;
            if(from=="Meters")
            {
                if(to=="Inches")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number * (39.37);
                    result1.Text= Convert.ToString(result);
                }
                if(to=="Miles")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (1609.344);
                    result1.Text = Convert.ToString(result);
                }
                if(to=="Feet")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number * (3.281);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Yards")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number * (1.094);
                    result1.Text = Convert.ToString(result);
                }
            }
            if (from == "Kilometers")
            {
                if (to == "Inches")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number * (39370.079);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Miles")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (1.609);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Feet")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number * (3280.84);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Yards")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number * (1093.61);
                    result1.Text = Convert.ToString(result);
                }
            }
            if (from == "Centimeters")
            {
                if (to == "Inches")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number /(2.54);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Miles")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (160934.4);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Feet")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (30.48);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Yards")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (91.44);
                    result1.Text = Convert.ToString(result);
                }
            }
            if (from == "Millimeters")
            {
                if (to == "Inches")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (25.4);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Miles")
                {
                    //double.TryParse(textBox1.Text, out number);
                    //result = number / (160934.4);
                    result1.Text = "Please don't";
                }
                if (to == "Feet")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (304.8);
                    result1.Text = Convert.ToString(result);
                }
                if (to == "Yards")
                {
                    double.TryParse(textBox1.Text, out number);
                    result = number / (914.4);
                    result1.Text = Convert.ToString(result);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void imperialSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            from = imperialSelection.Text;
        }

        private void metricSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            to = metricSelection.Text;
        }

        private void results2_Click(object sender, EventArgs e)
        {
            double number;
            double result;
            if (from == "Inches")
            {
                if (to == "Meters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number / (39.37);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Kilometers")
                {
                    //double.TryParse(input2.Text, out number);
                    //result = number / (39370.079);
                    textBox2.Text = "Result too small";
                }
                if (to == "Millimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (25.4);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Centimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (2.54);
                    textBox2.Text = Convert.ToString(result);
                }
            }
            if (from == "Miles")
            {
                if (to == "Meters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (1609.344);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Kilometers")
                {
                    double.TryParse(input2.Text, out number);
                    result = number / (1.609);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Centimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (160934.4);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Millimeters")
                {
                    //double.TryParse(input2.Text, out number);
                    //result = number * (1093.61);
                    textBox2.Text = "Result too large";
                }
            }
            if (from == "Feet")
            {
                if (to == "Meters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number / (3.281);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Kilometers")
                {
                    double.TryParse(input2.Text, out number);
                    result = number / (3280.84);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Centimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (30.48);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Millimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (304.8);
                    textBox2.Text = Convert.ToString(result);
                }
            }
            if (from == "Yards")
            {
                if (to == "Meters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number / (1.094);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Kilometers")
                {
                    double.TryParse(input2.Text, out number);
                    result = number / (1093.613);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Centimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (91.44);
                    textBox2.Text = Convert.ToString(result);
                }
                if (to == "Millimeters")
                {
                    double.TryParse(input2.Text, out number);
                    result = number * (914.4);
                    textBox2.Text = Convert.ToString(result);
                }
            }
        }
    }
}
