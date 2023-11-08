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
            //　当たりの数
            const int num = 55;
            int count = 0;

            int min = 0;
            int max = 100;

            Console.Write(min + "から" + max + "の間の数値を当ててください。");

            //無限ループ
            while (true)
            {
                //入力を受け取る
                int input = int.Parse( Console.ReadLine());
                //入力カウントを増やす
                count++;

                if (min > input || max < input)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.Write(min + "から" + max + "の間の数値を当ててください。");
                    continue;
                }

                //正解の時の数
                if (num == input)
                {   
                    Console.WriteLine("おめでとう。" + count + "回で当たりました。");
                }
                //小さい数を入力した時の処理
                if (num > input)
                {
                    min = input + 1;
                    Console.WriteLine("答えはもっと大きいです。");
                    Console.Write(min + "から" + max + "の間の数値を当ててください。");
                }
                //大きい数を入力した時の処理
                if (num < input)
                {
                    max = input - 1;
                    Console.WriteLine("答えはもっと小さいです。");
                    Console.Write(min + "から" + max + "の間の数値を当ててください。");
                }
            }
        }
    }
}
