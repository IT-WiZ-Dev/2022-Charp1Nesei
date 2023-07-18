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
            int over = 0;
            
            int change5000 = change / 5000;
            over = change % 5000;

            int change1000 = over / 1000;
            over = over % 1000;

            int change500 = over / 500;
            over = over % 500;
            
            int change100 = over / 100;
            over = over % 100;
            
            int change50 = over / 50;
            over = over % 50;
            
            int change10 = over / 10;
            over = over % 10;
            
            int change5 = over / 5;
            over = over % 5;
            
            int change1 = over / 1;
            over = over % 1;

            label5000yen.Text = change5000.ToString();
            label1000yen.Text = change1000.ToString();
            label500yen.Text  = change500.ToString();
            label100yen.Text  = change100.ToString();
            label50yen.Text  = change50.ToString();
            label10yen.Text  = change10.ToString();
            label5yen.Text  = change5.ToString();
            label1yen.Text  = change1.ToString();
        }
    }
}
