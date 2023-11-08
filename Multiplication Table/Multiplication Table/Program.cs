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
            Console.WriteLine("   ＊＊＊九九の表＊＊＊   ");
            Console.Write("   |");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            //九九を表示

            for (int r = 1; r < 10; r++)
            {
                //(i + 1)の段を表示
                Console.Write(r+"  |");
                for (int g = 1; g < 10; g++)
                {
                    //(i + 1)の段を表示する
                    Console.Write("{0,3}", r * g);
                }
                //改行
                Console.WriteLine();
            }
        }
    }
}
