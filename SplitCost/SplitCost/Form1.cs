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

        private void buttonkeisan_Click(object sender, EventArgs e)
        {
            int member;
            int money;
            double ans,amari,addTax;
            const double Tax=0.1;

            member = int.Parse(textBox2.Text);
            money = int.Parse(textBox1.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            ans = money / member;
            amari = money % member;

            label7.Text = ans + "円";
            label8.Text = amari + "円";

        }
    }
}
