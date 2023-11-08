﻿using System;
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
            Console.WriteLine("   ＊＊＊九九の表＊＊＊   ");
            Console.Write("   |");
            for (int i = 0; i < 9; i++) 
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine(); 　//←改行のため
            Console.WriteLine("---------------------------------");

            //九九を表示
            for (int i = 0; i<9;i++)
            {
                //(i+1)の段の表示　例「1  |」
                Console.Write((i+1) + "  |");

                for (int j = 0; j < 9 ;j++)
                {
                    //(i+1)の段を表示する
                    int n = (i + 1) * (j + 1);
                    Console.Write("{0,3}",n) ;

                }
                //改行
                Console.WriteLine();
            }

        }
    }
}
