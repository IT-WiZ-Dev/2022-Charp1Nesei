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
            bool isUruu = UruuYear();
            bool isCheck = Check(isUruu);



            int year;

            if(int.TryParse(textBox1.Text, out year) == false)
            {
                label1.Text = "西暦年エラー";
            }    
            if(year < 0)
            {
                label1.Text = "西暦年エラー";
            }

            Weekofday();

        }

        // うるう年かどうか判定するメソッド
        private bool UruuYear()
        {
            int year = int.Parse(textBox1.Text);

            bool isUruu = false;

            if ((year % 4 == 0) && (year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }
            return isUruu;
        }

        private bool Check(bool isCheck)
        {
            int month = (int)numericUpDown1.Value;
            int val = (int)numericUpDown2.Value;
            bool day = false;
            switch (month)
            {
                case 1:
                    if(val <= 31)
                    {
                        day = true;
                    }
                    break;
                case 2:
                    if(isCheck = true)
                        if(val >= 29)
                        {
                            day = true;
                        }
                    else
                            if(val >= 28)
                        {
                            day = true;
                        }
                    break;
                case 3:
                    if(val <= 31)
                    {
                        day = true;
                    }
                    break;
                case 4:
                    if (val <= 30)
                    {
                        day = true;
                    }
                    break;
                case 5:
                    if (val <= 31)
                    {
                        day = true;
                    }
                    break;
                case 6:
                    if (val <= 30)
                    {
                        day = true;
                    }
                    break;
                case 7:
                    if (val <= 31)
                    {
                        day = true;
                    }
                    break;
                case 8:
                    if (val <= 31)
                    {
                        day = true;
                    }
                    break;
                case 9:
                    if (val <= 30)
                    {
                        day = true;
                    }
                    break;
                case 10:
                    if (val <= 31)
                    {
                        day = true;
                    }
                    break;
                case 11:
                    if (val <= 30)
                    {
                        day = true;
                    }
                    break;
                case 12:
                    if (val <= 31)
                    {
                        day = true;
                    }
                    break;
                default:
                        label1.Text = "あり得ない日付";
                    break;
            }
            return day;

        }

        private void Weekofday()
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int year = int.Parse(textBox1.Text);
            if (month == 1 || month == 2)
            {
                month += 12;
                year -= 1;
            }
                int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
            

            switch (w)
            {
                case 0:
                    label1.Text = "日曜日です";
                    break;
                case 1:
                    label1.Text = "月曜日です";
                    break;
                case 2:
                    label1.Text = "火曜日です";
                    break;
                case 3:
                    label1.Text = "水曜日です";
                    break;
                case 4:
                    label1.Text = "木曜日です";
                    break;
                case 5:
                    label1.Text = "金曜日です";
                    break;
                case 6:
                    label1.Text = "土曜日です";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
