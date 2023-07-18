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
        
        static void main( string[] args)
        {
            int money;
            

            Console.WriteLine("金額を入力");
            
            var b5000 = money / 5000;
           
            money %= 5000;
            var b1000 = money / 1000;
            
            money %= 1000;
            var c500 = money / 500;
           
            money %= 500;
            var c100 = money / 100;
           
            money %= 100;
            var c50 = money / 50;
            
            money %= 50;
            var c10 = money / 10;
            
            money %= 10;
            var c5 = money / 5;
            
            money %= 5;
            var c1 = money / 1;
           
        }

    }
}
