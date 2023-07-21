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

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            if (int.TryParse(textBox1.Text, out int year) == false)
            {
                label4.Text = "西暦年エラー";
            }

            if (year < 0)
            {
                label4.Text = "西暦年エラー";
            }


            else if (DetaCheck(month, day, LeapYearJudge(year)) == false)
            {
                 label4.Text = "ありえない日付";

            }
            else
            {
                WeekOfDay(year, month, day);
            }


           
        }

        //うるう年かどうか LeapYear=うるう年 &&=かつ(and)　||=または(or)
        private bool LeapYearJudge(int num)  //bool型の場合is～を使う
        {
 

            if ((num % 4 == 0 && num % 100 != 0) || num % 400 == 0)
            {
                return  true;
            }

            return false;
        }

        private bool DetaCheck(int month, int day, bool uru) //年月日の妥当性チェック
        {
            if ( (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 ) && day >= 1 && day <= 31)
            {
                return true;
            }
            else if ( (month == 4 || month == 6 || month == 9 || month == 11 )&& day >= 1 && day <= 30)
            {
                return true;
            }
            else if( (month == 2 && uru == true) && day <= 29)
            {
                return true;
            }

            else if ((month == 2 && uru == false) && day <= 28)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void WeekOfDay(int year, int month, int day)//曜日チェック
        {
            if(month == 1 || month == 2)
            {
                month += 12;
                year--;
            }

            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

      
            switch (w)//label4に曜日
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