using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            int people;
            double addtax;
            int hitori;
            int mod;
            const double Tax = 0.1;

            money = int.Parse(textBox2.Text);
            people = int.Parse(textBox1.Text);

            addtax = money;
            addtax *= (1 + Tax);
            hitori = (int)addtax / people;
            mod = (int)addtax % people;

            label7.Text = hitori +"円" ;
            label8.Text = mod + "円";








        }
    }
}
