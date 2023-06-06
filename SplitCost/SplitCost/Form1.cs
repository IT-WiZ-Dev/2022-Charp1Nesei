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

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            double addTax;
            int addTax2;
            int mod;
            const double tax = 0.1;

            money = int.Parse(textBox1.Text);
            people = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + tax);
            addTax2 = (int)addTax / people;
            mod = (int)addTax % people;
         

            label7.Text = addTax2 + "円";
            label8.Text = mod + "円";








        }
    }
}
