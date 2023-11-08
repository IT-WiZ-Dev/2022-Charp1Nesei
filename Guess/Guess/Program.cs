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
            int max = 100, min = 0, num,count = 0,n;
            num = 55;

            while (true)
            {
                Console.Write(min+"から"+max+"の間の数値を当ててください。　＞　");
                n = int.Parse(Console.ReadLine());

                if (n > max || n < min)
                {                   
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }

                else if (num < n)
                {
                    count++;
                    Console.WriteLine("答えはもっと小さいです");
                    max = n - 1;
                }

                else if(num > n)
                {
                    count++;
                    Console.WriteLine("答えはもっと大きいです");
                    min = n + 1;
                }

                else
                {
                    count++;
                    Console.WriteLine("おめでとう。"+count+"回目で当たりました。");
                    break;
                }
            }
        }
    }
}
