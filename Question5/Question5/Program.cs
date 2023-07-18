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

            int a,b;
            a =  int.Parse  (Console.ReadLine());
            b =  int.Parse  (Console.ReadLine());
            int ret= AddNum(a, b); 
            
        }
        static int AddNum (int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            return sum ;

        }
    }
}
