using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p178
{
    class Program
    {
        static void Main(string[] args)
        {
            //あたりの数の宣言
            Random r = new Random();
            int num = r.Next(1,100);
            int count = 0;
            int max = 100;
            int min = 0;

                //無限ループ
                while (true)
            {

                Console.Write(min +"から" + max + "の間の数値を当ててください>");
                //入力受け取り
                int input = int.Parse(Console.ReadLine());
                //入力されるごとに入力カウントを1ずつ増やす
                count++;

                // 正解の時
                if (input == num)
                {        
                    Console.WriteLine("おめでとう。" + count + "回目であたりました");
                    break;
                }
                //例外処理
                if (input > max || input < min)
                {
                    Console.WriteLine("入力値が正しくありません、再入力してください");
                    count--;
                }
                //数が小さいとき
                else if (input < num)
                {
                    Console.WriteLine("答はもっと大きいです");
                    min = input + 1;
                }
                //数が大きいとき
                else if (input > num)
                {
                    Console.WriteLine("答はもっと小さいです");
                    max = input - 1;
                }

                else
                {
                    Console.WriteLine("入力値が正しくありません、再入力してください");
                    count--;
                }







            }



        }
    }
}
