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
    public partial class FormSplitCost : Form
    {
        public FormSplitCost()
        {
            InitializeComponent();
        }

        private void buttonSplitCost_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            double AddTax;
            const double Tax = 0.1;
            int moneyPerPeople;
            int moneyLeft;

            money = int.Parse(textMoney.Text);
            people = int.Parse(textPeople.Text);

            AddTax = money;
            AddTax *= (1+Tax);
            money = (int)AddTax;

            moneyPerPeople = money / people;
            moneyLeft = money % people;


            labelMoney.Text = moneyPerPeople + "円";
            labelMoneyLeft.Text = moneyLeft + "円";

        }
    }
}
