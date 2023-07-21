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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelDay.Text = "";
        }

        //閏年かどうか判定するゴリラ
        /*🍌が４で割り切れるかつ１００で割り切れないか、
        または４００で割り切れると閏年って判定します。ウホホ。*/
        private bool UruuGorira()
        {
            int year;
            TextToValue(textBoxYear.Text, out year);
            bool isUruu = false;
            if ((year % 4 == 0 && year % 100 != 0 ) || (year % 400 == 0))
                isUruu = true;
            else
                isUruu = false;

            return isUruu;
        }

        //西暦年を判断
        private void TextToValue(string text, out int val)
        {
            if(int.TryParse(text, out  val) == false)
                val = -1;
        }

        //日付チェックのメソッド
        private bool CheakDate()
        {
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;
            bool isUruu = UruuGorira();

            bool isClear = true;

            //日付判定
            switch(month)
            {
                case 1:
                    if(day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 2:
                    if (isUruu == true)
                    {
                        if (day > 29)
                        {
                            isClear = false;
                        }
                    }
                    else
                    {
                        if (day > 28)
                        {
                            isClear = false;
                        }
                    }
                    break;
                case 3:
                    if (day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 4:
                    if (day > 30)
                    {
                        isClear = false;
                    }
                    break;
                case 5:
                    if (day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 6:
                    if (day > 30)
                    {
                        isClear = false;
                    }
                    break;
                case 7:
                    if (day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 8:
                    if (day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 9:
                    if (day > 30)
                    {
                        isClear = false;
                    }
                    break;
                case 10:
                    if (day > 31)
                    {
                        isClear = false;
                    }
                    break;
                case 11:
                    if (day > 30)
                    {
                        isClear = false;
                    }
                    break;
                case 12:
                    if (day > 31)
                    {
                        isClear = false;
                    }
                    break;
            }

            //日付が妥当じゃなかったらisClearをfalseにする
            return isClear;
        }

        //曜日を求めるメソッド
        private string FamilyMart()
        {
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;
            int Year;
            TextToValue(textBoxYear.Text, out Year);
            string sevenday = null;  //曜日を代入する返却値
            int hantei;

            if (Year < 0)
            {
                return "西暦年エラー";
            }



            else if(month < 3)
            {
                month += 12;
                Year -= 1;
            }

            bool daynull = CheakDate(); //日付が正しいか判定
            if (daynull == false)
            {
                return "あり得ない日付";
            }

            hantei = (5 * Year / 4 - Year / 100 + Year / 400 + (26 * month + 16) / 10 + day) % 7;
            switch (hantei)
            {
                case 0:
                    sevenday = "日曜日";
                    break;
                case 1:
                    sevenday = "月曜日";
                    break;
                case 2:
                    sevenday = "火曜日";
                    break;
                case 3:
                    sevenday = "水曜日";
                    break;
                case 4:
                    sevenday = "木曜日";
                    break;
                case 5:
                    sevenday = "金曜日";
                    break;
                case 6:
                    sevenday = "土曜日";
                    break;
            }
            sevenday += "です";
            return sevenday;

        }

        //曜日算出ボタンクリック
        private void buttonYoubi_Click(object sender, EventArgs e)
        {
            string Today;

            bool daynull = CheakDate(); //日付が正しいか判定

            Today = FamilyMart();

            labelDay.Text = Today;



        }
    }
}
