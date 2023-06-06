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

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;

            int man;

            money = int.Parse(textBoxMoney.Text);
            man = int.Parse(textBoxMan.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            labelAddTax.Text = ( money / man ) + " 円";
            labelAmari.Text = (money % man) + " 円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelAddTax.Text = "";
            labelAmari.Text = "";
        }

        //ここから関係なし
        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        //ここまで関係なし
    }
}
