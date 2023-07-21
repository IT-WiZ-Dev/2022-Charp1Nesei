using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP145_
{
    class Program
    {
        static void Main(string[] args)
        {
            //入力　人⇒CPUi
            string input = Console.ReadLine();

            //出力　CPU⇒人
            Console.WriteLine("あなたの入力" + input);　//改行
            Console.Write("あなたの入力"); //改行なし
            Console.Write(input);

            //表示のさせ方(表示指定子)
            Console.WriteLine($"{1000:C}");
            Console.WriteLine($"{250:X}");
            Console.WriteLine($"{2500000:N}");
            Console.WriteLine($"{123.45678:F}");
            Console.WriteLine($"{2.0 / 3.0:P}");

        }
    }
}
