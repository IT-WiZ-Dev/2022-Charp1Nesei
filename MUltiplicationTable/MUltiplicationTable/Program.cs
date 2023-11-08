using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUltiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("　　＊＊＊九九の表＊＊＊");
            Console.WriteLine(" |　1   2   3   4   5   6   7   8   9");
            Console.WriteLine("----------------------------------------");

            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i + "|");

                for (int j = 1; j <= 9; j++)
                {
                    int result = i * j;
                    Console.Write($"{result,3}"); // 3桁分の幅で表示

                    if (j < 9)
                    {
                        Console.Write(" "); // マスを区切る空白を追加
                    }
                }

                Console.WriteLine(); // 次の行に移行
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.ReadLine(); // プログラムを一時停止するための入力待ちを追加
        }
    }
}
