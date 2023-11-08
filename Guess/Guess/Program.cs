
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
            //当たりの数
            const int num = 55;
            int cnt = 0;
            int n = 0;
            int h = 100, l = 0;
            do
            {
                Console.Write(l + "から" + h + "の間の数値を当ててください。 > ");
                n = int.Parse(Console.ReadLine());

                if (n > h || n < l)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                else if (n > num)
                {
                    cnt++;
                    Console.WriteLine("答えはもっと小さいです。");
                    h = n - 1;
                }
                else if (n < num)
                {
                    cnt++;
                    Console.WriteLine("答えはもっと大きいです。");
                    l = n + 1;
                }
                else
                {
                    cnt++;
                    Console.WriteLine("おめでとう。" + cnt + "回目で当たりました。");
                }
                Console.WriteLine();
            } while (n != num);
        }
    }
}
