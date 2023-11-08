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
            int count = 0;

            int a = 0;
            int b = 100;
            //無限ループ
            while (true)
            {
                Console.WriteLine(a + "から" + b + "の間の数値を当ててください。");
                //入力を受け入れる
                int input = int.Parse(Console.ReadLine());
                if (input < a || input > b)
                {
                    Console.WriteLine("入力値が正しくありません");
                    continue;
                }
                //入力カウントを１増やす
                count++;
                //正解の時の処理
                if (num == input)
                {
                    Console.WriteLine("おめでとう" + count + "回目で当たりました。");
                    break;
                }
                //小さい数を入力したときの処理
                if (num < input)
                {
                    b = input - 1;

                    Console.WriteLine("答えはもっと小さい。");
                }
                //大きい数を入力したときの処理
                if (num > input)
                {
                    a = input + 1;

                    Console.WriteLine("答えはもっと大きいです。");
                }
            }


        }
    }
}
