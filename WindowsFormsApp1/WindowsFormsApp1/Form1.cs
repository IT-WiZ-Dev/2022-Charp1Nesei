using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //「OK」ボタンを押したときの処理
        private void buttonOK_Click(object sender, EventArgs e)
        {   //ラベルメッセージ　表示　テキストボックス　　　　　　　文字
	        labelMessage.Text = textBoxName.Text + "さん、こんにちは。";

        }
    }
}
