using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =
                int.Parse(Console.ReadLine());

                num = num < 0 ? num * -1 : num;

            Console.WriteLine(num);




        }
    }
}
