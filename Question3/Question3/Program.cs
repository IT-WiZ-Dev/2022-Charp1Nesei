using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問3
 * ２つの整数の入力（コンソールからの入力）を受け取り、
 * 足し算した結果を出力（表示）するプログラムを書きなさい。
 * 
 * 入力例：
 * 11
 * 25
 * 
 * 出力例：
 * 36
 * 
*/


namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {

                int x, y;

                Console.WriteLine("ひとつめの数字を入力してください。");
                String inputString = Console.ReadLine();

                while (inputString != "quit")
                {

                    x = Int32.Parse(inputString);

                    Console.WriteLine("ふたつめの数字を入力してください。");
                    inputString = Console.ReadLine();
                    y = Int32.Parse(inputString);

                    Console.WriteLine("合計は" + (x + y) + "です");

                    Console.WriteLine("ひとつめの数字を入力してください。");
                    inputString = Console.ReadLine();
                 }
            }
        }
    }

