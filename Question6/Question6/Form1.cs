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
            int[] money = new int[8] { 5000, 1000, 500, 100, 50, 10, 5, 1 };
            int chr = int.Parse(textBoxCharge.Text);
            int i = 0;
            int []ans = new int [8];
            while (chr != 0) { 
            ans[i] = OtsuriCul(chr, money[i]);
            chr -= ans[i] * money[i];
            i++;
            }
            label5000yen.Text = ans[0] + "枚";
            label1000yen.Text = ans[1] + "枚";
            label500yen.Text  = ans[2] + "枚";
            label100yen.Text  = ans[3] + "枚";
            label50yen.Text   = ans[4] + "枚";
            label10yen.Text   = ans[5] + "枚";
            label5yen.Text    = ans[6] + "枚";
            label1yen.Text    = ans[7] + "枚";
        }

        static int OtsuriCul(int chr,int money)
        {
            
            int ans;       
            ans = chr / money;
            return ans;
        }
    }
}
