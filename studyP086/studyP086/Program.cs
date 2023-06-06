using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyP086
{
    class Program
    {
        static void Main(string[] args)
        {
            //暗黙的型変換
            int a = 10;
            double x = 3.2, y;
            y = x * a;
            Console.WriteLine(y);
            //暗示的型変換
            int a2;
            double x2 = 123.456;
            a2 = (int)x2;
            //型変換の使用方法
            double num = 5.0 / 2;
            Console.WriteLine(num);
            //次の小数点を取り出して表示
            double target =
                new Random().NextDouble() * 10;
            double answer = target - (int)target;
            Console.WriteLine(answer);

















        }
    }
}
