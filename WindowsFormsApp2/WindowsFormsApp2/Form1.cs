﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            labelCheckBox.Text
                = "チェックボックス：" + checkBox1.Checked;
            labelNumericUpDown.Text
               = "数値：" + numericUpDown1.Value;
            labelRadioButton1.Text
               = "ラジオボタン１：" + radioButton1.Checked;
            labelRadioButton2.Text
                = "ラジオボタン２：" + radioButton2.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text
                = "数値：" + numericUpDown1.Value;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text
                = "チェックボックス：" + checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text
                = "ラジオボタン１：" + radioButton1.Checked;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text
                = "ラジオボタン２：" + radioButton2.Checked;
        }
    }
}
