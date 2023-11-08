using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ＊＊＊九九の表＊＊＊  ");
            Console.Write("   |");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(" " + i +"|" );
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");

            //九九表示
            for (int i = 0; i < 9;i++)
            {
                //( i + 1 )の段の表示 例「1  |」
                Console.Write( ( i + 1 ) + " |");

                for (int j = 0; j < 9; j++)
                {
                    //( j + 1 )の段表示
                    int K = ( i + 1 ) * ( j + 1 );
                    Console.Write("{0,3}",K );
                }
                //改行
                Console.WriteLine();
            }
        }
    }
}
