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
            for (int[] arr = new int[] { 10, 20, 30, 40, 50 };
            for (var i = 0; i < arr.Length; i++)
            {
                arr[0] = 10;
                arr[1] = 20;
                arr[2] = 30;
                arr[3] = 40;
                arr[4] = 50;

                    Console.WriteLine(arr[0]);
                    Console.WriteLine(arr[1]);
                    Console.WriteLine(arr[2]);
                    Console.WriteLine(arr[3]);
                    Console.WriteLine(arr[4]);

                }
             

        }
    }
}
