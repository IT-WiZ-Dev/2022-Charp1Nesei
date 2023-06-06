using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1P097練習問題
{
    public partial class Form割り勘 : Form
    {
        public Form割り勘()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button割り勘_Click(object sender, EventArgs e)
        {
            //変数と定数
            int money;
            double addTax;
            const double Tax = 0;

            //
            money = int.Parse(textBoxMoney.Text);
            int nin = int.Parse(textBoxMoney2.Text);
            //消費税を加算し税込金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;
            
            label5.Text = money /nin+ "円";
            label6.Text = money % nin + "円";
            //税込金額をラベルに表示
        }
    }
}
