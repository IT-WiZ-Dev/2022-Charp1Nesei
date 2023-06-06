using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace StudyModulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 25;
            int numMod =  3;
            //変数numを変数numModで割った余り
            Console.WriteLine(num % numMod);
            
            //今日から千日後は何曜日か？
            Console.WriteLine(1000 % 7);
            
            //偶数かどうか
            Console.WriteLine(2023 % 2);

            //倍数
            Console.WriteLine(10204280 % 7);

            //数字の一桁目を取り出す
            Console.WriteLine(29 % 10);
            
            //オリンピックが開催される年を判断する処理
            int year = 2020;
            Console.WriteLine(year % 4);
            
            //自分の学籍番号から学科番号を取り出す
            int number = 23410074;
            Console.WriteLine(
                (number /= 10000 ) % 100
                );
            
            
            
            Console.Read();








        }
    }
}
