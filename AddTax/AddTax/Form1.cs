using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //変数宣言
            int money;
            double addTax;
            const double Tax = 0.1;

            //入力された値を代入する
            money = int.Parse(textBoxMoney.Text);


            //計算
            addTax = money;
            addTax *= 1 + Tax;
            money = (int)addTax;

            //表示
            labelAddTax.Text = money + "円";


        }
    }
}
