using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //「計算するボタン」クリックのイベントハンドラ
        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            //変換と定数の宣言

            int money;
            double addTax;
            const double Tax = 0.1;

            money = int.Parse(textBox1.Text);

            int ninzuu = int.Parse(textBox2.Text);

            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            int money2 = money / ninzuu;
            label7.Text = money2.ToString();
            int okane = money % ninzuu;
            label8.Text = okane.ToString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
////////////////////////////////////////////////////