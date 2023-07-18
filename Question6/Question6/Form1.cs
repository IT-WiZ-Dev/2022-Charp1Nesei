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
           int a =  int.Parse(textBoxChange.Text) ;

            int v = 5000;
            int b = 1000;
            int g = 500;
            int f = 100;
            int d = 50;
            int w = 10;
            int u = 5;
            int o = 1;

            

            if (a > 5000)
            {
                int p = a / v;
                Console.WriteLine(label5000yen);
            }
            else if (a > 1000)
            {
                int r = a / b;
                Console.WriteLine(label1000yen);
            }
            else if (a > 500)
            {
                int y = a / g;
                Console.WriteLine(label500yen);
;
            }
            else if (a > 100)
            {
                int l = a / f;
                Console.WriteLine(label100yen);

            }
            else if (a > 50)
            {
                int x = a / d;
                Console.WriteLine(label50yen);
            }

            else if(a > 10)
            {
                int h = a / w;
                Console.WriteLine(label10yen);

            }
            else if (a> 5)
            {
                int m = a / u;
                Console.WriteLine(label5yen);
            }
            else
            {
                int k = a / o;
                Console.WriteLine(label1yen);
            }
           


        }
    }
}
