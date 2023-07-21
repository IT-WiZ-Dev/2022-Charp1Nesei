using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weekofday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            week.Text = "";
        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Uruuyear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }



        private bool Errerday(int day, int month, bool Uruu)
        {

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return true;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day <= 30)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else 
            {
                if (day <= 28 || (day == 29 && Uruu == true))
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }



        }

        private void YoubiKeisan(int day, int month, int year)
        {
            int akimaru;

            if (month == 1 || month == 2)
            {
                month = month + 12;
                year = year - 1;
            }


            akimaru = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            switch(akimaru)
            {
                case 0:
                    week.Text = "日曜日";
                    break;
                case 1:
                    week.Text = "月曜日";
                    break;
                case 2:
                    week.Text = "火曜日";
                    break;
                case 3:
                    week.Text = "水曜日";
                    break;
                case 4:
                    week.Text = "木曜日";
                    break;
                case 5:
                    week.Text = "金曜日";
                    break;
                case 6:
                    week.Text = "土曜日";
                    break;
                default:
                    week.Text = "西暦年エラー";
                    break;
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            int Tosi;
            if(int.TryParse(year.Text, out Tosi) == false)
            {
                week.Text = "西暦年エラー";
            }
            if(Tosi < 0)
            {
                week.Text = "西暦年エラー";
            }

            int hi = (int)day.Value;
            int tuki = (int)month.Value;

            bool uruu = Uruuyear(Tosi);
            bool asahi = Errerday(hi, tuki, uruu);
            if( asahi == false )
            {
                week.Text = "ありえない日付";
            }

            YoubiKeisan(hi, tuki, Tosi);


        }
    }
}
