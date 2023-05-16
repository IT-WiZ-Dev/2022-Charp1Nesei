using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContoroulCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // チェックボックスの値をラベルに表示
            labelCheckBox.Text
                = "チェックボックス；" + checkBox1.Checked;
            //ラジオボタン１の値を表示
            labelRadioButton1.Text
                = "ラジオボタン１；" + radioButton1.Checked;
            //ラジオボタン２の値を表示
            labelRadioButton2.Text
                = "ラジオボタン２；" + radioButton2.Checked;
            //ニューメリックアップダウンの値を表示
            labelNumericUpDown.Text
                = numericUpDown1.Value.ToString();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text
               = "チェックボックス；" + checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text
                = "ラジオボタン１；" + radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text
               = "ラジオボタン２；" + radioButton2.Checked;

        }

        private void numericUpDown1_ClientSizeChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text = numericUpDown1.Value.ToString();
        }
    }
}





