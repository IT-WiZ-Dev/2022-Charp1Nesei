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
            Console.WriteLine("  * * * 九九の表 * * *  ");
            Console.Write("  |");
            for (int i = 1; i <= 9;i++)
            {
                Console.Write("  " + i);
            }
            Console.Write("\n");
            Console.WriteLine("-------------------------------");
            int seki = 0;
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i + " |");
                for (int j = 1; j <= 9; j++)
                {
                    seki = i * j;
                    Console.Write("{0,3}",seki);                                                                                                                                                                                           
                }
                Console.WriteLine();
            }
        }
    }
}
