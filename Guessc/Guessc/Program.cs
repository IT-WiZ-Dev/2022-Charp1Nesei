using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessc
{
    class Program
    {
        static void Main(string[] args)
        {
            // 当たりの数
            const int num = 32;
            int count = 0;
            int n = 0, i = 100;
            // 無限ループ
            while (true)
            {
                Console.Write(n + "から" + i + "の間の数値を当てようねえ～。>");
                // 入力を受け取る
                int input = int.Parse(Console.ReadLine());

                // 範囲外の数を入力した時の処理
                if(n < input && input > i)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }

                // 入力カウントを１増やす
                count++;

                // 正解の時
                if (num == input)
                {
                    Console.WriteLine("おめでとう。やっと" + count + "回目で当たりましたね～");
                    return;
                }

                // 小さい数を入力した時の処理
                if (num < input)
                {
                    i = input - 1;
                    Console.WriteLine("答えはもっと大きいです。");
                }

                // 大きい数を入力した時の処理
                if (num > input)
                {
                    n = input + 1;
                    Console.WriteLine("答えはもっと小さいです。");
                }

                Console.WriteLine();
            }
        }
    }
}
