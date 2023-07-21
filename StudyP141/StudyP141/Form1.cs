using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyP141
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox1.Text, out uint nen) == false)
            {
                label4.Text = "西暦年エラー";
            }
            else
            {
                bool isUruu = IsUruu();
                bool isDateClear = DateCheck(isUruu);
                if (isDateClear == true)
                {
                    int year = int.Parse(textBox1.Text);
                    int month = int.Parse(numericUpDown1.Text);
                    int day = int.Parse(numericUpDown2.Text);
                    Seireki(year, month, day);
                }
                else
                {
                    label4.Text = "あり得ない日付";
                }
            }

        }


        // うるう年かどうか判定するメソッド
        private bool IsUruu()
        {
            int year = int.Parse(textBox1.Text);

            bool isUruu = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return isUruu;
            }
            return isUruu;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }


        //入力の妥当性
        private bool DateCheck(bool isUruu)
        {
            bool isClear = true;

            int manth = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            switch (manth)
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

                    if ((isUruu == true && day > 29) || (isUruu == false && day > 28))
                    {
                        isClear = false;
                    }
                    break;
            }



            return isClear;

        }

    

        //西暦と月と日付から曜日を計算
        private void Seireki (int year, int month, int day)
        {
            if(month < 3)
            {
                month += 12;
                year -= 1;
            }
            int week = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            switch (week)
            {
                case 0:
                
                label4.Text = "日曜日です"; 
                break;

                case 1:
                    label4.Text = "月曜日です";
                break;

                case 2:
                    label4.Text = "火曜日です";
                break;

                case 3:
                    label4.Text = "水曜日です";
                break;

                case 4:
                    label4.Text = "木曜日です";
                break;

                case 5:
                    label4.Text = "金曜日です";
                    break;

                case 6:
                    label4.Text = "土曜日です";
                break;
            }



        }

            



    }
}
