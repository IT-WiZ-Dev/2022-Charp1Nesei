using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP111
{
    class Program
    {
        static void Main(string[] args)
        {
            string human = "";

          human +=SelfIntro("田中", 18, true);
          human +=SelfIntro("鈴木", 20, false);
          human +=SelfIntro("佐藤", 29, true);

            Console.WriteLine("自己紹介した人は" + human);

            int kazu;
            kazu = Plus(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
                 
        }
        static string SelfIntro(string name, int age, bool isMale)
        {
            Console.WriteLine($"私は{name}ですぅ");
            Console.WriteLine($"年齢は{age}ですぅ");
            Console.WriteLine("性別は" + (isMale ? "男性ですぅ" : "女性ですぅ"));

            return "名前:" + name + "年齢" + age;

        }


     //整数型の引数を2つ受け取り
     //それらを足し算した結果を返すメソッド
     //メソッド名は「Plus」
     //Mainメソッド内で呼び出して戻り値が
     //正しい足し算の結果になっているか表示して確認

        static int Plus(int A, int B)
        {
            return A + B;
        }

        static double (double d1, double d2)
        {
            return n1 + n2;
        }
Console

        int num = Plus(2. 3);
        Console.WriteLine(num);

        double numd = PlusDouble(1.5. 2.2);
        Console.WriteLine(numd);

















    }
}
