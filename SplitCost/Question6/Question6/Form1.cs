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

            int oturi = int.Parse(textBoxChange.Text);

            int gosen = oturi / 5000;
            oturi = oturi % 5000;
            int senen = oturi/1000;
            oturi = oturi % 1000;
            int gohyakuenn = oturi / 500;
            oturi = oturi % 500;
            int hyakuenn = oturi / 100;
            oturi = oturi % 100;
            int gozyuuenn = oturi / 50;
            oturi = oturi% 50;
            int zyuuenn = oturi/ 10;
            oturi= oturi % 10;
            int goenn = oturi / 5;
            int itienn = oturi % 5;
            

            label5000yen.Text = gosen.ToString();
            label1000yen.Text = senen.ToString();
            label500yen.Text = gohyakuenn.ToString();
            label100yen.Text = hyakuenn.ToString();
            label50yen.Text = gozyuuenn.ToString();
            label10yen.Text = zyuuenn.ToString();
            label5yen.Text = goenn.ToString();
            label1yen.Text = itienn.ToString();





        }
    }
}
