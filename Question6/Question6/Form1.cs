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
            int Charge = 0;
            Charge=int.Parse(textBoxChange.Text);
            label5000yen.Text = (Charge / 5000).ToString();
            Charge = Charge - (5000*int.Parse(label5000yen.Text));
            label1000yen.Text = (Charge / 1000).ToString();
            Charge = Charge - (1000*int.Parse(label1000yen.Text));
            label500yen.Text = (Charge / 500).ToString();
            Charge = Charge - (500*int.Parse(label500yen.Text));
            label100yen.Text = (Charge / 100).ToString();
            Charge = Charge - (100*int.Parse(label100yen.Text));
            label50yen.Text = (Charge / 50).ToString();
            Charge = Charge - (50*int.Parse(label50yen.Text));
            label10yen.Text = (Charge / 10).ToString();
            Charge = Charge - (10*int.Parse(label10yen.Text));
            label5yen.Text = (Charge / 5).ToString();
            Charge = Charge - (5*int.Parse(label5yen.Text));
            label1yen.Text = (Charge / 1).ToString();
            Charge = Charge - (1*int.Parse(label1yen.Text));
        }
    }
}
