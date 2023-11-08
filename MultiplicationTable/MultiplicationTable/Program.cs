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
            Console.WriteLine(" ***九九の表***  ");
            Console.Write("   |");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            //九九を表示
            int a = 1;
            for (int i = 0; i < 9; i++)
            {
                // (i + 1)の段を表示　例[1 |}
                
                Console.Write(a);
                Console.Write("  |");
                
                int b = 1;

                for (int j = 0; j < 9; j++)
                {
                    
                    // (i+1) の段を表示する
                   
                    Console.Write("{0,3}",(a * b));
                    b++;
                }
                //改行
                Console.WriteLine();
                a++;

            }

        }
    }
}
