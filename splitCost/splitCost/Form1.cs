using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            solo.Text = "";
            amari.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;


            money = int.Parse(textBox1.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            int ninzuu = int.Parse(textBox2.Text);

            int okane =  money / ninzuu;

            solo.Text = okane.ToString();

            int okane2 = money % ninzuu;

            amari.Text = okane2.ToString();


















        }
    }
}
