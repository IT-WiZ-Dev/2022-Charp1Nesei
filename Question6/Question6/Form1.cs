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
            int val = 0;
            CheckMoney(textBoxChange.Text,out val);

            //もし入力された値が整数でなかったらエラーとして処理
            if (val < 0)
            {
                textBoxChange.Text = "Error";
            }
            else
            {
                //本題のメソッド
                Money(int.Parse(textBoxChange.Text));
            }
        }


        //入力された値が整数かどうか判定するメソッド
        private void CheckMoney(string num,out int val)
        {
            if (int.TryParse(num, out val) == false)
              val = -1;
        }



        //ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
        //お釣りをラベルに代入するメソッド
        //YOURLIFE：残りの金額
        //Chargeがお釣りの枚数
        private void Money(int YOURLIFE)
        {
            int Charge;

            //5000円
            Charge = YOURLIFE / 5000;
            label5000yen.Text = "X" + Charge;
            YOURLIFE %= 5000;

            //1000円
            Charge = YOURLIFE / 1000;
            label1000yen.Text = "X" + Charge;
            YOURLIFE %= 1000;

            //500円
            Charge = YOURLIFE / 500;
            label500yen.Text = "X" + Charge;
            YOURLIFE %= 500;

            //100円
            Charge = YOURLIFE / 100;
            label100yen.Text = "X" + Charge;
            YOURLIFE %= 100;

            //50円
            Charge = YOURLIFE / 50;
            label50yen.Text = "X" + Charge;
            YOURLIFE %= 50;

            //10円
            Charge = YOURLIFE / 10;
            label10yen.Text = "X" + Charge;
            YOURLIFE %= 10;

            //5円
            Charge = YOURLIFE / 5;
            label5yen.Text = "X" + Charge;
            YOURLIFE %= 5;

            //1円
            Charge = YOURLIFE;
            label1yen.Text = "X" + Charge;
        }

    }
}
