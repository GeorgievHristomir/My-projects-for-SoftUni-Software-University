using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFirst = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = pointsFirst;
            for (int i = 0; i < n; i++)
            {
                string judge = Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());
                sum += judge.Length * pointsJudge / 2;
                if (sum > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {sum:f1}!");
                    break;
                }
            }
            if (sum <= 1250.5)
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - sum:f1} more!");

        }
    }
}
