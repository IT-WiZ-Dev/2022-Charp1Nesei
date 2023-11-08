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
          const  int num = 55;
            int count = 0;
            int high = 100;
            int low = 0;

            //無限ループ
            while (true)
            {
                Console.WriteLine(low + "から" + high + "の間の数値を当ててください");
                int input = int.Parse(  Console.ReadLine());
                count++;         

                //正解の時
                if ( num == input)
                {
                    Console.WriteLine("おめでとう"+count+"回目で当たりました");
                    break;
                }

                if (high < input || low > input) 
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください。");

                    continue;
                }


                //小さい数を入力した時
                else if ( num < input)
                {
                    high = input - 1;
                    Console.WriteLine("答はもっと大きいです。");
                }

                //大きい数を入力した時
                 else if ( num > input)
                {
                    low = input + 1;
                    Console.WriteLine("答はもっと小さいです。");
                }


                
            }
           
        }
    }
}
