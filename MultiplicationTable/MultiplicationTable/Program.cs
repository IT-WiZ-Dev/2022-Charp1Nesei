using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *   "   );
            Console.Write("   |");  //writeだけだと改行しない
            for (int i = 0; i < 9 ;i++) //最初のゼロまでは初期化、真ん中のセミコロンまではループの条件、最後は　？
            {
                Console.Write("  " + (i + 1));

            }
            Console.WriteLine();//改行だけ
            Console.WriteLine("--------------------------------------------");

            //九九を表示
            for (int i = 0; i < 9; i++ )
            {
                Console.Write(( i +1)+ "  |");　
                //（i＋１）の段の表示　例　「１　　｜」
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("{0,3}",(i + 1) * (j + 1)) ;
                    //（i＋１）の段の表示
                }

                //改行
                Console.WriteLine();

            }
        }
    }
}
