using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問4
 * 配列arrを定義し、配列内の値を全てfor文のループの中で出力（表示）しなさい。
 * 配列arrは整数型の配列、要素数は『5』、添え字0～4にはそれぞれ
 * 『10』『20』『30』『40』『50』
 * の値を格納しなさい。
*/


namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            //配列の宣言
            int[] arr;
            arr = new int[5];
            int num; //添字
            
            
            for(num = 0; num < 5; num++)
            {

                //代入のループ文
                for(int i = 0; i <= num; i++ )
                {
                    
                    arr[num] += 10;

                }

                //出力
                Console.WriteLine(arr[num]);

            }
        }
    }
}
