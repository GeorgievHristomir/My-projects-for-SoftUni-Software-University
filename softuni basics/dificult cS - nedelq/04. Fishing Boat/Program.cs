using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            double price = 0;


            switch (season)
            {
                case "Spring":
                    if (br > 12)
                        price = 3000 * 0.75;
                    else if (br > 6)
                        price = 3000 * 0.85;
                    else if (br <= 6)
                        price = 3000 * 0.9;
                    break;
                case "Summer":
                case "Autumn":
                    if (br > 12)
                        price = 4200 * 0.75;
                    else if (br > 6)
                        price = 4200 * 0.85;
                    else if (br <= 6)
                        price = 4200 * 0.9;
                    break;
                case "Winter":
                    if (br > 12)
                        price = 2600 * 0.75;
                    else if (br > 6)
                        price = 2600 * 0.85;
                    else if (br <= 6)
                        price = 2600 * 0.9;
                    break;

            }
            if (br % 2 == 0 && season != "Autumn")
                price *= 0.95;
            if (budget >= price)
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
        }
    }
}
