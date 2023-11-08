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
            int count = 0;//何回で当たったか
            Console.Write("0から100の間の数値を当ててください。＞");
            // 無限ループ
            while (true)
            {
                //入力を受け取る
                int input = int.Parse(Console.ReadLine());
                //入力カウントを１増やす
                count++;

             
                int min = 0;
                int max = 100;

                
                //正解の時の処理
                if(input == num) 
                {
                    Console.WriteLine("おめでとう。"+ count + "回目で当たりました。");
                    break;
                }
                if (input < min || input > max)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    Console.WriteLine(min + "から" + max + "の数値を当ててください。＞");
                    continue;
                }
                //小さい数を入力した時の処理
                if (input < num)
                {
                    min = input+1;
                    Console.WriteLine("答はもっと大きいです。");
                    Console.Write(min +"から" + max+ "の間の数値を当ててください。＞");
                }
                //大きい数を入力したときの処理
                if (input > num)
                {
                    max = input-1;
                    Console.WriteLine("答はもっと小さいです。");
                    Console.Write(min +"から"+ max + "の間の数値を当ててください。＞");
    
                }
                
            }
        }
    }
}
