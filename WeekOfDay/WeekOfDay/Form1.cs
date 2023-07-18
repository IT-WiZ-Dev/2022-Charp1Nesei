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
            label4.Text = "";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                int year = int.Parse(textBox1.Text);
                
                if(year<0)
                {
                    textBox1.Text = "西暦年エラー";
                    return;
                }
                
                bool isUruu = Uruuyear();                                               
                bool isClear = Checkdate(isUruu);                 
                
                if(isClear)
                {
                    label4.Text = Ymd();
                }
                else
                {
                    label4.Text = "ありえない日付";
                }             
                              
            }
            catch
            {
                textBox1.Text = "西暦年エラー";
            }
        }
      
        //閏年かどうか判定するメソッド
        private bool Uruuyear()
        {
            int year = int.Parse(textBox1.Text);
            bool isUruu = false;
            
            if (( year % 4 == 0 && year % 100 !=0)|| year % 400 == 0)
            {
                isUruu = true;
            }
            return isUruu;
        }

        //妥当性チェックのメソッド
        private bool Checkdate(bool isUruu)
        {   
            bool isClear = true;
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
                             
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if(day > 31)
                    {
                        isClear = false;
                    }
                    break;

                case 4:
                case 6:
                case 11:
                    if(day>30)
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
                    else if(day > 28)
                    {
                        isClear = false;
                    }
                    break;
            }
            return isClear;
        }

        //西暦年、月、日から曜日を求めるメソッド
        private string Ymd()
        {
            int year = int.Parse(textBox1.Text);
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            string dow ="";
            
            if(month==1)
            {
                year = year - 1;
                month = 13;
            }
            else if (month == 2)
            {
                year = year - 1;
                month = 14;
            }
            
            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
            
            switch (w)
            {
                case 0:
                    dow = "日曜日です";
                    break;

                case 1:
                    dow = "月曜日です";
                    break;

                case 2:
                    dow = "火曜日です";
                    break;

                case 3:
                    dow = "水曜日です";
                    break;

                case 4:
                    dow = "木曜日です";
                    break;

                case 5:
                    dow = "金曜日です";
                    break;

                case 6:
                    dow = "土曜日です";
                    break;                        
            }
            return dow;
        }
        
    }
               
}
