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
            const int num = 32;
            int count=1, max = 100,min=0;
            Console.Write(min+"から"+max+"の間の数値を当ててください。>");
            int input = int.Parse(Console.ReadLine());
            while (input != num) {

                if (input > max || input < min)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.Write(min + "から" + max + "の間の数値を当ててください。>");
                    input = int.Parse(Console.ReadLine());
                }
                if (input > num)
                {

                    count++;
                    Console.WriteLine("答はもっと小さいです。");
                    Console.Write("\n");
                    max = input;
                    Console.Write(min + "から" + (max-1) + "の間の数値を当ててください。>");
                    max--;
                    input = int.Parse(Console.ReadLine());

                }
                else
                {

                    count++;
                    Console.WriteLine("答はもっと大きいです。");
                    Console.Write("\n");
                    min = input;
                    Console.Write((min+1) + "から" + max + "の間の数値を当ててください。>");
                    input = int.Parse(Console.ReadLine());
                    min++;

                }
            }
            if (input == num)
            {
                Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
            }
        }
    }
}
