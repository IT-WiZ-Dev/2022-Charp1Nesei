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

        private void textBoxPeoples_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            // 変数と定数の宣言

            int money;                      // お金作業用変数

            int People;                     // 人数作業用変数

            double addTax;                  // 税込み金額格納用

            const double Tax = 0.1;         // 消費税率10%


            // 「税抜き金額」テキストボックスの値を整数型変数に取得

            money = int.Parse(textBoxMoney.Text);
           

            // 消費税を加算し税込金額を算出

            addTax = money;

            addTax *= (1 + Tax);

            money = (int)addTax;


            // 「人数」テキストボックスの値を整数型変数に取得

            People = int.Parse(textBoxPeople.Text);


            //一人あたりの金額をラベルに表示

            labelPerperson.Text = money/People + "円";

          
            //余りをラベルに表示

            labelRemainder.Text = money%People + "円";


















        }
    }
}
