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
            int s;
            bool f = int.TryParse(textBox1.Text, out s);
            if (!f)
            {
                label4.Text = "西暦年エラー";
                return;
            }
            if (s == 0)
            {
                label4.Text = "西暦年エラー";
            }
            bool fy = DateCheck();
            int year = int.Parse(textBox1.Text);
            if (year < 0)
            {
                label4.Text = "西暦年エラー";
            }
            else if (fy == false)
            {
                label4.Text = "ありえない日付";
            }
            else
            {
                label4.Text = youbi("");
            }

        }
        //うるう年かどうか判定するメソッド
        private bool UruuYear()
        {
            int year = int.Parse(textBox1.Text);
            if ( (year % 4 == 0 && year % 100 != 0) || year % 400 == 0  )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //日付の妥当性をチェックするメソッド

        private bool DateCheck(bool shine=true)
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool sn=UruuYear();
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day >30)
                    {
                        shine = false;
                    }
                     break;
                case 2:
                    if (sn== true&&day >29 )
                    {
                        shine = false;
                    }
                    else if(day>28)
                    {
                        shine = false;
                    }

                     break;
                    

            }
            return shine;
                
        }
            
            //日付が妥当じゃなかったら

        private string youbi(string youbi)
        {
            int year = int.Parse(textBox1.Text);
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month+16) / 10 + day) % 7;
            if (month == 1 || month == 2)
            {
                month=month + 12;
                year=year--;
            }
            switch (w)
            {
                case 0:
                    youbi = "日曜日です。";
                    break;
                case 1:
                    youbi = "月曜日です。";
                    break;
                case 2:
                    youbi = "火曜日です。";
                    break;
                case 3:
                    youbi = "水曜日です。";
                    break;
                case 4:
                    youbi = "木曜日です。";
                    break;
                case 5:
                    youbi = "金曜日です。";
                    break;
                case 6:
                    youbi = "土曜日です。";
                    break;
            }
            return youbi;
        }





            //isCrearをfalseにする処理

          











            



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }

    
}

