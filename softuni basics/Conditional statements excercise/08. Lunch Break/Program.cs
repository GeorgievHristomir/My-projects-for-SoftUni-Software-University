using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int timeE = int.Parse(Console.ReadLine());
            int timeP = int.Parse(Console.ReadLine());
            double timeLeft = timeP - (1.0 / 8.0 * timeP + 1.0 / 4.0 * timeP);
            if (timeLeft >= timeE)
                Console.WriteLine( $"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - timeE)} minutes free time.");
            if (timeE > timeLeft)
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeE - timeLeft)} more minutes.");
        }
    }
}
