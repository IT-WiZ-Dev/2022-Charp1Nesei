﻿using System;
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
            int yousosuu = new string[] { 0, 1, 2, 3, 4 } ;
            yousosuu[0] = 10;
            yousosuu[1] = 20;
            yousosuu[2] = 30;
            yousosuu[3] = 40;
            yousosuu[4] = 50;

            for (var i = 0; i < yousosuu.Length; i++)
            {
                Console.WriteLine(yousosuu[i]);
            }
        }
    }

}
    

