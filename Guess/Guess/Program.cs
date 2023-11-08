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
            // 当たりの数
            const int num = 55;
            int count = 0;
            int a = 0;
            int b = 100;
            Console.Write(a + "から" + b + "の間の数値を当ててください。 > ");
            // 無限ループ
            while (true)
            {
                // 入力を受け取る
                int input = int.Parse(Console.ReadLine());
                // 入力カウントを1増やす
                count++;

                // 正解の時の処理
                if (input == num)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                    break;
                }


                // 小さい数を入力した時の処理
                else if (input < num && input >= a)
                {
                    a = ++input;
                    Console.WriteLine("答はもっと大きいです。");
                    Console.WriteLine();
                    Console.Write(a + "から" + b + "の間の数値を当ててください。 > ");
                }

                // 大きい数を入力した時の処理
                else if (input > num && input <= b)
                {
                    b = --input;
                    Console.WriteLine("答はもっと小さいです。");
                    Console.WriteLine();
                    Console.Write(a + "から" + b + "の間の数値を当ててください。 > ");
                }

                else if (input < a || input > b)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    --count;
                }

            }
        }
    }
}
