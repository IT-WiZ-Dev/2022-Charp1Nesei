using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFULWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int num = int.Parse(line1.Split(' ')[0]);
            int min = int.Parse(line1.Split(' ')[1]);
            int max = int.Parse(line1.Split(' ')[2]);
            string line2 = Console.ReadLine();
            int target = 0; // 入力された数
            int counter = 0; // 範囲内の個数

            for (int i = 0; i < 5 ; i++ )
            {
                target = int.Parse(line2.Split(' ')[i]);
                if (target >= min && target <= max)
                {
                    counter++;
                }
                }
     
            Console.WriteLine(counter);
        }
    }
}
        
