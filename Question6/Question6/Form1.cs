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

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5000yen.Text = "";
            label1000yen.Text = "";
            label500yen.Text = "";
            label100yen.Text = "";
            label50yen.Text = "";
            label10yen.Text = "";
            label5yen.Text = "";
            label1yen.Text = "";

        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(textBoxChange.Text);
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int t = 0;
            int f = 0;
            int g = 0;
            int h = 0;

            while (i >= 0)
            {
                if (i >= 5000)
                {
                    a++;
                    i -= 5000;
                }
                else if (i >= 1000)
                {
                    b++;
                    i -= 1000;
                }
                else if (i >= 500)
                {
                    c++;
                    i -= 500;
                }
                else if (i >= 100)
                {
                    d++;
                    i -= 100;
                }
                else if (i >= 50)
                {
                    t++;
                    i -= 50;
                }
                else if (i >= 10)
                {
                    f++;
                    i -= 10;
                }
                else if (i >= 5)
                {
                    g++;
                    i -= 5;
                }
                else
                {
                    h++;
                    i -= 1;
                }
            }

            label5000yen.Text = a.ToString();
            label1000yen.Text = b.ToString();
            label500yen.Text = c.ToString();
            label100yen.Text = d.ToString();
            label50yen.Text = t.ToString();
            label10yen.Text = f.ToString();
            label5yen.Text = g.ToString();
            label1yen.Text = h.ToString();
        }

        
    }
}
