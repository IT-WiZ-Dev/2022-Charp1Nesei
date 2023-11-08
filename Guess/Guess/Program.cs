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
            const int num = 55;     //constを付けることによって定数化
            int count = 0;
            int min = 0;
            int max = 100;
            Console.Write(min + "から" + max + "の間の数値を当ててください。＞");

            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                count++;
                if(input < min || input > max)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.Write(min + "から" + max + "の間の数値を当ててください。＞");
                    continue;
                }

                if (input > num)
                {
                    max = input - 1;
                    Console.WriteLine("答えはもっと小さいです。");
                    Console.WriteLine();
                    Console.Write(min + "から" + max + "の間の数値を当ててください。＞");
                }

                if(input < num)
                {
                    min = input + 1;
                    Console.WriteLine("答えはもっと大きいです。");
                    Console.WriteLine();
                    Console.Write(min + "から" + max + "の間の数値を当ててください。＞");
                }

                if(input == num)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
