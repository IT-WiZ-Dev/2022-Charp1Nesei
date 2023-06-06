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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int number;
            double SplitCost;
            const double Cost = 0.1;
            double wari;
            double amari;

            money = int.Parse(textBox1.Text);
            number = int.Parse(textBox2.Text);

            SplitCost = money;
            SplitCost *= (1 + Cost);
            money = (int)SplitCost;
            wari = money / number;
            amari = money % number;

            label6.Text = wari + "円";
            label8.Text = amari + "円";


        }
    }
}
