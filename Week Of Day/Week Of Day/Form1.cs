using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_Of_Day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            bool dayCehck = MonthDayCheck();
            string week = WhatWeek();

            if (dayCehck)
            {
                label.Text = week;
            }
            else
            {
                label.Text = "ありえない日付";
            }

        }

        //うるう年かどうか判定するぞ！！！メソッド
        private bool UruuYear()
        {
            {
            int year = int.Parse(textBox1.Text);

            bool isUruu = false;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
               {
                   isUruu = true;
               }
                
                return isUruu;
            }
        }

        //正しい月日が入力されたかどうか判断す
        private bool MonthDayCheck()
        {
            bool isUruu = UruuYear();
            bool dayCheck = true;
            int year = int.Parse(textBox1.Text);
            int month = numericUpDownMonth.DecimalPlaces;
            int day = numericUpDownDay.DecimalPlaces;

            //日付チェック
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
                        dayCheck = false;
                    }
                    break;
            }

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 30)
                    {
                        dayCheck = false;
                    }
                    break;
            }
            if (isUruu)
            {
                switch (month)
                {
                    case 2:
                        if (day > 29)
                        {
                            dayCheck = false;
                        }
                        break;
                }
            }
            else
            {
                switch (month)
                {
                    case 2:
                        if (day > 28)
                        {
                            dayCheck = false;
                        }
                        break;
                }
            }
            return dayCheck;
        }

        //曜日を求める
        private string WhatWeek()
        {
            string week="";
            int year = int.Parse(textBox1.Text);
            int day = (int)numericUpDownDay.Value;
            int month = (int)numericUpDownMonth.Value;
            int suu;

            switch (month)
            {
                case 1:
                case 2:
                    month += 12;
                    year -= 1;
                break;
            }

            suu = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            switch (suu)
            {
                case 0:
                    week = "日曜日";
                    break;
                case 1:
                    week = "月曜日";
                    break;
                case 2:
                    week = "火曜日";
                    break;
                case 3:
                    week = "水曜日";
                    break;
                case 4:
                    week = "木曜日";
                    break;
                case 5:
                    week = "金曜日";
                    break;
                case 6:
                    week = "土曜日";
                    break;
            }
            return week;
        }
    }
}
