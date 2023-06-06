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

        private void button1_Click(object sender, EventArgs e)
        {
            int money, people, mod;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(textBoxPeople.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            mod = money % people;
            money = money / people;

            labelMoney.Text = money + " 円";
            labelMod.Text = mod + " 円";
        }
    }
}
