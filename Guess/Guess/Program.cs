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
            Random myObject = new Random();
            int num = myObject.Next(100);
            int count = 0;
            int kagen = 0;
            int zyogen = 100;
            while (true)
            {
                Console.Write(kagen + "から" + zyogen + "の数字を入力して下さい。 ＞ ");
                int input = int.Parse(Console.ReadLine());
                count++;
                
                if (num == input)
                {
                    Console.WriteLine("おめでとう。" + count + "回目に当たりました。");
                    break;
                }

                if (num < input)    //答えが小さいとき
                {
                    zyogen = input - 1;
                    Console.WriteLine("答えはもっと小さいです。");
                    Console.WriteLine("");
                }
                else               //答えが大きいとき
                {
                    kagen = input + 1;
                    Console.WriteLine("答えはもっと大きいです。");
                    Console.WriteLine("");
                }
            }
        }
    }
}
