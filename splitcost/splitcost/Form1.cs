using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splitcost
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

        private void button1_Click(object sender, EventArgs e)
        {
            double syo;
            double amari;
            int money;
            double addTax;
            const double Tax = 0.1;
            int people;

            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(textBoxPeople.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;


            amari = money % people;
            syo = money / people;

            syo1.Text = syo + "円";
            amari1.Text = amari + "円";
        }
    }
}
