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
            int fivek = 0;
            int onek = 0;
            int fiveh = 0;
            int oneh = 0;
            int fivet = 0;
            int onet = 0;
            int five = 0;
            int one = 0;

            int yen = int.Parse(textBoxChange.Text);

            if (yen >= 5000)
            {
                fivek = yen / 5000;
                yen -= fivek * 5000;
            }
            
            if (yen >= 1000)
            {
                onek = yen / 1000;
                yen -= onek * 1000;
            }
            if (yen >= 500)
            {
                fiveh = yen / 500;
                yen -= fiveh * 500;
            }
            if (yen >= 100)
            {
                oneh = yen / 100;
                yen -= oneh * 100;
            }
            if (yen >= 50)
            {
                fivet = yen / 50;
                yen -= fivet * 50;
            }
            if (yen >= 10)
            {
                onet = yen / 10;
                yen -= onet * 10;
            }
            if (yen >= 5)
            {
                five = yen / 5;
                yen -= five * 5;
            }
            if(yen >= 1)
            {
                one = yen / 1;
                yen = one;
            }

            label5000yen.Text = fivek.ToString();
            label1000yen.Text = onek.ToString();
            label500yen.Text = fiveh.ToString();
            label100yen.Text = oneh.ToString();
            label50yen.Text = fivet.ToString();
            label10yen.Text = onet.ToString();
            label5yen.Text = five.ToString();
            label1yen.Text = one.ToString();
                
        }
    }
}
