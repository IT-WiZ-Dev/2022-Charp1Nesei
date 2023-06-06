using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP086
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
            
            
            //明示的型変換
            int a2;
            double x2 = 123.456;
            a2 = (int)x2;
            Console.WriteLine(a2);
            
            
            //型変換の使用方法
            double num = (double)5 / 2;
            Console.WriteLine(num);
            
            
            double price1 = 2.5;
            int price2 = 10;
            int quantity = 4;
            double total = price1 + (double)price2 / quantity; 
            Console.WriteLine(total);
            
            
            //問題、次の数の小数部を取り出して表示
            double target = new Random().NextDouble() * 10;
            double answer = target - (int)target;
            Console.WriteLine(answer);
            
            
            //comment









            Console.Read();













        }
    }
}
