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


        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            TextToValue(textBox1.Text, out int val);
            if (val < 0)
            {
                label4.Text = "西暦年エラー";
            }
            else
            {
                string Today = Week();
                label4.Text = Today;
            }
              

        }


        //うるう年
        private bool UruuYear()
        {
            int year = int.Parse(textBox1.Text);

            bool isuruu = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isuruu = true;
            }
            return isuruu;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool CheckDate()
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool isUruu = UruuYear();

            bool isClear = true;

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
            }
            return isClear;
        }


        private string Week()
        {

            int youbi;
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int year = int.Parse(textBox1.Text);
            string Tooday = null;

            if (CheckDate() == false)
            {
                return "あり得ない日付";
            }
            else
            {
                if (month < 3)
                {
                    year -= 1;
                    month += 12;
                }
                youbi = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
                
                switch (youbi)
                {

                    case 0:
                        Tooday = "日曜日";
                        break;
                    case 1:
                        Tooday = " 月曜日";
                        break;
                    case 2:
                        Tooday = "火曜日";
                        break;
                    case 3:
                        Tooday = "水曜日";
                        break;
                    case 4:
                        Tooday = "木曜日";
                        break;
                    case 5:
                        Tooday = "金曜日";
                        break;
                    case 6:
                        Tooday = "土曜日";
                        break;
                }
                return Tooday;
            }
            

        }


    }
}
