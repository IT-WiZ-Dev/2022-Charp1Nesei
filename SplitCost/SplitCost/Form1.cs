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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int peaple;
            double addTax;
            const double Tax = 0.1;
            int warikan;
            int amari;

            money = 0;
            peaple = 0;
            
            money = int.Parse(textBox1.Text);
            peaple = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            warikan = (money / peaple);
            amari = money % peaple;

            label7.Text = warikan + "円";
            label8.Text = amari + "円";



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
