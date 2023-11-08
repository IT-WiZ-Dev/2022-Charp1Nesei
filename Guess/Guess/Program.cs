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
           
            int targetNumber =55;
            int attempts = 0;

            Console.WriteLine("0から100の間の数値を当ててください。");

            int l = 0;
            int h = 100;

            while (true)
            {
          
                string input = Console.ReadLine();
                int userNumber;

                if (int.TryParse(input, out userNumber))
                {
                    if (userNumber < l || userNumber > h)
                    {
                        Console.WriteLine("入力値が正しくありません。");
                        Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");
                        continue;
                    }

                    attempts++;

                    if (userNumber < targetNumber)
                    {
                        Console.WriteLine("もっと大きな数です。");
                        l = userNumber;
                        Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");
                    }
                    else if (userNumber > targetNumber)
                    {
                        Console.WriteLine("もっと小さな数です。");
                        h = userNumber;
                        Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");
                    }
                    else
                    {
                        Console.WriteLine($"おめでとう。{attempts}回目で当たりました！");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.WriteLine(l + "から" + h + "の間の数値を当ててください。");

                }


            }

        }
    }
}
