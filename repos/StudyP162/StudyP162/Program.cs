using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyP162
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string input = "Start";

            int stageCard; //場のカード
            int playCard; //めくれたカード

            while ( true )
            {
                stageCard = r.Next(1,14);

                Console.WriteLine("[high] or [low] or " + "[pass] or []");
                input = Console.ReadLine();

                switch (input)
                {
                    case "low":
                        playCard = r.Next(1,14);
                        if (stageCard >= playCard)
                        {
                            Console.WriteLine($"勝利です。");
                        }
                        else
                        {
                            Console.WriteLine($"敗北です。");
                        }
                        break;
                    default:
                        if( input == "end")
                        {
                            Console.WriteLine("ゲーム終了");
                            break;
                        }
                        else
                        { 
                        Console.WriteLine("パス");
　　　　　　　　　　　　continue;
　　　　　　　　　　　  }
                        break;
            }
        }
    }
}
