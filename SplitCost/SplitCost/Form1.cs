﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse( textBox1.Text);
            int human = int.Parse( textBox2.Text);

            int zeikomimoney = (int)(0.1 * money + money);
            int warikan = zeikomimoney / human;

            label7.Text = warikan.ToString()+"円";
            int amari = zeikomimoney % human;

            label8.Text = amari.ToString() + "円";


            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
        }
    }
}
