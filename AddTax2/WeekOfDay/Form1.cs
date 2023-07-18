using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckWeek();
           bool isUruu= UruuYear();

           bool isCrear= Checkdate(isUruu);

            if (isCrear == false)
            {
                label4.Text = "ありえない日付";

            }





        }
        //うるう年かどうか判定するメソッド
        private bool UruuYear()
        {
            uint year;
            if(uint.TryParse(textBox1.Text,out year) == false)
            {
                label4.Text = "西暦年エラー";
            }

            bool isUruu = false;

            if(year%4==0 && year % 100 != 0)
            {
                isUruu = true;
            }
            return isUruu;
                
                
        }

        //年月日の妥当性チェックを行うメソッド
        private bool Checkdate(bool isUruu)
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
           
            bool isCrear = true;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 31)
                    {
                        isCrear = false; 
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                    {
                        isCrear = false;
                    }
                    break;

                case 2:
                    if ((isUruu==true&&day>29)||(isUruu==false&&day>28))
                    {
                        
                        
                            isCrear = false;
                        
                       
                    }
                    
                    break;




            }
            return isCrear;
        
        }

        //西暦年、月、日から曜日を求める
       private void CheckWeek()
        {
            int y = int.Parse(textBox1.Text);
            int m = int.Parse(numericUpDown1.Text);
            int d = int.Parse(numericUpDown2.Text);
            int w;
            w = (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;

            switch (w)
            {
                case 0:
                    label4.Text = "日曜日です。";
                    break;
                case 1:
                    label4.Text = "月曜日です。";
                    break;
                case 2:
                    label4.Text = "火曜日です。";
                    break;
                case 3:
                    label4.Text = "水曜日です。";
                    break;
                case 4:
                    label4.Text = "木曜日です。";
                    break;
                case 5:
                    label4.Text = "金曜日です。";
                    break;
                case 6:
                    label4.Text = "土曜日です。";
                    break;
            }
            
            






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
