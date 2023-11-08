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
            Random num = new Random();
            int right = num.Next(0, 100);
            int count = 0;
            int max = 100;
            int min = 0;
            
            while (true)
            {
               
                Console.Write($"{min}から{max}の間の数値を当ててください。>");
                int num1 = int.Parse(Console.ReadLine());
                //範囲外の数値が入力されたとき
                if (num1 < min || num1 > max)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }
                count++;
                
                if (right==num1)
                {
                    Console.WriteLine($"おめでとう。{count}回目で当たりました。");
                    break;
                }
                //大きい数を入力したときの処理
                if (right<num1)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    max = num1 - 1;
                }
                //小さい数を入力したときの処理
                if (right > num1)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    min = num1 + 1;
                }

            }
        }
    }
}
