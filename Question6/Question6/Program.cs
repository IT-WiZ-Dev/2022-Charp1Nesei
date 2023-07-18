using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            int yen, b10k, b5k, b1k, c500, c100, c50, c10, c5, c1;
            ("%d", &ampyen);
            scanf("%d", &ampyen);
            b10k = yen / 10000;
            yen = yen % 10000;
            b5k = yen / 5000;
            yen = yen % 5000;
            b1k = yen / 1000;
            yen = yen % 1000;
            c500 = yen / 500;
            yen = yen % 500;
            c100 = yen / 100;
            yen = yen % 100;
            c50 = yen / 50;
            yen = yen % 50;
            c10 = yen / 10;
            yen = yen % 10;
            c5 = yen / 5;
            c1 = yen % 5;
           printf ("10000円札は%d枚\n", b10k);
            printf(" 5000円札は%d枚\n", b5k);
            printf(" 1000円札は%d枚\n", b1k);
            printf("  500円玉は%d枚\n", c500);
            printf("  100円玉は%d枚\n", c100);
            printf("   50円玉は%d枚\n", c50);
            printf("   10円玉は%d枚\n", c10);
            printf("    5円玉は%d枚\n", c5);
            printf("    1円玉は%d枚\n", c1);
            return 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
