using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year1;
            bool isYearRight = int.TryParse(textBox1.Text, out year1);
            if (!isYearRight)
            {
                label4.Text = "西暦年エラー";
                return;
            }
            if (year1 == 0)
            {
                label4.Text = "西暦年エラー";
            }
            int year = int.Parse(textBox1.Text);
            bool sine = datou();
            if (year<=0||year==0)
            {
                label4.Text = "西暦年エラー";
            }
            else if(sine==true){
                label4.Text = "ありえない日付";

            }
            else
            {
                label4.Text = month("");
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool Uru()
        {
            int year = int.Parse(textBox1.Text);
            bool isUru = false;
            if ((year % 4 == 0) && (year % 100 != 0) || year % 400 == 0)
            {
                isUru = true;

            }
            return isUru;
        }

        private string month(string youbi)
        {
            int year = int.Parse(textBox1.Text);
            int month = (int)numericUpDown2.Value;
            int day = (int)numericUpDown1.Value;
            if (month <= 2)
            {
                month=month+12;
                year = year - 1;
            }
            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
            switch (w)
            {
                case 0:
                    youbi = "日曜日";
                    break;
                case 1:
                    youbi = "月曜日";
                    break;
                case 2:
                    youbi = "火曜日";
                    break;
                case 3:
                    youbi = "水曜日";
                    break;
                case 4:
                    youbi = "木曜日";
                    break;
                case 5:
                    youbi = "金曜日";
                    break;
                case 6:
                    youbi = "土曜日";
                    break;
                default:
                    break;
            }
            return youbi + "です。";


        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        private bool datou(bool shine=false)
        {
            int month = (int)numericUpDown2.Value;
            int day = (int)numericUpDown1.Value;
            bool sinu = Uru();
            switch(month)
            {
                case 4:
                    if (day > 30)
                    {
                        shine = true;
                    }
                    break;
                case 6:
                    if (day > 30)
                    {
                        shine = true;
                    }
                    break;
                case 9:
                    if (day > 30)
                    {
                        shine = true;
                    }
                    break;
                case 11:
                    if(day>30){
                        shine = true;
                    }
                    break;
                case 2:
                    if (sinu==true&&day>29)
                    {
                        shine = true;
                    }
                    else if(sinu==false&&day>28){
                        shine = true;
                    }
                    return shine;
            }

            return shine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
