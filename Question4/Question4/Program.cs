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
            int[] numarr = new int[5];

            numarr[0] = 10;
            numarr[1] = 20;
            numarr[2] = 30;
            numarr[3] = 40;
            numarr[4] = 50;

            int sum2= numarr[0] + numarr[1] + numarr[2] + numarr[3] + numarr[4];
        }
    }
}
