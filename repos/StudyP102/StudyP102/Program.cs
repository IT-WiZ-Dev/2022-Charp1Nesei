using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP102
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            string result = "odd";

            if(score % 2 ==0 )
            {
                result = "even";
            }


            Console.WriteLine(result);



            if(score >=0)
            {
                Console.WriteLine("正の数");
            }
            else
            {
                Console.WriteLine("負の数");
            }


            


             if (score % 2 == 0)
            {
                Console.WriteLine("2の倍数");
            }
            else if( score % 3 == 0)
            {
                Console.WriteLine("3の倍数");
            }
            else if( score % 5 ==0)
            {
                Console.WriteLine("5の倍数");
            }
            else if( score % 7 == 0)
            {
                Console.WriteLine("7倍数の数");
            }
            else
            {
                Console.WriteLine("素数");
            }






        }
    }
}
