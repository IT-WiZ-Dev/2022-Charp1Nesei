using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpilitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //変数定義
            int Money, human, ama;  //金額、人数、余りの変数
            double AddTax;
            const double Tax = 0.1;
            ama = 0;

            //税抜き金額と人数取得
            Money = int.Parse(nukiMoney.Text);
            human = int.Parse(meet.Text);

            //計算
            AddTax = Money;
            AddTax *= (1 + Tax);
            Money = (int)AddTax;
            ama = Money % human;
            Money /= human;

            //表示
            AddMoney.Text = Money + " 円";
            Amari.Text = ama + " 円";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddMoney.Text = "";
            Amari.Text = "";
        }
    }
}
