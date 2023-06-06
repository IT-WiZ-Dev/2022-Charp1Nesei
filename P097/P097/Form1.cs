using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P097
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
            int ninzuu;
            double addTax;
            const double Tax = 0.1;
            double wari;
            double amari;

            money = int.Parse(textBox1.Text);
            ninzuu = int.Parse(textBox2.Text);
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            wari = (int)addTax / ninzuu;
            amari = (int)addTax % ninzuu;

            label7.Text = wari + "円";
            label8.Text = amari + "円";







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";

        }
    }
}
