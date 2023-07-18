using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int change = int.Parse(textBoxChange.Text);

            label5000yen.Text = (change / 5000).ToString();
            change = change % 5000;

            label1000yen.Text = (change / 1000).ToString();
            change = change % 1000;

            label500yen.Text = (change / 500).ToString();
            change = change % 500;

            label100yen.Text = (change / 100).ToString();
            change = change % 100;

            label50yen.Text = (change / 50).ToString();
            change = change % 50;

            label10yen.Text = (change / 10).ToString();
            change = change % 10;

            label5yen.Text = (change / 5).ToString();
            change = change % 5;

            label1yen.Text = (change / 1).ToString();
        }
    }
}
