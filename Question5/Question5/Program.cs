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
            int num1, num2;

            Console.WriteLine("ひとつめの数字を入力してください。");
            String inputString = Console.ReadLine();

            while (inputString != "quit")
            {

                num1 = Int32.Parse(inputString);

                Console.WriteLine("ふたつめの数字を入力してください。");
                inputString = Console.ReadLine();
                num2 = Int32.Parse(inputString);

                Console.WriteLine("合計は" + (num1 + num2) + "です");

                Console.WriteLine("ひとつめの数字を入力してください。");
                inputString = Console.ReadLine();
            }
        }
        private int AddNum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
