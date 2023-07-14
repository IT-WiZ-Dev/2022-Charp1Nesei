using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDayy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool isUruu = UruuYear();
                bool isClear = CheckDate(isUruu);

                if (isClear)
                {
                    string week = Checkweek();
                    label4.Text = week + "です";
                }
                else
                {
                    label4.Text = "あり得ない日付";
                }

            }
            catch (Exception ex)
            {
                label4.Text = "西暦年エラー";
            }

        }

        //うるう年かどうか判定するメソッド
        private bool UruuYear()
        {
            int year =  int.Parse(textBox1.Text);
            
            bool isUruu = false;

            if( (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 )     //if(a&&b)→aかつb
            {
                isUruu = true;
            }

            return isUruu;


        }

        //日付の妥当性をチェックするメソッド
        private bool CheckDate(bool isUruu)
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool isUruuYear = UruuYear();
            bool isClear = true;

            //日付が妥当じゃなかったらisClearをfalseにする処理
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if(day>31)
                    {
                        isClear = false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if(day>30)
                    {
                        isClear = false;
                    }
                    break;
                case 2:
                    
                    if (!isUruuYear && day > 28)
                    {
                        isClear = false;
                    }
                    else if (isUruuYear && day > 29)
                    {
                        isClear = false;
                    }
                    break;

            }

            return isClear;

        }

　　　　private string Checkweek()
        {
           int y = int.Parse(textBox1.Text);
           int m = (int)numericUpDown1.Value;
           int d = (int)numericUpDown2.Value;

           if (m == 1)
           {
               y = y - 1;
               m = m + 12;
           }
           else if (m == 2)
           {
               y = y - 1;
               m = m + 12;
           }



          int w = (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
          string s = "";
          switch (w)
          {
              case 0:
                  s = "日曜日";
                  break;
              case 1:
                  s = "月曜日";
                  break;
              case 2:
                  s = "火曜日";
                  break;
              case 3:
                  s = "水曜日";
                  break;
              case 4:
                  s = "木曜日";
                  break;
              case 5:
                  s = "金曜日";
                  break;
              case 6:
                  s = "土曜日";
                  break;
          }
                return s;
                
            
        }

    }
}
