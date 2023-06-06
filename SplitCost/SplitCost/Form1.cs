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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);
            int nin = int.Parse(textBox2.Text);
            money = (int)(money * 1.1);

            int amari = money % nin;

            money = money / nin;
            label7.Text = money.ToString()+ "円";
            
            label8.Text = amari.ToString()+"円";
        }
    }
}
