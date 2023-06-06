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

        private void button1_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int money; //お金作業用変数
            int ninnzuu;
            int amari;
            double addTax; //税込み金額格納用
            const double Tax = 0.1; //消費税率10％

            //「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBox1.Text);

            ninnzuu = int.Parse(hito.Text);

            //計算
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            amari = money % ninnzuu;
            money = money / ninnzuu;

            //税込金額をラベルに表示
            label9.Text = money + "円";
            label10.Text = amari + "円";


        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
