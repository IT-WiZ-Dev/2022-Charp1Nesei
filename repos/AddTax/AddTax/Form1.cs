﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }
        //「消費税追加ボタン」クリックのイベントハンドラ
        private void ButtonAddTax_Click(object sender, EventArgs e)
        {
            //変換と定数の宣言
            int money;      　　　　　   //お金作業用変数
            double addTax;     　　　　　//税込み金額格納用
            const double Tax = 0.1;　　  //消費税率１０％

            //「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxMoney.Text);


            //消費税を加算し税金金額を算出

            addTax = money;

            addTax *= (1 + Tax);

            money = (int)addTax;

            //税金金額をラベルに表示
            labelAddTax.Text = money + " 円";


        　　}
        }
    }

