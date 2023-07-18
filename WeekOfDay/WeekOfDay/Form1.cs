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
        private bool UruuYear()
        { 
            int year = int.Parse(textBoxYear.Text);
            bool isUruu = false;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }
            return isUruu;

        }
        private bool Checkdate()
        {
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;
            bool isUruu = UruuYear();
            bool isClear = true;
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day>31)
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
                    if (isUruu)
                    {
                        if(day>29)
                        {
                            isClear = false;
                        }  
                    }
                    else if(day>28)
                    {
                        isClear = false;
                    }
                    break;

            }
            return isClear;

        }

        private string CalculateDate(int year,int month,int day)
        {
            string result;
            int w;
            switch (month)
            {
                case 1:
                    month = 13;
                    year = year - 1;
                    break;
                case 2:
                    month = 14;
                    year = year - 1;
                    break;
            }
            w =(5* year/ 4- year/ 100+ year / 400+(26* month + 16)/10+ day) % 7;
            switch(w)
            {
                case 0:
                    result = "日曜日です。";
                    break;
                case 1:
                    result = "月曜日です。";
                    break;
                case 2:
                    result = "火曜日です。";
                    break;
                case 3:
                    result = "水曜日です。";
                    break;
                case 4:
                    result = "木曜日です。";
                    break;
                case 5:
                    result = "金曜日です。";
                    break;
                case 6:
                    result = "土曜日です。";
                    break;
               
                default:
                    return "エラー";
            }

            return result;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                bool isClear = Checkdate();
                bool isUruu = UruuYear();
                int month = (int)numericUpDownMonth.Value;
                int day = (int)numericUpDownDay.Value;
                int year = int.Parse(textBoxYear.Text);

                if (isClear)
                {
                    labelResult.Text = CalculateDate(year, month, day);

                }
                else
                    labelResult.Text = "あり得ない日付";
            }
            catch (Exception ex)
            {
                labelResult.Text = "西暦年エラー";
            }
            
            






        }
    }
}
