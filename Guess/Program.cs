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

            Random rand = new Random();
            int num = rand.Next(100);
            //const int num = 55;    定数ver(上の消す)
            int count = 0;

            int low = 0;
            int high = 100;

            //無限ループ
            while (true)
            {
                try
                {
                    Console.Write(low + "から" + high + "の数値を当ててください。＞");
                    
                    //入力を受け取る
                    int input = int.Parse(Console.ReadLine());

                    //入力カウントを１増やす
                    count++;

                    //正解の時の処理
                    if (num == input)
                    {
                        Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                        break;
                    }

                    //小さい数を入力したときの処理
                    if (num >= input)
                    {
                        Console.WriteLine("答はもっと大きいです。");
                        if (low<input)
                        {
                            low = input + 1;
                        }
                    }

                    //大きい数を入力したときの処理
                    if (num <= input)
                    {
                        Console.WriteLine("答はもっと小さいです。");
                        if (high > input)
                        {
                            high = input - 1;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
            }
        }
    }
}
