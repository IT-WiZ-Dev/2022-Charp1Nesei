using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問１
 * 
 * 次のMain関数内で宣言されている変数のデータ型を適切なものに修正して下さい。 
 *
 * 
*/

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "Name";
            {
                value1 = (''); 
            }
            bool value2 = true;
            {
                value2 = ('');
            }
            char value3 = 'C';
            {
                value3 = ('');
            }
            double value4 = 10.5;
            {
                value4 = ('');
            }
            int value5 = 10;
            {
                value5 = ('');
            }
        }
    }
}
