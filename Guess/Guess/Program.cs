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
            Random rnd = new Random();   //const int num =55;だと答えを55だと設定できる
            int num = rnd.Next(0,100);
            int count = 0;
            int max = 100;
            int min = 0;
            
            
            //無限ループ

            while (true)
            {
                count++;
                Console.Write(min + "から" + max + "の間で数値を当ててください。＞");
                
                try
                {
                   int input = int.Parse(Console.ReadLine());
                
               
                    if (input > 100 || input < 0)
                    {
                        Console.WriteLine("入力値が正しくありません。再入力してください。");
                        count = count - 1;
                    }

                    //正解の時の処理
                    else
                    {
                        if (num == input)
                        {
                            Console.WriteLine("おめでとう。" + count++ + "回目で当たりました。");
                            break;
                        }
                        //不正解の時の処理　小さい時
                        if (num <= input)
                        {
                            max = input - 1;
                            Console.WriteLine("答えはもっと小さいです。");
                        }
                        //不正解の時の処理　大きい時
                        if (num >= input)
                        {
                            min = input + 1;
                            Console.WriteLine("答えはもっと大きいです。");
                        }
                    }
                }

                catch
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    count = count - 1;
                }

            }

        }
    }
}
