using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rensyu_p096
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
            int nin;
            double zei;
            double solo;
            int amari;
            const double zeiritu = 0.1;
            
            money = int.Parse(textBox1.Text);
            nin = int.Parse(textBox2.Text);

            zei = money;
            zei *= (1 + zeiritu);
            money = (int)zei;
            solo = money / nin;
            amari = money % nin;


            label6.Text = solo.ToString() + "円";
            label8.Text = amari.ToString() + "円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
