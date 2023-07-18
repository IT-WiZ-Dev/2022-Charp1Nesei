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

            int[] arr = new int[5] { 10, 20, 30, 40, 50, };


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}番目の要素の値は{1}です。", i + 1, arr[i]);

            }
        }
    }    
}
