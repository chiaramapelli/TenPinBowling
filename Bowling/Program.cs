using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling.Logic;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            var bowlingLogic2 = new BowlingLogic2();
            

            for (int i = 0; i <= 10; i++)                                               
            {
                Console.WriteLine("Please enter the first score: ");
                int bowl1 = Convert.ToInt32(Console.ReadLine());
                int bowl2 = 0;


                if (bowl1 != 10)

                {
                    Console.WriteLine("Please enter the second score: ");
                    bowl2 = Convert.ToInt32(Console.ReadLine());
                }

                if (bowl1 == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("You've just scored a strike!");
                }

                if (bowl1 + bowl2 == 10)
                {
                    Console.WriteLine("You have scored a spare!");
                }

                bowlingLogic2.AddFrameScore(bowl1, bowl2);
                var result = bowlingLogic2.GetScore();


                Console.WriteLine("your score was " + result);
                Console.WriteLine();
            }

            var finalScore = bowlingLogic2.GetScore();
            Console.WriteLine("Game over, your result was " + finalScore);
            Console.Read();
        }
    }
}
