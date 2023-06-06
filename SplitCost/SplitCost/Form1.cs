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
            label9.Text = "";
            label10.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money, people, price, mod;   //税抜き金額、人数、一人当たりの金額、余り
            double addTax;                   //税込金額
            const double Tax = 0.1;          //消費税率10％

            money = int.Parse(textBox1.Text);
            people = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            price = (int)addTax / people;
            mod = (int)addTax % people;

            label9.Text = price + "円";
            label10.Text = mod + "円";
        }
    }
}
