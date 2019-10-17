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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        ServiceReference1.Service1Client Game;
        private void checkBtn_Click(object sender, EventArgs e)
        {
            Game = new ServiceReference1.Service1Client();
            int guess;
            int rand;
            guess = Convert.ToInt32(guessBox.Text);
            rand = Game.GetRand();
            randomnumLbl.Text = Convert.ToString(rand);
            if((Game.Compare(guess, rand)).Equals("true"))
            {
                resultLabel.Text = "You guessed right!";
            }
            else
            {
                resultLabel.Text = "Your guess was wrong.";
            }
        }

        private void guessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
