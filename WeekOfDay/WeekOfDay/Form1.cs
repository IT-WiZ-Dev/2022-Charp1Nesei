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
    public partial class FormYoubi : Form
    {
        int tsuki = 1;
        int hi = 1;
        int toshi;
        bool isUru;
        bool isformat;
        int youbi;
        public FormYoubi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormYoubi_Load(object sender, EventArgs e)
        {
            labelYoubi.Text = "";
        }


        private void buttonSanshutsu_Click(object sender, EventArgs e)
        {
            try{
                Urudoshi();
                FormatCheck();
                hi = int.Parse(numericHi.Text);
                YoubiSanshutsu();
            }
            catch (Exception ex)
            {
                labelYoubi.Text = "西暦年エラー";
            }
           
        }


        private bool Urudoshi()
        {
            toshi = int.Parse(textBoxToshi.Text);
            isUru = false;
            if ((toshi % 4 == 0 && toshi % 100 != 0) || toshi % 400 == 0)  // != ← NOT＝   || ← OR
            {
                isUru = true;
            }

            return isUru;
        }
        private bool FormatCheck()
        {
            isformat = true;
            tsuki = int.Parse(numericTsuki.Text);
            hi = int.Parse(numericHi.Text);
            switch (tsuki)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if ((isUru == true && hi > 28) || hi > 31)
                    {
                        isformat = false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if ((isUru == true && hi > 28) || hi > 30)
                    {
                        isformat = false;
                    }
                    break;
                case 2:
                    if (isUru == true && hi > 29)
                    {
                        isformat = false;
                    }
                    else if (isUru == false && hi > 28)
                    {
                        isformat = false;
                    }
                    break;

            }
            return isformat;
        }
        private void YoubiSanshutsu() //算出するところから
        {
            switch (tsuki)
            {
                case 1:
                    toshi -= 1;
                    youbi = (5 * toshi / 4 - toshi / 100 + toshi / 400 + (26 * 13 + 16) / 10 + hi) % 7;
                    break;
                case 2:
                    toshi -= 1;
                    youbi = (5 * toshi / 4 - toshi / 100 + toshi / 400 + (26 * 14 + 16) / 10 + hi) % 7;
                    break;
                default:
                    youbi = (5 * toshi / 4 - toshi / 100 + toshi / 400 + (26 * tsuki + 16) / 10 + hi) % 7;
                    break;
            } 

            if (isformat == true)
            {

                switch (youbi)
                {
                    case 0:
                        labelYoubi.Text = "日曜日です";
                        break;
                    case 1:
                        labelYoubi.Text = "月曜日です";
                        break;
                    case 2:
                        labelYoubi.Text = "火曜日です";
                        break;
                    case 3:
                        labelYoubi.Text = "水曜日です";
                        break;
                    case 4:
                        labelYoubi.Text = "木曜日です";
                        break;
                    case 5:
                        labelYoubi.Text = "金曜日です";
                        break;
                    case 6:
                        labelYoubi.Text = "土曜日です";
                        break;
                }
                
                if (toshi < 0)
                {
                    labelYoubi.Text = "西暦年エラー";
                }
            }
            else
            {
                labelYoubi.Text = "あり得ない日付";
            }
        }


    }
}
