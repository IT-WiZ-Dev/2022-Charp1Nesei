using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP089
{
    class Program
    {
        static void Main(string[] args)
        {
            int    a  = 10;
            double x  = 123.456;
            string s1 = a.ToString();
            string s2 = x.ToString();
            string s3 = 789.ToString();
            string s4 = (a + 20).ToString();
            
            Console.WriteLine(
                s1 + ":" +
                s2 + ":" +
                s3 + ":" +
                s4
                );








            Console.Read();
        }
    }
}
