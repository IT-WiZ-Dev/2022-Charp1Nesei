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
            string Today;

            TextToValue(textBoxAtendanceM.Text, out int val);
            if (val < 0)
            {
                label4.Text = "西暦年エラー";
            }
            else
            {
                bool isUruu = UruuYear();
                bool isDateClear = CheckDate();

                if (isDateClear)
                {
                    Today = week();
                    label4.Text = Today;

                }
                else
                {

                    label4.Text = "おかしな日付です";
                }
            }
        }

        //うるう年かどうか判定するメソット
        private bool UruuYear()
        {
            int year = int.Parse(textBoxAtendanceM.Text);
            bool isUruu = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }

            return isUruu;

        }
        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        private bool CheckDate()
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool isUruu = UruuYear();

            bool isClear = true;

            //日付が妥当じゃなかったら
            //isCrearをfalseにする処理
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
                    if (isUruu == true && day > 29)
                    {
                        isClear = false;
                    }
                    else if (day > 28)
                    {
                        isClear = false;
                    }
                    break;
            }

            return isClear;
        }

            //西暦年と月、日から曜日を求める
            private string week()
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int year = int.Parse(textBoxAtendanceM.Text);

            if(month < 3 )
            {
                month += 12;
                year -= 1;
            } 
            int w =( 5*year/ 4 - year / 100+year/400+(26*month+16)/10+day ) % 7;
          
                switch (w % 7)
            {
                case 0:
                  return  "日曜日です";
                    
                case 1:
                   return  "月曜日です";
                   
                case 2:
                  return "火曜日です";
                    
                case 3:
                 return   "水曜日です";
                   
                case 4:
                   return  "木曜日です";
                  
                case 5:
                   return "金曜日です";
                   
                case 6:
                   return "土曜日です";      
            }
            return "";
        }
    }
}      

        
