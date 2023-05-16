using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" + checkbox1.Checked;
            labelRadioButton1.Text = "ラジオボタン1:" + radioButton1.Checked;
            labelRadioButton2.Text = "ラジオボタン2:" + radioButton2.Checked;
            labelNumericUpDown.Text = "数値:" + numericUpDown1.Value;
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = "チェックボックス:" +checkbox1.Checked;
        }

        private void labelCheckBox_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            labelRadioButton1.Text = "ラジオボタン1:" + radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            labelRadioButton2.Text = "ラジオボタン2:" + radioButton2.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNumericUpDown.Text = "数値:" + numericUpDown1.Value;
        }
    }
}
