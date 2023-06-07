using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCostc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kin = int.Parse(textBox1.Text);
            double zei = kin * 1.1;
            int nin = int.Parse(textBox2.Text);
            int syou = (int)zei / nin;
            int amari = (int)zei % nin;
            label6.Text = syou + "円";
            label8.Text = amari + "円";
        }
    }
}
