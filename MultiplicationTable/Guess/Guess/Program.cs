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
            Console.Write("0から100の間の数値を当ててください。>　");
            //無限ループ
            int a = 1;
            int b = 100;
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                //入力カウントを1増やす
                count++;
              

                //正解の時の処理
                if (num == input)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました");
                    return;
                }

                if (input < a ^ input > b)
                {
                    Console.WriteLine("範囲外です。再入力してください");

                    
                }
                else if (num > input)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    //小さい数を入力した時の処理
                }
                else if (num < input)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    //大きい数を入力したときの処理
                }
                Console.Write("0から100の間の数値を当ててください。>　");
            }
        }
    }
}
