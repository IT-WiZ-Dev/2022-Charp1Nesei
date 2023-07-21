using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.Write("整数値＞");
            n = int.Parse(Console.ReadLine());
            while (n > 0) //入力した値が０より大きければ繰り返す
            {
                sum += n;
                Console.Write("整数値>");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"合計値は{sum}です。");

        }
    }
}
