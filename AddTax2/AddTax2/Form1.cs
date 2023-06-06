using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax2
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
            double addtax;
            const double Tax = 0.1;
            int number;
            int waru;
            int amari;

            number = int.Parse(textBoxnumber.Text);

            money = int.Parse(textBoxmoney.Text);

            addtax = money;
            addtax *= (1 + Tax);
            money = (int)addtax;

           
            waru = money / number;
            labelwaru.Text = waru + "円";

            amari = money % number;
            labelamari.Text = amari + "円";



        }
    }
}
