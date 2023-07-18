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

            int yen = 0;
            while(change>=5000)
            {
                change-=5000;
                yen++;
            }
            label5000yen.Text = yen.ToString();
            yen = 0;

            while (change >= 1000)
            {
                change -= 1000;
                yen++;
            }
            label1000yen.Text = yen.ToString();
            yen = 0;

            while (change >= 500)
            {
                change -= 500;
                yen++;
            }
            label500yen.Text = yen.ToString();
            yen = 0;

            while (change >= 100)
            {
                change -= 100;
                yen++;
            }
            label100yen.Text = yen.ToString();
            yen = 0;

            while (change >= 50)
            {
                change -= 50;
                yen++;
            }
            label50yen.Text = yen.ToString();
            yen = 0;

            while (change >= 10)
            {
                change -= 10;
                yen++;
            }
            label10yen.Text = yen.ToString();
            yen = 0;

            while (change >= 5)
            {
                change -= 5;
                yen++;
            }
            label5yen.Text = yen.ToString();

            label1yen.Text = change.ToString();
        }
    }
}
