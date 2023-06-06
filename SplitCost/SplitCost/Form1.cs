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
            textBoxMoney.Text = "0";

            textBoxPeople.Text = "0";

            labelPayment.Text = "円";

            labelRemainder.Text = "円";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double addTax;
            const double Tax = 0.1;
            int wa;
            int ni;

            money = int.Parse(textBoxMoney.Text);
            ni = int.Parse(textBoxPeople.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;


            wa = money / ni;
            ni = money % ni ;

            labelRemainder.Text = ni + "円";
            labelPayment.Text = wa + "円";

        }
    }
}
