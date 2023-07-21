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



        //閏年かどうか判定するメソッド
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

        private void button1_Click(object sender, EventArgs e)
        {
           



            

            TextTovalue(textBox1.Text, out int val);
            if (val < 0)
            {
                ;label4.Text = "西暦年エラー";
            }
            else
            {
                bool isUruu = UruuYear();
                if (CheakDate() == false)
                {
                    label4.Text = "ありえない日付";
                }
                else
                {
                    youbi();
                }
            }

        }

        private void TextTovalue(string text,out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }


        private bool CheakDate()
        {

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            bool isUruu = UruuYear();

            bool isClear = true;

            //日付が妥当じゃなかったら
            //isClearをfalseにする処理

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
                    if (isUruu == true )
                    {
                        if(day > 29)
                        {
                            isClear = false;
                        }
                    }
                    else
                    {
                        if(day > 28)
                        {
                            isClear = false;
                        }
                    }
                    break;


                       
                      


            }
           

            return isClear;
        }

        private void youbi ()
        {

            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;
            int year = int.Parse(textBox1.Text);

            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

 

            switch(w)
            {
                case 0:
                    label4.Text ="日曜日です";
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