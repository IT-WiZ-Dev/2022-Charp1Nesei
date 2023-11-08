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
            int count = 0;
            int numL = 0;
            int numH = 100;
            Random rnd = new Random();
            int num = rnd.Next(0,100);
            while (true)
            {
                try
                {
                    count = count + 1;
                    Console.Write(numL + "から" + numH + "の間の数値を当ててください。＞ ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer > 100 || answer < 0) 
                    {
                        Console.WriteLine("入力値が正しくありません。再入力してください。");
                        count = count - 1;
                    }
                    else
                    {
                        if (answer == num)
                        {
                            Console.WriteLine("おめでとう。" + count + "回目で当たりました");
                            break;
                        }
                        else if (answer > num)
                        {
                            Console.WriteLine("答はもっと小さいです。");
                            numH = answer - 1;
                            ;
                        }
                        else
                        {
                            Console.WriteLine("答はもっと大きいです。");
                            numL = answer + 1;
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
