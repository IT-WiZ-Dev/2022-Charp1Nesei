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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelYoubi.Text = "";
        }

        private void TextTovalue(string text,out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUruu = UruuYear();
            bool isClear = CheckDate(isUruu);
            int year = int.Parse(textBox1.Text);
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            days(year, month, day);

            if (year == 0 || year < 0)
            {
                labelYoubi.Text = "西暦年エラー";
            }
    
            if(isClear == false)
            {
                labelYoubi.Text = "あり得ない日付";
            } 
        }

        //うるう年かどうか判定するメソッド
        private bool UruuYear()
        {
            int year = int.Parse(textBox1.Text);

            bool isUruu = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }
            return isUruu;

        }

        //日付の妥当性を判断
        private bool CheckDate(bool isUruu)
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool isClear = true;

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
                    if ((isUruu == true && day > 29) || (isUruu == false && day > 28))
                    {
                        isClear = false;
                    }
                    break;

            }

            return isClear;
        

         }
        
        
        private int days (int year ,int month ,int day)
        {
            int weekday;
            if(month==1　|| month == 2)
            {
                year -= 1;
                month += 12;
                weekday = (5 * year / 4 - year / 400 + (26 * 13 + 16) / 10 + day) % 7;
            }
            else
            {
                weekday = (5 * year / 4 - year / 100+year/400+(26*month+16)/ 10 + day) % 7;
            }
            


            switch(weekday)
            {
                case 0:
                    labelYoubi.Text = "日曜日です。";
                    break;
                case 1:
                    labelYoubi.Text = "月曜日です。";
                    break;
                case 2:
                    labelYoubi.Text = "火曜日です。";
                    break;
                case 3:
                    labelYoubi.Text = "水曜日です。";
                    break;
                case 4:
                    labelYoubi.Text = "木曜日です。";
                    break;
                case 5:
                    labelYoubi.Text = "金曜日です。";
                    break;
                case 6:
                    labelYoubi.Text = "土曜日です。";
                    break;
                default:
                    labelYoubi.Text = "エラー";
                    break;
            }

            return weekday;

        }







    }
}