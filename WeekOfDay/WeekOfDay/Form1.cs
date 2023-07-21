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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                bool isUruu = UruuYear();
                int gorira = int.Parse(textBox1.Text);
                if (gorira < 0)
                {
                    label4.Text = "整数を入力しろこのバカ";  //エラー
                }
                else
                {
                    CheckDate();
                    Week();
                }
            }
            catch (Exception ex)
            {
                label4.Text = "数字を入力しろこのバカ";
            }

        }

        //うるう年かどうか判定するメソッド
        private bool UruuYear()
        {
            int year = int.Parse(textBox1.Text);

            bool isUruu = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }

            return isUruu;
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
                    if (isUruu　== true)
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

        private void Week()
        {
            int youbi;
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int year = int.Parse(textBox1.Text);


            if (CheckDate() == false)
            {
                label4.Text = "ありえない日付";
                return;
            }

            if(month < 3 )
            {
                year -= 1;
                month += 12;
            }

            youbi = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16)/ 10 + day) % 7;
            switch (youbi)
            {
                case 0:
                    label4.Text = "日曜日";
                    break;
                case 1:
                    label4.Text = "月曜日";
                    break;
                case 2:
                    label4.Text = "火曜日";
                    break;
                case 3:
                    label4.Text = "水曜日";
                    break;
                case 4:
                    label4.Text = "木曜日";
                    break;
                case 5:
                    label4.Text = "金曜日";
                    break;
                case 6:
                    label4.Text = "土曜日";
                    break;
                case 7:
                    label4.Text = "日曜日";
                    break;
            }

        }
    }
}
