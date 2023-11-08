using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *   ");
            Console.Write("   |");
            for (int i = 0; i < 9; i++) 
            {
                Console.Write("  " + (i+1));
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            // 九九を表示
            for (int i = 0; i < 9; i++) 
            {
                // (i+1)の段の表示　例「1  |」
                Console.Write((i+1) + "  | ");
                for (int j = 0; j < 9; j++)
                {
                    // (i+1)の段を表示する
                    Console.Write("{0,3}", (j + 1) * (i + 1)) ;
                }
                Console.WriteLine(); // 段変え　改行のためのWriteLine
            }
            
        }
    }
}
