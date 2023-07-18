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
            int value1 = int.Parse(textBoxCharge.Text);
            if (value1 >= 5000)
            {
                int num1 = value1 / 5000;
                value1 = value1 - 5000*num1;
                label5000yen.Text = num1.ToString();
            }
            if (value1 >= 1000)
            {
                int num2 = value1 / 1000;
                value1 = value1 - 1000*num2;
                label1000yen.Text = num2.ToString();
            }
            if (value1 >= 500)
            {
                int num3 = value1 / 500;
                value1 = value1 - 500*num3;
                label500yen.Text = num3.ToString();
            }
            if (value1 >= 100)
            {
                int num4 = value1 / 100;
                value1 = value1 - 100*num4;
                label100yen.Text = num4.ToString();
            }
            if (value1 >= 50)
            {
                int num5 = value1 / 50;
                value1 = value1 - 50*num5;
                label50yen.Text = num5.ToString();
            }
            if (value1 >= 10)
            {
                int num6 = value1 / 10;
                value1 = value1 - 10*num6;
                label10yen.Text = num6.ToString();
            }
            if (value1 >= 5)
            {
                int num7 = value1 / 5;
                value1 = value1 - 5*num7;
                label5yen.Text = num7.ToString();
            }
            label1yen.Text = value1.ToString();
        }
    }
}
