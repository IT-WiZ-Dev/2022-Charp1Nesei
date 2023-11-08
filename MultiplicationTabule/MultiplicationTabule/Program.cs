using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTabule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * * * 九九の表 * * *  ");
            Console.Write("   |");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");


            //九九を表示

            for (int i = 1; i < 10;i++)
            {
                //(i+1)の段を表示「1  |」
                Console.Write(i + "  |");
                for (int j = 1; j < 10;j++)
                {
                    //(i+1)の段を表示する
                    Console.Write("{0,3}", (i * j).ToString());

                }

                //改行
                Console.WriteLine();




            }


        }
    }
}
