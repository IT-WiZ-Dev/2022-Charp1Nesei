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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(11);

            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(25);
            

            int c = (a + b);

            Console.WriteLine(c);
        }

    }
}