using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int brTournaments = int.Parse(Console.ReadLine());
            int pointsBegin = int.Parse(Console.ReadLine());
            int pointsEnd = pointsBegin;
            double br = 0.0;
            for (int i = 0; i < brTournaments; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        pointsEnd += 2000;
                        br++;
                        break;
                    case "F":
                        pointsEnd += 1200;                       
                        break;
                    case "SF":
                        pointsEnd += 720;                       
                        break;
                }
                
            }
            Console.WriteLine($"Final points: {pointsEnd}");
            Console.WriteLine($"Average points: {(pointsEnd - pointsBegin) / brTournaments}");
            Console.WriteLine($"{br / brTournaments * 100:f2}%");

        }
    }
}
