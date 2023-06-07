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

        private void textBoxMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSplitCost_Click(object sender, EventArgs e)
        {
            int money;
            int person;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBoxMoney.Text);
            person = int.Parse(textBoxPerson.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            label7.Text = money / person + " 円";
            label8.Text = money % person + " 円";


        }

        private void FormSplitCost_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
