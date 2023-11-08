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
            int min = 0;
            int max = 100;
            int kai=0;
            Random num = new Random();
            int atr = num.Next(0, 100);
            Console.WriteLine(atr);

            for (int i=1;i<100;i++)
            {
                Console.Write(min + "から" + max + "の間の数値を当ててください。＞");
                int n = int.Parse(Console.ReadLine());
               
                if (n == atr)
                {
                    kai = i;
                    Console.WriteLine("おめでとう。" + kai + "回目で当たりました。");
                    break;
                }
                else if(n<atr)    //  入力が当たり以下
                {
                    Console.WriteLine("答はもっと大きいです。");
                    min = n + 1;
                }
                else if(n>atr)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    max = n - 1;
                }
            }
           

        }
    }
}
