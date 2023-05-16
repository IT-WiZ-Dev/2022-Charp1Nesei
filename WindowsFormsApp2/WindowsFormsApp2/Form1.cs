using System;
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
            //チェックボックスの値をラベル1に表示
            labelCheckBox.Text
                = "チェックボックス:" + checkBox1.Checked;
            labelRadioButton.Text = "ラジオボタン" + radioButton1.Checked;
            labelRadioButton2.Text = "ラジオボタン" + radioButton2.Checked;
            


            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text
                = "チェックボックス:" + checkBox1.Checked;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton.Text 
                = "ラジオボタン" + radioButton1.Checked;

        }
    }
}
