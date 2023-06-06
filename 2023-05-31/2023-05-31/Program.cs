using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_05_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 30;

            Console.WriteLine(
                "お会計は"+ (num1 + num2) +"です"
                );

            //入学年
            int year = 23;
            //学科番号
            int classNum = 41;
            //学籍番号
            int myNumber = 74;
            
            Console.WriteLine(
                year.ToString() + classNum + myNumber.ToString("D4") + "が学籍番号"　//D4=４桁の書式設定
                );



            Console.ReadLine();
        }
    }
}
