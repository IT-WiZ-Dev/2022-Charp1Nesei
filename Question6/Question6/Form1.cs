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

        private void buttonCul_Click(object sender, EventArgs e)
        {
            var m = new Mony(1234986);
            var s = string.Format("10,000yen>{0},5,000yen>{1},1,000yen>{2},500yen>{3},100yen{4},50yen>{5},10yen>{6},5yen>{7},1yen>{8}",
                m.TehThousand, m.FiveThousand, m.Thousand, m.FiveHundred, m.Hundred, m.Fifty, m.Ten, m.Five, m.One);
            Console.WriteLine(s);
        }
    }
}
