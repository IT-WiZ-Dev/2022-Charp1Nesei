using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *   ");
            Console.Write("   |");
            for (int i = 0; i < 9;i++)
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            // 九九を表示

            int val;
            for (int i = 1; i <=9;i++)
            {
                // (i+1)の段の表示　例 「1 |」
                Console.Write(i+"  |");

                for (int j = 1; j <=9;j++)
                {
                    // (i+1)の段を表示する
                    val = i * j;
                    System.Console.Write("{0,3}", val.ToString() + " ");
                }
                System.Console.Write("\n");
            }
            Console.ReadKey();
            // 改行

        
        }
    }
}
