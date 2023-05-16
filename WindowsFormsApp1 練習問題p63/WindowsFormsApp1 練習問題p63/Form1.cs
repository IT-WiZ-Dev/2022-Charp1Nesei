using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_練習問題p63
{
    public partial class コントロールの状態 : Form
    {
        public コントロールの状態()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCheckBox.Text
                = "チェックボックス:" + CheckBox1.Checked;
            labelRadioButton1.Text
                = "ラジオボタン1:" + radiobutton1.Checked;
            labelRadioButton2.Text
                = "ラジオボタン2:" + radiobutton2.Checked;
            labelnumericUpDown.Text
                 = "ニューメリックアップダウン:" + numericUpDown1.Text;
        }

        private void ニューメリックアップダウン_ValueChanged(object sender, EventArgs e)
        {
            labelnumericUpDown.Text
                 = "labelnumericUpDown:" + numericUpDown1.Text;
        }

        private void labelCheckBox_Click(object sender, EventArgs e)
        {

        }

        private void labelRadioButtin1_Click(object sender, EventArgs e)
        {

        }

        private void labelRadioButton2_Click(object sender, EventArgs e)
        {

        }

        private void labelNumericUpDown_Click(object sender, EventArgs e)
        {
            labelnumericUpDown.Text
                 = "ニューメリックアップダウン:" + numericUpDown1.Text;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" + CheckBox1.Checked;
        }

        private void radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text
                = "ラジオボタン1:" + radiobutton1.Checked;
        }

        private void labelRadioButton2_CursorChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text
                = "ラジオボタン2:" + radiobutton2.Checked;
        }

        private void radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text
                = "ラジオボタン2:" + radiobutton2.Checked;
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            labelnumericUpDown.Text
                 = "ニューメリックアップダウン:" + numericUpDown1.Text;
        }
    }
}