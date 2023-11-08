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
            Console.WriteLine("　　　　　＊＊＊ 九九の表 ＊＊＊　　");
            Console.Write("   ｜");
            for (int i = 0;i < 9;i++)
            {
                Console.Write("   " + (i + 1));
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            for (int j = 0;j < 9;j++)
            {
                Console.Write((j + 1) + "  ｜");
                for (int k = 0;k < 9;k++)
                {
                    if((k + 1) * (j + 1) < 10)
                    {
                        Console.Write("   " + (k + 1) * (j + 1));
                    }
                    else
                    {
                        Console.Write("  " + (k + 1) * (j + 1));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
