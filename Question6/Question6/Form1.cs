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
            int money = int.Parse(textBoxChange.Text);
            int gosen = 0;
            int sen = 0;
            int gohyaku = 0;
            int hyaku = 0;
            int goju = 0;
            int ju = 0;
            int go = 0;
            int ichi = 0;

            if(money >= 5000)
            {
                gosen = money / 5000;
                money = money - gosen * 5000;
                label5000yen.Text = gosen.ToString();
            }
            else
            {
                label5000yen.Text = gosen.ToString();
            }

            if(money >= 1000)
            {
                sen = money / 1000;
                money = money - sen * 1000;
                label1000yen.Text = sen.ToString();
            }
            else
            {
                label1000yen.Text = sen.ToString();
            }

            if(money >= 500)
            {
                gohyaku = money / 500;
                money = money - gohyaku * 500;
                label500yen.Text = gohyaku.ToString();
            }
            else
            {
                label500yen.Text = gohyaku.ToString();
            }

            if (money >= 100)
            {
                hyaku = money / 100;
                money = money - hyaku * 100;
                label100yen.Text = hyaku.ToString();
            }
            else
            {
                label100yen.Text = hyaku.ToString();
            }

            if (money >= 50)
            {
                goju = money / 50;
                money = money - goju * 50;
                label50yen.Text = goju.ToString();
            }
            else
            {
                label50yen.Text = goju.ToString();
            }

            if (money >= 10)
            {
                ju = money / 10;
                money = money - ju * 10;
                label10yen.Text = ju.ToString();
            }
            else
            {
                label10yen.Text = ju.ToString();
            }

            if (money >= 5)
            {
                go = money / 5;
                money = money - go * 5;
                label5yen.Text = go.ToString();
            }
            else
            {
                label5yen.Text = go.ToString();
            }

            if (money >= 1)
            {
                ichi = money / 1;
                money = money - ichi * 1;
                label1yen.Text = ichi.ToString();
            }
            else
            {
                label1yen.Text = ichi.ToString();
            }
        }
    }
}
