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
            int max = 100;
            int min = 0;

            Console.Write((min)+"から"+(max)+"の間の数値を当ててください。>");

            //あたりの数
            const int num = 32;
            int count = 0;
            

            //無限ループ
            while (true)
            {
                //入力をうけとる
                int input = int.Parse(Console.ReadLine());
                //入力カウントを一増やす
                count++;
                //正解の時の処理
                if (input == num)
                {
                    Console.WriteLine("おめでとう。" + (count) + "回目で当たりました。");
                    break;
                }
                //小さい数を入力したときの処理
                if (max < input || min >input)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.Write((min) + "から" + (max) + "の間の数値を当ててください。>");
                    count--;
                }
                else if (input > num)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    Console.WriteLine();
                    max = --input;
                    Console.Write((min) + "から" + (max) + "の間の数値を当ててください。>");              
                }
                //大きい数を入力したときの処理
                else if (input < num)
                {
                    Console.WriteLine("答はもっと大きいです");
                    Console.WriteLine();
                    min = ++input;
                    Console.Write((min) + "から" + (max) + "の間の数値を当ててください。>");
                }
            }


        }
    }
}
