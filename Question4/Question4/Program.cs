using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/* 問4
 * 配列arrを定義し、配列内の値を全てfor（表示）しなさい。
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
            int[] arr = { 10, 20, 30, 40, 50 };
            for (int i =0;<5;i++)
            {
                Console.WriteLine(arr[i]);
            }
            
         
        }
    }
}
