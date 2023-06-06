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
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }
        //「計算するボタン」クリックのイベントハンドラー
        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言

            int money;                    //お金作業用変数
            double addTax;                //税込み金額格納用
            const double Tax = 0.1;       //消費税率10%

            //「金額」テキストボックスの値を整数型変数に習得
            money = int.Parse(textBoxMoney1.Text);
            //「人数」テキストボックスの値を整数型変数に習得
             int ninzuu = int.Parse(human.Text);
            //消費税を加算し税込金額を算出し人数で割る
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            int money2 = money / ninzuu;
            labelAddTax.Text = money2.ToString();
            int okane = money % ninzuu;
            labelAddTax2.Text = okane.ToString();

        }
    }
}
