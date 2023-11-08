using System;
using System.Collections.Generic;
using System.Globalization;
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
            Random r = new Random();
            int num = r.Next(0,100);

            int count = 0;
            int max = 100;
            int min = 0;
            
            Console.WriteLine($"{min}から{max}の間の数値を当ててください。");

            //ループ
            while (true)
            {
                //入力を受け取る
                
                string a = r.Next(min,max).ToString();
                var firstInput = a;
                
                int input;
                //9var firstInput = Console.ReadLine();

                if (int.TryParse(firstInput,out input))
                {
                    if (!(max < input || min > input))
                    {
                        //入力カウントを1増やす
                        count++;
                
                        //正解の処理
                        if (input == num)
                        {
                            Console.WriteLine($"おめでとう。{count}回目で当たりました。");
                            break;
                        }
                
                        //小さい数
                        if (num < input)
                        {
                            Console.WriteLine("答はもっと小さいです");
                            max = input-1;
                        }
                
                        //大きい時
                        if (num > input)
                        {
                            Console.WriteLine("答はもっと大きいです");
                            min = input+1;
                        }
                        Console.WriteLine($"{min}から{max}の間の数値を当ててください");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("入力値が正しくありません。再入力してください。"); 
                    }
                }
                else
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
            }
        }
    }
}
