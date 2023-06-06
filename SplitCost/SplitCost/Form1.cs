using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double addtax;
            const double tax = 0.1;
            int 人数;
            

            money = int.Parse(textBoxmoney.Text);
            人数 = int.Parse(textBoxwarikan.Text);
            addtax = money;
            addtax *= (1 + tax);
            money = (int)addtax;

            labeladdtax.Text = (money/人数) + " 円";
            labelamari.Text = (money % 人数) + " 円";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labeladdtax.Text = "";
            labelamari.Text = "";
        }
    }
}
