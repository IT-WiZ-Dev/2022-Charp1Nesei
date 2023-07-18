using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            try { 
            
                int money = int.Parse(textBoxChange.Text);
            
                int change = 0;
                int c5000 = 0;
                int c1000 = 0;
                int c500 = 0;
                int c100 = 0;
                int c50 = 0;
                int c10 = 0;
                int c5 = 0;

                if (money >= 5000)
                {
                    c5000 = money / 5000;
                    change = money % 5000;

                    c1000 = change / 1000;
                    change = change % 1000;

                    c500 = change / 500;
                    change = change % 500;

                    c100 = change / 100;
                    change = change % 100;

                    c50 = change / 50;
                    change = change % 50;

                    c10 = change / 10;
                    change = change % 10;

                    c5 = change / 5;
                    change = change % 5;
                }
                else if (money < 5000 && money >= 1000)
                {
                    c1000 = money / 1000;
                    change = money % 1000;

                    c500 = change / 500;
                    change = change % 500;

                    c100 = change / 100;
                    change = change % 100;

                    c50 = change / 50;
                    change = change % 50;

                    c10 = change / 10;
                    change = change % 10;

                    c5 = change / 5;
                    change = change % 5;
                }

                else if (money < 1000 && money >= 500)
                {
                    c500 = money / 500;
                    change = money % 500;

                    c100 = change / 100;
                    change = change % 100;

                    c50 = change / 50;
                    change = change % 50;

                    c10 = change / 10;
                    change = change % 10;

                    c5 = change / 5;
                    change = change % 5;
                }
                else if (money < 500 && money >= 100)
                {
                    c100 = money / 100;
                    change = money % 100;

                    c50 = change / 50;
                    change = change % 50;

                    c10 = change / 10;
                    change = change % 10;
                    c5 = change / 5;
                    change = change % 5;



                }
                else if (money < 100 && money >= 50)
                {

                    c50 = money / 50;
                    change = money % 50;

                    c10 = change / 10;
                    change = change % 10;

                    c5 = change / 5;
                    change = change % 5;
                }
                else if (money < 50 && money >= 10)
                {
                    c10 = money / 10;
                    change = money % 10;

                    c5 = change / 5;
                    change = change % 5;
                }
                else if (money < 10 && money >= 5)
                {
                    c10 = money / 10;
                    change = money % 10;

                    c5 = change / 5;
                    change = change % 5;
                }
                else
                {
                    change = money;
                }
                label5000yen.Text = Convert.ToString(c5000);
                label1000yen.Text = Convert.ToString(c1000);
                label500yen.Text = Convert.ToString(c500);
                label100yen.Text = Convert.ToString(c100);
                label50yen.Text = Convert.ToString(c50);
                label10yen.Text = Convert.ToString(c10);
                label5yen.Text = Convert.ToString(c5);
                label1yen.Text = Convert.ToString(change);

        }
            catch(Exception ex)
            {

            }

}

        
    }
}
