using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        
        //閏年判定
        private bool IsLeapYear(int year)
        {
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            return isLeapYear;
        }
        
        //妥当性チェック
        private bool ValidityCheck(bool isLeapYear,int month,int day)
        {
            bool validity = true;
            switch (isLeapYear)
            {
                case true:
                    switch (month)
                    {
                        //31///////////////////////////////
                        case 1:
                        case 3: 
                        case 5: 
                        case 7: 
                        case 8: 
                        case 10: 
                        case 12:
                            if (day > 31)
                            {
                                validity = false;
                            } 
                            break;
                        //30///////////////////////////////
                        case 4: 
                        case 6: 
                        case 9:
                        case 11:
                            if (day > 30)
                            {
                                validity = false;
                            } 
                            break;
                        //29///////////////////////////////
                        case 2:
                            if (day > 29)
                            {
                                validity = false;
                            } 
                            break;
                    }
                    break;
                case false :
                    switch (month)
                    {
                        //31///////////////////////////////
                        case 1: 
                        case 3: 
                        case 5: 
                        case 7:
                        case 8: 
                        case 10:
                        case 12:
                            if (day > 31)
                            {
                                validity = false;
                            } 
                            break;
                        //30///////////////////////////////
                        case 4: 
                        case 6: 
                        case 9:
                        case 11:
                            if (day > 30)
                            {
                                validity = false;
                            } 
                            break;
                        //28///////////////////////////////
                        case 2:
                            if (day > 28)
                            {
                                validity = false;
                            } 
                            break;
                    }
                    break;
            }
            return validity;
        }
        
        //曜日判定
        private string Seek(bool validityCheck,int year,int month,int day)
        {
            string weekOfDay = "";
            switch (month)
            {
                case 1:
                case 2:
                    year -= 1;
                    month +=12;
                    break;
            }
            switch (validityCheck)
            {
                case false:
                    weekOfDay = "日付エラー";
                    break;
                case true:
                    int weekOfNo = ((5*year/4-year/100+year/400+(26*month+16)/10+day)%7);
                    switch (weekOfNo)
                    {
                        case 0:
                            weekOfDay = "日曜 ";
                            break;
                        case 1:
                            weekOfDay = "月曜 ";
                            break;
                        case 2:
                            weekOfDay = "火曜 ";
                            break;
                        case 3:
                            weekOfDay = "水曜 ";
                            break;
                        case 4:
                            weekOfDay = "木曜 ";
                            break;
                        case 5:
                            weekOfDay = "金曜 ";
                            break;
                        case 6:
                            weekOfDay = "土曜 ";
                            break;
                    }
                    break;
            }
            return weekOfDay;
        }
        
        //ボタンクリック
        private void button1_Click(object sender, EventArgs e)
        {
            string weekOfDay;
            int.TryParse(textBoxYear.Text, out int result);
            if (result < 0 || result == 0)
            {
                weekOfDay = "西暦年エラー";
            }
            else
            {
                bool leapYear      = IsLeapYear(int.Parse(textBoxYear.Text));
                bool validityCheck = ValidityCheck(leapYear,(int)numericUpDownMonth.Value,(int)numericUpDownDay.Value);
                weekOfDay          = Seek(validityCheck,int.Parse(textBoxYear.Text),(int)numericUpDownMonth.Value,(int)numericUpDownDay.Value);
            }
            labelDayOfWeek.Text = weekOfDay;
        }
    }
}

