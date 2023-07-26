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
            labelsan.Text = "";
        }

        //うるう年判定
        private bool Urujudge()
        {
            int year = int.Parse(textBoxnen.Text);
            bool isUru = false;
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUru = true;
            }
            return isUru;
        }

        //西暦年チェック
        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        //日付があっているか判定
        private bool Checkdate(bool isUru)
        {
            int month = (int)numericUpDownTuk.Value;
            int day = (int)numericUpDownday.Value;
            isUru = Urujudge();
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
                    if (isUru)
                    {
                        if (day > 29)
                        {
                            isClear = false;
                        }
                    }
                    else if (day > 28)
                    {
                        isClear = false;
                    }
                    break;
            }
            return isClear;
        }

        //牡丹栗kkkkkkkkっく
        private void buttonkei_Click(object sender, EventArgs e)
        {
            string youbi = "";
            TextToValue(textBoxnen.Text,out int val);
            if (val < 0)
            {
                youbi = "西暦年エラー";
            }
            else
            {
                bool isUru = Urujudge();
                bool isCheckdate = Checkdate(isUru);
                int nen = int.Parse(textBoxnen.Text);
                int month = (int)numericUpDownTuk.Value;
                int day = (int)numericUpDownday.Value;
                if (isCheckdate == false)
                {
                    youbi = "ありえない日付";
                }
                else
                {

                    switch (month)
                    {
                        case 1:
                        case 2:
                            nen = nen - 1;
                            month = month + 12;
                            break;
                    }
                    int w = (5 * nen / 4 - nen / 100 + nen /
                        400 + (26 * month + 16) / 10 + day) % 7;
                    switch (w)
                    {
                        case 0:
                            youbi = "日曜日です";
                            break;
                        case 1:
                            youbi = "月曜日です";
                            break;
                        case 2:
                            youbi = "火曜日です";
                            break;
                        case 3:
                            youbi = "水曜日です";
                            break;
                        case 4:
                            youbi = "木曜日です";
                            break;
                        case 5:
                            youbi = "金曜日です";
                            break;
                        case 6:
                            youbi = "土曜日です";
                            break;
                    }
                }
            }
            labelsan.Text = youbi;




        }
    }
}
