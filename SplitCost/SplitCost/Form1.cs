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
            label6.Text = "";
            label8.Text = "";

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            double addTax;
            int price;
            int mod;
            const double Tax = 0.1;

            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(People.Text);

            addTax = money;
            addTax *= (1 + Tax);

            price = (int)addTax / people;
            mod = (int)addTax % people;

            label6.Text = price + "円";
            label8.Text = mod + "人";
        }
    }
}
