using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //消費税を加算し金額を算出
            int money;
            int people;
            double addTax;
            int moneyPerPeople;
            int moneyLeft;
            const double Tax = 0.1;
            //金額
            money = int.Parse(textmoney.Text);
            people = int.Parse(textpeople.Text);          //
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            moneyPerPeople = money / people;
            moneyLeft = money % people;

            label7.Text = moneyPerPeople + "円";
            label8.Text = moneyLeft + "円";



           
        }

        private void money_TextChanged(object sender, EventArgs e)
        {

        }

        private void people_Click(object sender, EventArgs e)
        {

        }
    }
}
