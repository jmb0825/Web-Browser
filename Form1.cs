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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtURL.Text = webBrowser1.Url.ToString();
        }

        private void openCalc_Click(object sender, EventArgs e)
        {
            Form2 calc = new Form2();
            calc.Show();
        }

        private void openUC_Click(object sender, EventArgs e)
        {
            Form3 unit = new Form3();
            unit.Show();
        }

        private void currencybtn_Click(object sender, EventArgs e)
        {
            Form4 currency = new Form4();
            currency.Show();
        }

        private void gameBtn_Click(object sender, EventArgs e)
        {
            Form5 game = new Form5();
            game.Show();
        }
    }
}
