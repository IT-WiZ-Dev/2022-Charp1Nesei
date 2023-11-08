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
            //当たりの数
            const int num = 55;
            int count = 0;
            int koko = 0;
            int toto = 100;
            //無限ループ
            while (true)
            {
                Console.WriteLine(koko + "から" + toto + "の間の数値を当ててください");
                //入力を受け取る
                int input =int.Parse( Console.ReadLine());
                //入力カウントを1増やす
                count++;

                //正解の時の処理
                if (num == input)
                {
                    Console.WriteLine("おめでとうございます" + count + "回目で当たりました");
                    break;
                }

                //小さい数を入力した時の処理
                if (num > input)
                {
                    Console.WriteLine("答えはもっと大きいです");
                    koko = input + 1;
                }

                //大きい数を入力した時の処理
                if (num < input)
                {
                    Console.WriteLine("答えはもっと小さいです");
                    toto = input - 1;
                }


            }

        }
    }
}
