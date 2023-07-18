using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int change = int.Parse(textBoxChange.Text);
            int higuti = 0;
            int noguti = 0;
            int fivehun = 0;
            int onehun = 0;
            int fifty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            while(change >= 5000)
            {
                higuti += 1;
                change -= 5000;
            }
            while(change >= 1000)
            {
                noguti += 1;
                change -= 1000;
            }
            while(change >= 500)
            {
                fivehun += 1;
                change -= 500;
            }
            while(change >= 100)
            {
                onehun += 1;
                change -= 100;
            }
            while(change >= 50)
            {
                fifty += 1;
                change -= 50;
            }
            while(change >= 10)
            {
                ten += 1;
                change -= 10;
            }
            while(change >= 5)
            {
                five += 1;
                change -= 5;
            }
            while(change >= 1)
            {
                one += 1;
                change -= 1;
            }
            label5000yen.Text = higuti.ToString();
            label1000yen.Text = noguti.ToString();
            label500yen.Text = fivehun.ToString();
            label100yen.Text = onehun.ToString();
            label50yen.Text = fifty.ToString();
            label10yen.Text = ten.ToString();
            label5yen.Text = five.ToString();
            label1yen.Text = one.ToString();
        }
    }
}
