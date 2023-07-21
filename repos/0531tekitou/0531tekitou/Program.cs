using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0531tekitou
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            int num2 = 30;

            Console.WriteLine(
                "お会計は" + (num + num2) + "です。");

            //入学年下二桁
            int year = 23;
            //学科番号　情シス工31　高度41
            int classNum = 31;
            //学籍番号下4桁　個人連番　先頭は1にしております
            int myNum = 0023;

            Console.WriteLine(
                year.ToString() + classNum + myNum.ToString()

                + "が私の学生番号" +
                "番号");


        }
    }
}

