using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;

            if (int.TryParse(textBoxYear.Text, out int year) == false)
            {
                labelDate.Text = "西暦年エラー";
            }
            else if (year < 0)
            {
                labelDate.Text = "西暦年エラー";
            }
            else if (DateCheck(month, day, UruYear(year)) == false)
            {
                labelDate.Text = "あり得ない日付";
            }
            else
            {
                WeekOfDay(year, month, day);
            }
        }

        private bool UruYear(int num)
        {
            if((num % 4 == 0 && num % 100 != 0) || (num % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void  WeekOfDay(int year,int month, int day)
        {
            if(month == 1 || month == 2)
            {
                month += 12;
                year--;
            }

            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            switch (w)
            {
                case 0:
                    labelDate.Text = "日曜日";
                    break;
                case 1:
                    labelDate.Text = "月曜日";
                    break;
                case 2:
                    labelDate.Text = "火曜日";
                    break;
                case 3:
                    labelDate.Text = "水曜日";
                    break;
                case 4:
                    labelDate.Text = "木曜日";
                    break;
                case 5:
                    labelDate.Text = "金曜日";
                    break;
                case 6:
                    labelDate.Text = "土曜日";
                    break;
            }
        }

        private bool DateCheck(int month, int day, bool uru)
        {
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day >= 1 && day <= 31)
                        return true;
                    else
                        return false;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day >= 1 && day <= 30)
                        return true;
                    else
                        return false;
                case 2:
                    if(uru == true && day >= 1 && day <= 29)
                    {
                        return true;
                    }
                    else if(uru == false && day >= 1 && day <= 28)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelDate.Text = "";
        }
    }
}
