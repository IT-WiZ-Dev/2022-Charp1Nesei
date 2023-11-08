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
            Console.WriteLine(" * * * 九九の表 * * *");
            Console.Write("   |");
            for(int i = 0; i<9; i++)
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            int val;
            for(int i = 1;i<=9;i++)
            {
                Console.Write(i);
                Console.Write("  |");
                
                for (int j = 1; j <= 9; j++)
                {
                    val = i * j;
                    System.Console.Write("{0,3}", val.ToString() + " ");
                }
                Console.WriteLine();
            }





            
            Console.WriteLine("終了するには何かキーを押してください。");
        }
    }
}
