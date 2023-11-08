using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int seikai = 50;
            int min = 0;
            int max = 100;
            int tou = 0;
            int kaisu = 1;
            while (seikai!=tou)
            {
                Console.Write(min + "から" + max + "の間の数値を当ててください。> ");
                tou=int.Parse(Console.ReadLine());

                if (tou>max || tou<min)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                else if (tou>seikai)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    max = tou - 1;
                    kaisu++;
                }
                else if (tou<seikai)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    min = tou + 1;
                    kaisu++;
                }
            }
            Console.WriteLine("おめでとう。" + kaisu + "回目であたりました。");


        }
    }
}
