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
            Console.WriteLine("一つ目の整数を入力してください");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("二つ目の整数を入力してください");
            int a = int.Parse(Console.ReadLine());

            int sum;

            sum = n + a;

            Console.WriteLine("入力された二つの整数の和は"+sum+"です。");
        }
    }
}
