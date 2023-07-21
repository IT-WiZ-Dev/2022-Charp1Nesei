using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP121
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
                int num = int.Parse(str);
                Console.WriteLine(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("数字を入力してください。");
                Console.WriteLine("入力された値　：　" + str);
            }


        }
    }
}

