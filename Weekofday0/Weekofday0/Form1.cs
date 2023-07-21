using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekofday0
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

        //うるう年かどうかを判断するメソッド
        private bool UruuYear(int year)
        {
            if ((year % 4 == 0 && (year % 100 != 0) || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //年月日の妥当性チェックを行うメソッド
        private bool CheckDate(int month, int day, bool Uruu)
        {
            //bool isClear = true;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (day <= 28 && Uruu == false)
                    {
                        return true;

                    }
                    else if (day <= 29 && Uruu == true)
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

        private void Youbidasu_Click(object sender, EventArgs e)
        {
            
        }

        private int YoubiCheck(int year, int month, int day)
        {
            int num;
            if (month == 1 || month == 2)
            {
                month += 12;
                year -= 1;

            }
            num = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            return num;
        }

        private void labelAnswer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = (int)Tuki.Value;
            int day = (int)Hi.Value;

            if (int.TryParse(textBoxTosi.Text, out int year) == false || year < 0)
            {
                labelAnswer.Text = "西暦年エラー";
            }
            else if (CheckDate(month, day, UruuYear(year)) == false)
            {
                labelAnswer.Text = "ありえない日付";
            }
            else
            {
                int date = YoubiCheck(year, month, day);
                switch (date)
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
                        break;
                }
            }

        }
    }
}
