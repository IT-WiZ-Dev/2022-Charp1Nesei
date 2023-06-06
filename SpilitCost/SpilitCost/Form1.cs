using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpilitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            //入力値
            int    cost;
            int    number;
            
            //作業用
            double over;
            int    PerOne;
            
            //税
            const double tax = 1.1;

            //代入
            cost    = int.Parse(textNoTaxPrice.Text);
            number  = int.Parse(textnumber.Text);

            //税込み価格
            cost    =  (int)(cost * tax);
            
            //一人当たりと余りの計算
            PerOne  = (int)(cost / number);
            over    = cost % number;

            //ラベルに表示
            this.PerOne.Text   = PerOne + "円";
            this.over.Text     = over.ToString();



        }
    }
}
