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
            labelAnswer.Text = "";
        }

        private bool LeapYear(int year)
        {
            if((year%4 == 0 && year%100 != 0)  || year % 400 == 0)
            {
                return true;            
            }

            else
            {
                return false;
            }
        }

        private bool DayCheck(int day,int month,bool leap)
        {
            bool isDay = true;


            if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30)
                {
                    isDay = false ;
                }
            }
            else
            {
                if (day >= 30  || day == 29 && leap != true)
                {
                    isDay = false;
                }
            }
            return isDay;

        }

        private int WeekOfDayCalculation(int year,int day,int month)
        {

            if (month == 1 || month == 2)
            {
                month += 12;
                year  -= 1;
            }
            return  (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
        }

        private void ButtonCalculation_Click(object sender, EventArgs e)
        {
            int parseYear;
            int day =   (int)numericUpDownDay.Value;
            int month = (int)numericUpDownManth.Value;
            bool isYearClear = int.TryParse(textBoxYear.Text,out parseYear);
            bool isLeap   = LeapYear(parseYear);
            bool isAns    = DayCheck(day,month,isLeap);
            int weekOfDay = WeekOfDayCalculation(parseYear,day,month);

            if (parseYear < 0 || !isYearClear)
            {
                labelAnswer.Text = "西暦年エラー";
            }
            else if(!isAns) {
                labelAnswer.Text = "あり得ない日付";
            }
            else
            {
                switch (weekOfDay)
                {
                    case 0:
                        labelAnswer.Text = "日曜日";
                        break;
                    case 1:
                        labelAnswer.Text = "月曜日";
                        break;
                    case 2:
                        labelAnswer.Text = "火曜日";
                        break;
                    case 3:
                        labelAnswer.Text = "水曜日";
                        break;
                    case 4:
                        labelAnswer.Text = "木曜日";
                        break;
                    case 5:
                        labelAnswer.Text = "金曜日";
                        break;
                    case 6:
                        labelAnswer.Text = "土曜日";
                        break;
                    default:
                        labelAnswer.Text = "エラー";
                        break;
                }
            }

        }

        private void labelAnswer_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
