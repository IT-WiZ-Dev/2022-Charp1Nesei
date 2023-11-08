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
            const int a = 34;
            int i = 100;            
            int j =0;
            while (true)
            {                                
                Console.Write("0から"+ i + "の間の数値を当ててください。<");
                int x =int.Parse( Console.ReadLine());
                if (x > i)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }
                j = j + 1;

                
                if (x == a)
                {
                    Console.WriteLine("おめでとう。" + j + "回目で当たりました。");
                    break;
                }
                if (x > a)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    Console.WriteLine(" ");
                    i = x;
                }

                if (x < a)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    Console.WriteLine(" ");
                }
                
                
            }


        }
    }
}
