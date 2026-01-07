using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obsah_kruhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPocitej_Click(object sender, EventArgs e)
        {
            textInPolomer.Text = textInPolomer.Text.Replace(" ", "");
            textInJednotky.Text = textInJednotky.Text.Replace(" ", "");
            if (textInPolomer.Text != "" && textInJednotky.Text != "")
            {
                double polomer = Convert.ToInt32(textInPolomer.Text);

                double obvod = Math.Round(2 * Math.PI * polomer, 5, MidpointRounding.AwayFromZero);
                double obsahspravne = Math.Round(Math.PI * Math.Pow(polomer, 2), 5, MidpointRounding.AwayFromZero);

                string outtextobsah = $"Obsah: {obsahspravne}² {textInJednotky.Text}";
                string outtextobvod = $"Obvod: {obvod} {textInJednotky.Text}";

                textOut.Text = outtextobsah;
                textOut.Text += Environment.NewLine;
                textOut.Text += outtextobvod;
            }
            else
            {
                textOut.Text = "zadej všechny parametry";
            }
        }

        private void textInPolomer_TextChanged(object sender, EventArgs e)
        {
            buttonPocitej_Click(sender, e);
        }

        private void textInJednotky_TextChanged(object sender, EventArgs e)
        {
            buttonPocitej_Click(sender, e);
        }
    }
}
