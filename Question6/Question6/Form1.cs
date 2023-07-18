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

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int  b10k, b5k, b1k, c500, c100, c50, c10, c5, c1;
            
         

            int Oturi = int.Parse(textBoxChange.Text);

          
            b5k = Oturi / 5000;
            Oturi = Oturi % 5000;
            b1k = Oturi / 1000;
            Oturi = Oturi % 1000;
            c500 = Oturi / 500;
            Oturi = Oturi % 500;
            c100 = Oturi / 100;
            Oturi = Oturi % 100;
            c50 = Oturi / 50;
            Oturi = Oturi % 50;
            c10 = Oturi / 10;
            Oturi = Oturi % 10;
            c5 = Oturi / 5;
            c1 = Oturi % 5;


            label5000yen.Text = b5k + "枚";

            label1000yen.Text = b1k + "枚";

            label500yen.Text = c500 + "枚";

            label100yen.Text = c100 + "枚";

            label50yen.Text = c50 + "枚";

            label10yen.Text = c10 + "枚";

            label5yen.Text = c5 + "枚";

            label1yen.Text = c1 + "枚";








        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5000yen_Click(object sender, EventArgs e)
        {

        }
    }
}
