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
            textBox1.Text = "0";
            TextBox2.Text = "0";
            label7.Text = "";
            label8.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;
            int human;
            
            int amari;

            money = int.Parse(textBox1.Text);
            human = int.Parse(TextBox2.Text);
           

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            amari = money % human;
            money = money / human;

            label7.Text = money + "円";
            label8.Text = amari + "円";



            



           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
