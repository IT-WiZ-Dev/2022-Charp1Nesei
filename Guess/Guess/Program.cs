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
            //あたりの数
            const int num = 55;
            int count = 0;
            int n = 0, i = 100;
            //無限ループ
            while (true)
            {
                Console.Write (n + "から" + i + "の間の数値を当ててください。＞");
                //入力を受け取る
                int input = int.Parse(Console.ReadLine());


                //範囲外の数を入力したときの処理
                if (n < input && input > i)
                {

                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }
                
                //入力カウントを1増やす
                count++;

             
                //正解の時処理

                if (num == input)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                    Console.WriteLine();
                    return;
                }
                    //小さい数を入力したときの処理
                     
                if (num < input)
                {
                     i = input - 1;
                     Console.WriteLine("答えはもっと小さいです。");
                 }
                    //大きな数を入力したときの処理
                if (num > input)
                 {
                      n = input + 1;
                      Console.WriteLine("答えはもっと大きいです。");
                 }

                Console.WriteLine();
            }
        }
    }
}
