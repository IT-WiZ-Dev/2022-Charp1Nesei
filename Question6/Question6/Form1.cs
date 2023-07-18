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
            int oturi = int.Parse(textBoxChange.Text);
            int sen = oturi / 1000;   //１０００円台
            int hyaku = oturi % 1000;　//１００円台
            int zyuu = oturi % 100;     //１０円台
            int ichi = oturi % 10;   //１円台

            int gosen = sen / 5;
            int sen1 = sen - gosen * 5;
            int gohyaku = hyaku / 500;
            int hyaku1 = hyaku - gohyaku * 5;
            int gozyuu = zyuu / 50;
            int zyuu1 = zyuu - gozyuu * 5;
            int go = ichi / 5;
            int ichi1 = ichi - go * 5;

            label5000yen.Text = gosen.ToString();
            label1000yen.Text = sen1.ToString();
            label500yen.Text = gohyaku.ToString();
            label100yen.Text = hyaku1.ToString();
            label50yen.Text = gozyuu.ToString();
            label10yen.Text = zyuu1.ToString();
            label5yen.Text = go.ToString();
            label1yen.Text = ichi1.ToString();


        }
    }
}
