using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            double addTax;
            const double Tax = 0.1;
            double wari;
            double amari;


            money = int.Parse(textBox2.Text);
            people = int.Parse(textBox1.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            wari = money / people;
            amari = money % people;
            label7.Text = wari+"円" ;
            label8.Text = amari +"円";





            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
