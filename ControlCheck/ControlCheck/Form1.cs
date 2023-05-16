using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LabelCheckBox_Click(object sender, EventArgs e)
        {
            
        }
        //画面が表示されたときのイベント
        private void Form1_Load(object sender, EventArgs e)
        {
            //チェックボックスの値をラベル１に表示
            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;

            //ラジオボタン１の値をラベル２に表示
            labelRadioButton1.Text = "ラジオボタン１：" + radioButton1.Checked;

            //ラジオボタン２の値をラベル３に表示
            labelRadioButton2.Text = "ラジオボタン２：" + radioButton2.Checked;

            //ニューメリックアップダウンをラベル４に表示
            labelNumericUpDown.Text = "数値：" + numericUpDown.Value;

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //チェックボックスの値をラベル１に表示
            labelCheckBox.Text = "チェックボックス：" + checkBox1.Checked;
        }


        private void RadioButton1_Click(object sender, EventArgs e)
        {
            //ラジオボタン１の値をラベル２に表示
            labelRadioButton1.Text = "ラジオボタン１：" + radioButton1.Checked;
            //ラジオボタン２の値をラベル３に表示
            labelRadioButton2.Text = "ラジオボタン２：" + radioButton2.Checked;
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            //ラジオボタン１の値をラベル２に表示
            labelRadioButton1.Text = "ラジオボタン１：" + radioButton1.Checked;
            //ラジオボタン２の値をラベル３に表示
            labelRadioButton2.Text = "ラジオボタン２：" + radioButton2.Checked;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //ニューメリックアップダウンをラベル４に表示
            labelNumericUpDown.Text = "数値：" + numericUpDown.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
