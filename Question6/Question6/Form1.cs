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
            int money;
            money = int.Parse(textBoxChange.Text);
            int labelnumber1 = 5000;
            int labelnumber2 = 1000;
            int labelnumber3 = 500;
            int labelnumber4 = 100;
            int labelnumber5 = 50;
            int labelnumber6 = 10;
            int labelnumber7 = 5;
            int labelnumber8 = 1;

            label5000yen.Text = money / labelnumber1 + "";
            label1000yen.Text = money / labelnumber2 + "";
            label500yen.Text = money / labelnumber3 + "";
            label100yen.Text = money / labelnumber4 + "";
            label50yen.Text = money / labelnumber5 + "";
            label10yen.Text = money / labelnumber6 + "";
            label5yen.Text = money / labelnumber7 + "";
            label1yen.Text = money / labelnumber8 + "";
        }
    }
}
