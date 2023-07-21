using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost_Ver._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int money, person, mod;       //金額,人数,余りの変数
            double addTax;　　　　　　  //税込み金額格納用
            const double Tax = 0.1;　　 //消費税１０％
            mod = 0;             　　　 //余り

            //「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(Zeimoney.Text);
            person = int.Parse(person1.Text);

            //消費税を加算し税込金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            mod = money % person;

            //税込金額をラベルに表示
            Bochimoney.Text = money / person + "円";
            modmoney.Text = money % person + "円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
