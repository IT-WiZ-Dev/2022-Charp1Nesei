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
            int oturi,gos,se,goh,hya,goj,ju,go,iti;
            oturi = int.Parse(textBoxChange .Text);
            gos = oturi / 5000;
            oturi = oturi % 5000;
            se = oturi / 1000;
            oturi = oturi % 1000;
            goh = oturi / 500;
            oturi = oturi % 500;
            hya = oturi / 100;
            oturi = oturi % 100;
            goj = oturi / 50;
            oturi = oturi % 50;
            ju = oturi / 10;
            oturi = oturi % 10;
            go = oturi / 5;
            oturi = oturi % 5;
            iti = oturi;
            label5000yen.Text = gos.ToString ();
            label1000yen.Text = se.ToString();
            label500yen.Text = goh.ToString();
            label100yen.Text = hya.ToString();
            label50yen.Text = goj.ToString();
            label10yen.Text = ju.ToString();
            label5yen.Text = go.ToString();
            label1yen.Text = iti.ToString();

        }
    }
}
