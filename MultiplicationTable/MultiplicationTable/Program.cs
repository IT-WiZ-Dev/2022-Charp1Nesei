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
            int ans;
            Console.WriteLine("* * * 九九の表 * * *");
            Console.Write("   ");
            for (int n = 1;n <= 9;n++)
            {
                Console.Write(" "+$"{n,3}");
            }
            Console.WriteLine();
            Console.WriteLine("ーーーーーーーーーーーーーーーーーーーーー");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    ans = i * j;
                    if (j == 1) 
                    {
                        Console.Write(i + " | " + $"{ans,3}");
                    }
                    else
                    {
                        Console.Write(" "+$"{ans,3}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
