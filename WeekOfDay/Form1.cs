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
            if (uint.TryParse(textBox1.Text, out uint year) == false)
            {
                label4.Text = "西暦年エラー";
            }
            else
            {
                bool isUruu = UruuYear();
                bool isDateCrear = CheckDate(isUruu);
                label4.Text = WhatWeek(isDateCrear,year);
            }
        }

        private bool UruuYear()    //閏年かどうか判定するメソッド
        {
            int year = int.Parse(textBox1.Text);
            bool isUruu =false;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }
            else
            {
                isUruu = false;
            }
            return isUruu;
        }

        private bool CheckDate(bool isUruu)
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            bool isClear = true;     //日付が妥当じゃなかったらfalseにする処理をする
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
                        isClear = false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if(day > 30)
                        isClear = false;
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

        private string WhatWeek(bool CheckDate,uint year)
        {
            uint month = uint.Parse(numericUpDown1.Text);
            uint day = uint.Parse(numericUpDown2.Text);
            
            if(CheckDate == false)
            {
                return "有り得ない日付";
            }
            
            uint week = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
           switch(week)
            {
                case 0:
                    return "日曜日";
                    break;
                case 1:
                     return "月曜日";
                    break;
                case 2:
                    return "火曜日";
                    break;
                case 3:
                    return "水曜日";
                    break;
                case 4:
                    return "木曜日";
                    break;
                case 5:
                    return "金曜日";
                    break;
                case 6:
                    return "土曜日";
                    break;
                default:
                    return "どうやってこのメッセージを表示した";
            }
        }
    }
}
