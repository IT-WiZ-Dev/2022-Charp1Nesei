﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP177
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ＊＊＊九九の表＊＊＊ ");
            Console.Write("   |");

            for (int i = 1; i <= 9; i++)
            {
                Console.Write("  "+i);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");

            for(int i=1;i<=9;i++)
            {
                Console.Write(i+"  "+"|");

                for (int j=1;j<=9;j++)
                {
                    Console.Write("{0,3}",i*j);

                }
                Console.WriteLine();


            }



        }
    }
}
