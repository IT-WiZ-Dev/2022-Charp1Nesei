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
            Console.WriteLine("   * * * 九九の表 * * *");
            Console.WriteLine("   |  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("----------------------------------");

            for (int i=1; i<10; i++)
            {
                Console.Write(i+"  |");
                for(int j=1; j<10; j++)
                {
                    Console.Write($"{j*i,3}");
                }
                Console.WriteLine();

            }
        }
    }
}
