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
            int kane, satu5000, satu1000, tama500, tama100, tama50, tama10, tama5, tama1, amari;
            kane = int.Parse(textBoxChange.Text);



            amari = kane % 5000;
            
            satu5000 = kane / 5000;


            label5000yen.Text = satu5000 + "枚";



            satu1000 = amari / 1000;
            amari = amari % 1000;
            

            label1000yen.Text = satu1000 + "枚";



            tama500 = amari / 500;
            amari = amari % 500;
            

            label500yen.Text = tama500 + "枚";




            tama100 = amari / 100;
            amari = amari % 100;
            


            label100yen.Text = tama100 + "枚";


            tama50 = amari / 50;
            amari = amari % 50;
           

            label50yen.Text = tama50 + "枚";


            tama10 = amari / 10;
            amari = amari % 10;
            


            label10yen.Text = tama10 + "枚";


            tama5 = amari / 5;
            amari = amari % 5;
            

            label5yen.Text = tama5 + "枚";


            tama1 = amari / 1;
            amari = amari % 1;
            

            label1yen.Text = tama1 + "枚";






        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
