using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * * * 九九の表 * * * ");
            Console.Write("   |");     //改行しないで横に出したい
            for (int i = 0; i < 9; i++)　 //ループ(0～8)
            {
                Console.Write("  " + (i + 1));
            }
            Console.WriteLine();  //改行
            Console.WriteLine("--------------------------------");
           
            //九九を表示

            for(int i = 1; i <= 9; i++)   　　//1から始めて9以下
            {
                Console.Write((i)+"  |" ); 　　
                //(i + 1)の段の表示 例「1   |」

                for (int j = 1; j <= 9; j++)
                {
                    
                    Console.Write($"{(i*j),3}");  //掛け算
                   
                    //(i + 1)の段を表示する
                }

                //改行
                Console.WriteLine();

            }
        }
    }
}