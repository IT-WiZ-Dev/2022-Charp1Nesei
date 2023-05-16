using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Clabel1.Text = "チェックボックス：" + checkBox1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Rlabel1.Text = "ラジオボタン１：" + radioButton1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clabel1.Text = "チェックボックス：" + checkBox1.Checked;
            Rlabel1.Text = "ラジオボタン１：" + radioButton1.Checked;
            Rlabel2.Text = "ラジオボタン２：" + radioButton2.Checked;
            Newlabel1.Text = "数値：" + numericUpDown1.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Rlabel2.Text = "ラジオボタン２：" + radioButton2.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Newlabel1.Text = "数値：" + numericUpDown1.Value;
        }
    }
}
