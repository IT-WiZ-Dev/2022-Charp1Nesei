using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost_
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int syo;
            int amari;
            int money;                //お金作業用変数
            double addTax;            //税込金額格納用
            const double Tax = 0.1;   //消費税率10％
            int people;

            // 「税抜き金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxmoney.Text);
            
            //「人数」テキストボックスの値を整数型変数に取得
            people = int.Parse(textBoxpeople.Text );

            //消費税を加算し税込金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            //消費税込み金額から人数で割り余りを出す
            amari = money % people;
            //消費税込み金額から人数で割り商を出す
            syo = money / people;

            //一人当たりの金額を表示
            syo1.Text = syo + "円";

            //余りを表示
            amari1.Text = amari + "円";










        }
    }
}
