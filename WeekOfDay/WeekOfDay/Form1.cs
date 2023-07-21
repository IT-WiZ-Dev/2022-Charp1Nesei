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
    //西暦と月と日付から曜日を表示
    //・うるう年かどうかの判断
    //・入力の妥当性を判断
    //・西暦と月と日付から曜日を計算

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        //閏年かどうか判定するメソッド
        private bool UruuYear()
        {
            int year = int.Parse(textBox1.Text);

            bool isUruu = false;

            if((year % 4 == 0 && year % 100 != 0 )|| year % 400 == 0)
            {
                isUruu = true;
            }

            return isUruu;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            bool isUruu = UruuYear();
            bool datousei = CheckGate();
            int year = int.Parse(textBox1.Text);
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int weekday = Days(year, month, day);

            if (year == 0 || year < 0)
            {
                label4.Text = "西暦年エラー";
            }
            if(datousei == false)
            {
                label4.Text = "あり得ない日付";
            }
            
        }

        //妥当性チェックを行うメソッド
        private bool CheckGate()
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool isUruu = UruuYear();

            bool isClear = true;

            //日付が妥当じゃなかったら
            //isClearをfalseにする処理
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if(day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                    {
                        isClear = false;
                    }
                    break;
                case 2:
                    if((isUruu == true && day > 29) || (isUruu == false && day > 28))
                    {
                        isClear = false;
                    }
                    break;
            }

            return isClear;

        }

        //曜日を求めるメソッド
        private int Days(int year, int month, int day)
        {
            int weekday;

            if(month == 1 || month == 2)
            {
                year -= 1;
                month += 12;
                weekday = (5 * year / 4 - year / 400 + year / 400 + (26 * 13 + 16) / 10 + day) % 7;
            }  
            else
            {
                weekday = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
            }

            switch (weekday)
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
                default:
                    break;
            }
            return weekday;

        }
    }
}
