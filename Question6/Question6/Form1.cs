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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonCul_Click(object sender, EventArgs e)
        { 
            int oturi = int.Parse(textBoxChange.Text);
            int a, b, c, d, s, f, g, h = 0;
            a = oturi / 5000;
            oturi = oturi - (5000 * a);
            b = oturi / 1000;
            oturi = oturi - (1000 * b);
            c = oturi / 500;
            oturi = oturi - (500 * c);
            d = oturi / 100;
            oturi = oturi - (100 * d);
            s = oturi / 50;
            oturi = oturi - (50 * s);
            f = oturi / 10;
            oturi = oturi - (10 * f);
            g = oturi / 5;
            oturi = oturi - (5 * g);
            h = oturi / 1;
            oturi = oturi - (1 * h);

            label5000yen.Text = a.ToString();
            label1000yen.Text = b.ToString();
            label500yen.Text = c.ToString();
            label100yen.Text = d.ToString();
            label50yen.Text = s.ToString();
            label10yen.Text = f.ToString();
            label5yen.Text = g.ToString();
            label1yen.Text = h.ToString();
        }
    }
}
