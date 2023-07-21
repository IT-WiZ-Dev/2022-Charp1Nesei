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

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckDayweek();

            bool isUruu =UruuYear();

            bool isClear =Checkdate(isUruu);

            if (isClear == false)
            {
                label4.Text = "あり得ない日付";
            }

        }

        private bool UruuYear()
        {

            uint year;

            if (uint.TryParse(textBox1.Text, out year) == false)
            {
                label4.Text = "西暦年エラー";
            }
            
            bool isUruu = false;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                isUruu = true;
            }

            return isUruu;

        }

        private bool Checkdate(bool isUruu)
        {
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            
            bool isClear = true;
            bool uru =isUruu;

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
                    if ((uru == false && day > 28) || (uru == true && day > 29))
                    {
                        isClear = false;
                    }
                    break;
            }

            return isClear;

        }

        // y = year,   m = month,  d = day
        private void CheckDayweek()
        {
            uint y;

            if (uint.TryParse(textBox1.Text, out y) == false)
            {
                label4.Text = "西暦年エラー";
            }
            
            uint m = (uint)numericUpDown1.Value;
            uint d = (uint)numericUpDown2.Value;
            uint w;
            
            if (m == 1)
            {
                m = 13;
                y -= 1;
            }
            if (m == 2)
            {
                m = 14;
                y -= 1;
            }
            w = (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;

            switch (w)
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