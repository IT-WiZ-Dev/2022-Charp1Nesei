using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習問題p097
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;                    //お金作業用変数
            int people;                   //人数
            double addTax;               //消費税込みの割り勘の額格納
            double amari;                //余り格納
            const double Tax = 0.1;      //消費税率10%

            //金額と人数のテキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxmoney.Text);
            people = int.Parse(textBoxppl.Text);

            
            addTax = money;
            addTax *= (1 + Tax);
            amari = addTax % people;
            addTax /= people;
            money = (int)addTax;
            


            label3hitori.Text = money + "円";
            label4amari.Text = amari + "円";


        }
    }
}
