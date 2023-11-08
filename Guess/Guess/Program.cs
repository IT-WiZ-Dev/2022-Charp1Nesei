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
            int max = 100;
            int min = 0;

           
            //無限ループ
            while (true)
            {
                Console.WriteLine($"{min} から{max}の数値を当ててください。");
                //入力を受け取る
                int input =int.Parse( Console.ReadLine());
                //入力カウントを1増やす
                count++;
                //範囲外の数値が入力されたとき
                if (input < min || input > max)
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    continue;
                }
                
                //正解の時の処理
                if (input==num)
                {
                    Console.WriteLine("おめでとう。" + count+ "回目で当たりました。");
                    break;
                }

                //小さい数を入力した時の処理
                if (input < num)
                {
                    Console.WriteLine("答えはもっと大きいです。");
                   
                    min = input + 1;
                    
                }

                //大きい数を入力した時の処理
                if (input>num)
                {
                    Console.WriteLine("答えはもっと小さいです。");
                   
                    max = input - 1;
                    
                }

            }
               








        }
    }
}
