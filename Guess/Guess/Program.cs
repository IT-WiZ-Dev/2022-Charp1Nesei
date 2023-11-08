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
            int cnt = 0;
            int high = 100, low = 0;
            
            //無限ループ
            while (true)
            {
              
                //入力カウントを１増やす
                
               
                Console.Write(low + "から" + high + "の間の数値を当ててください。>");
                int n = int.Parse(Console.ReadLine());
                if (n > high || n < low)//範囲外の値を入力したときの処理
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");
                    
                }
                else if(n < num)//小さい値を入力したときの処理
                {
                    cnt++;
                    Console.WriteLine("答えはもっと大きいです");
                    low = n + 1;
                }
                else if(n > num)//大きい値を入力した時の処理
                {
                    cnt++;
                    Console.WriteLine("答えはもっと小さいです");
                    high = n - 1;
                }
                else //正しい値を入力したときの処理
                {
                    cnt++;
                    Console.WriteLine("おめでとう。" + cnt + "回目で当たりました。");
                    break;
                }
                
            }
        }
    }
}
