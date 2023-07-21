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
           bool isUruu = IsUruu();
            bool isDateClear = DateCheck(isUruu);
            string result="曜日";


            //西暦と月と日付から曜日を計算
            int y= int.Parse(textBoxYear.Text);
            int m = (int)numericUpDownMonth.Value;
            int d = (int)numericUpDownDay.Value;
      
            
            {
               int w = (y + y / 4 - y / 100 + y / 400 + (13 * m + 8) / 5 + d) % 7;
                if (w == 0)
                    result = "日曜日";
                else if (w == 1)
                    result = "月曜日";
                else if (w == 2)
                    result = "火曜日";
                else if (w == 3)
                    result = "水曜日";
                else if (w == 4)
                    result = "木曜日";
                else if (w == 5)
                    result = "金曜日";
                else if (w == 6)
                    result = "土曜日";

                label4.Text = result;

                


                
                
                









            }
            
        }

       
       
        
     

        // 閏年かどうかの判断
        private bool IsUruu()
        {
            bool isUruu = false;

            int year = int.Parse(textBoxYear.Text);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }

            return isUruu;

        }

        //入力の妥当性を判断
        private bool DateCheck(bool isUruu)
        {
            bool isClear = true;

            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;
            





            // 日付が妥当じゃなかったら
            // isCrearをfalseにする処理
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
                case 2:
                    if (isUruu)
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
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 30)
                    {
                        isClear = false;
                    }
                    break;
                    

            }
            return isClear;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
