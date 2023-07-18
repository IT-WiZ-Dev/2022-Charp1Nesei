using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問5
 * メソッドAddNumを定義して、メソッドMain内で呼び出しなさい。
 * メソッド定義は下記の通りにすること
 * 
 * メソッド名：AddNum
 * 戻り値の型：整数型
 * 引数列　　：整数型 num1、整数型 num2
 * 処理　　　：引数で渡されてきた2つの値を足し算した結果を戻り値として返す。
 * 
*/

namespace Question5
{
    class Program
    {
         static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int AddNum(int n1, int n2)
                {
                return n1+n2;
                }

            
            Console.WriteLine(AddNum(num1, num2));


        }
    }
}
