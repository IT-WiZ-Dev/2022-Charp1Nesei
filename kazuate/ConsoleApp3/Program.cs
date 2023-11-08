using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 当たりの数
            const int num = 55;
            int count = 0;
            int High = 100, Low = 0;
            //無限ループ
            while (true)
            {
                
                Console.WriteLine(Low + "から" + High + "の間の数値を当ててください。");
                int input = int.Parse(Console.ReadLine());

                if (input < Low || input > High)
                {
                    Console.WriteLine("入力値が正しくありません。やり直せィ！");
                    continue;
                }
                count++;

                //正解のとき
                if (num == input)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                    break;
                }
                else if (num < input) //不正解のとき(でかい)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    High = input - 1;
                }
                else if (num > input) //不正解のとき(ちいさい)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    Low = input + 1;
                }
                 
            }
        }
    }
}
