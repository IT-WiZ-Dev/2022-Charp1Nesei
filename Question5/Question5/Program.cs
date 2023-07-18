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
            // ローカル関数の定義
            void localFunc1(object o)
            {
                Console.WriteLine(o);
            }
            // ローカル関数を実行する
            localFunc1("ローカル関数[localFunc1]を呼び出す。");

            // ローカル関数の定義
            // 処理が１行(１つの式)の場合はブロック{ } を省略できる
            void localFunc2(object o) => Console.WriteLine(o);

            // ローカル関数を実行する
            localFunc2("ローカル関数[localFunc2]を呼び出す。");

            // ローカル関数の定義（戻り値のあるメソッド）
            int localFunc3(int num)
            {
                return num + 100;
            }
            localFunc2(localFunc3(10));
        }
    }
}
