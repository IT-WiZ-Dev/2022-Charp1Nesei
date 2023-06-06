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

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int human;
            double addTax;
            const double Tax = 0.1;
            int amari;
            int hitori;

            money = int.Parse(textBoxMoney.Text);
            human = int.Parse(textBoxhuman.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            hitori = money / human;
            amari = money - hitori * human;

            labelhitori.Text = hitori + " 円";
            labelamari.Text = amari + " 円";


        }
    }
}
