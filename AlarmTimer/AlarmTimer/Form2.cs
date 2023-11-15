﻿using System;
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
    public partial class FormSet : Form
    {
        internal int alarmHour = 0;
        internal int alarmMinute = 0;
        internal int alarmSecond = 0;
        public FormSet()
        {
            InitializeComponent();
        }

        private void FormSet_Load(object sender, EventArgs e)
        {
            numericUpDownAlmHour.Value = DateTime.Now.Hour;
            numericUpDownAlmMnt.Value = DateTime.Now.Minute;
        }

        private void NumericUpDownAlm_ValueChanged(object sender, EventArgs e)
        {
            radioButtonAlarm.Checked = true;
        }

        private void NumericUpDownTim_ValueChanged(object sender, EventArgs e)
        {
            radioButtonTimer.Checked = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonAlarm.Checked == true)
            {
                alarmHour = (int)numericUpDownAlmHour.Value;
                alarmMinute = (int)numericUpDownAlmMnt.Value;
                alarmSecond = 0;
            }
            else
            {
                DateTime dtNow = DateTime.Now;
                TimeSpan addSpan =
                    new TimeSpan(0, (int)numericUpDownTimMnt.Value,
                                    (int)numericUpDownTimSec.Value);
                DateTime setTime = dtNow.Add(addSpan);
                alarmHour = setTime.Hour;
                alarmMinute = setTime.Minute;
                alarmSecond = setTime.Second;

            }
        }
    }
}
