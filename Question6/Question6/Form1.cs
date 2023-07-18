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

        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int charge = int.Parse(textBoxChange.Text);
            int[] money = { 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };
            int[] num = new int[money.Length];

            for (int i = 0; i < money.Length; i++)
            {
                num[i] = charge / money[i];
                charge -= num[i] * money[i];
            }

            label5000yen.Text = num[0].ToString();
            label1000yen.Text = num[1].ToString();
            label500yen.Text = num[2].ToString();
            label100yen.Text = num[3].ToString();
            label50yen.Text = num[4].ToString();
            label10yen.Text = num[5].ToString();
            label5yen.Text = num[6].ToString();
            label1yen.Text = num[7].ToString();
        }
    }
}
