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

        // ロード時のイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            // 曜日のクリア
            labelWeek.Text = "";
        }

        // ボタンクリック時のイベントハンドラ
        private void buttonGetWeek_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(textBoxYear.Text, out year) != true || year < 0)
            {
                labelWeek.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDown2.Value;
            int day = (int)numericUpDown1.Value;

            if (checkDate(year, month, day) == false)
            {
                labelWeek.Text = "あり得ない日付";
                return;
            }
            int week = weekOfDay(year, month, day);

            switch (week)
            {
                case 0:
                    labelWeek.Text = "日曜日です";
                    break;
                case 1:
                    labelWeek.Text = "月曜日です";
                    break;
                case 2:
                    labelWeek.Text = "火曜日です";
                    break;
                case 3:
                    labelWeek.Text = "水曜日です";
                    break;
                case 4:
                    labelWeek.Text = "木曜日です";
                    break;
                case 5:
                    labelWeek.Text = "金曜日です";
                    break;
                case 6:
                    labelWeek.Text = "土曜日です";
                    break;
                default:
                    labelWeek.Text = "算出エラーです";
                    break;
            }
        }

        // 曜日を求める
        //（仮引数）y:西暦年　m:月　d:日　
        //（返却値）曜日 0=日 1=月 2=火 3=水 4=木 5=金 6=土
        private int weekOfDay(int y, int m, int d)
        {
            if (m == 1 || m == 2)
            {
                y--;
                m += 12;
            }

            return (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
        }

        // 年月日の妥当性チェック
        //（引数） y:西暦年　m:月　d:日
        //（戻り値）true=妥当性OK　false=妥当性NG　
        private bool checkDate(int y, int m, int d)
        {
            bool rc = true;

            if (m < 1 || m > 12 || d < 1)
                rc = false;
            else if (m == 1 || m == 3 || m == 5 || m == 7 ||
                m == 8 || m == 10 || m == 12)
            {
                if (d > 31)
                    rc = false;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d > 30)
                    rc = false;
            }
            else
            {
                if (isLeapYear(y) == true)
                {
                    if (d > 29)
                        rc = false;
                }
                else
                {
                    if (d > 28)
                        rc = false;
                }
            }

            return rc;
        }

        // 閏年の判定
        //（引数） y:西暦年
        //（戻り値）true=閏年　false=閏年以外
        private bool isLeapYear(int y)
        {
            bool rc = false;

            if (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0))
            {
                rc = true;
            }

            return rc;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void lastweek_Click(object sender, EventArgs e)
        {

        }
    }
}
