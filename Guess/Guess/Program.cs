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
            int l = 0;
            int h = 100;

            Console.Write("0から100の間の数値を当ててください。");

            // 無限ループ
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > h || input<l)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");
                    continue;
                }
            

                // 入力カウントを1増やす
                count++;

                // 正解のときの処理
                if (input == num)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。 ");
                    break;
                }

                // 小さい数を入力したときの処理
                else if (input > num)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    h = input - 1;
                    Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");
                }
                // 大きい数を入力したときの処理
                else 
                {
                    Console.WriteLine("答はもっと大きいです。");
                    l = input + 1;
                    Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");
                }
            }
        }
    }
}
