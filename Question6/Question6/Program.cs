using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    static class Program
    {
        private static Label textBoxChange;
        private static Label label5000yen;
        private static Label label1000yen;
        private static Label label500yen;
        private static Label label100yen;
        private static Label label50yen;
        private static Label label10yen;
        private static Label label5yen;
        private static Label label1yen;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void buttonCul_Click(object sender, EventArgs e)

        {

            int charge = int.Parse(textBoxChange.Text);

            int[] yen = { 5000, 1000, 500, 100, 50, 10, 5, 1 };

            Label[] labels = { label5000yen, label1000yen, label500yen, label100yen, label50yen, label10yen, label5yen, label1yen };

            for (int i = 0; i < yen.Length; i++)

            {

                int count = charge / yen[i];

                charge %= yen[i];

                labels[i].Text = count.ToString();

            }

        }
    }
}
