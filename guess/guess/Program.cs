﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 55;
            int count = 0;
            int num1 = 0;
            int num2 = 100;
            //無限ループ
            while (true)
            {
                Console.WriteLine(num1 + "から" + num2 + "の間の数値を当ててください");
                //入力を受け取る
                int input = int.Parse(Console.ReadLine());
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
                    num1 = input + 1;
                }

                //大きい数を入力した時の処理
                if (num < input)
                {
                    Console.WriteLine("答えはもっと小さいです");
                    num2 = input - 1;
                }
            }
        }
    }
}
