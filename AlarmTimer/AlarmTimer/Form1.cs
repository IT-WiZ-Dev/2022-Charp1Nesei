using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmTimer
{
    public partial class FormMain : Form
    {
        private bool alarmSetFlag = false;
        private int alarmHour = 0;
        private int alarmMinute = 0;
        private int alarmSecond = 0;


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelStatus.Text = "";
            labelDate.Text = DateTime.Today.ToString
                ("yyyy年MM月dd日(ddd)");
            labelTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");

            if (alarmSetFlag == true)
            {
                if (alarmHour == now.Hour &&
                    alarmMinute == now.Minute &&
                    alarmSecond == now.Second)
                {
                    alarmSetFlag = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelStatus.Text = "";
                }
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            FormSet formSet = new FormSet();
            if (formSet.ShowDialog() == DialogResult.OK) 
            {
                alarmSetFlag = true;
                alarmHour = formSet.alarmHour;
                alarmMinute = formSet.alarmMinute;
                alarmSecond = formSet.alarmSecond;
                labelStatus.Text = "♪" + alarmHour.ToString("00") + ":"
                                      + alarmMinute.ToString("00") + ":"
                                      + alarmSecond.ToString("00");
            }
            formSet.Dispose();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            alarmSetFlag = false;
            labelStatus.Text="";
        }
    }
}
