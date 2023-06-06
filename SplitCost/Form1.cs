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
    public partial class SplitCost : Form
    {
        public SplitCost()
        {
            InitializeComponent();
        }
        private void SplitCost_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label8.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int nop;
            double mpn, remainder, addTax;
            const double Tax = 0.1;

            money = int.Parse(textBox1.Text);
            nop = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            mpn = money / nop;
            remainder = money % nop;

            label6.Text = mpn + "円";
            label8.Text = remainder + "円";



        }

       
    }
}
