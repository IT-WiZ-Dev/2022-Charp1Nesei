namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxName.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        //　ラベルにテキストボックスのテキストを表示する
        {
            label2.Text = textBoxName.Text + "さん、こんにちは。";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}