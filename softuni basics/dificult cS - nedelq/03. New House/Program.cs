using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int br = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;

            switch (flower)
            {
                case "Roses":
                    if (br > 80)
                        price = 5 * br * 0.9;
                    else
                        price = 5 * br;
                    break;
                case "Dahlias":
                    if (br > 90)
                        price = 3.8 * br * 0.85;
                    else
                        price = 3.8 * br;
                    break;
                case "Tulips":
                    if (br > 80)
                        price = 2.8 * br * 0.85;
                    else
                        price = 2.8 * br;
                    break;
                case "Narcissus":
                    if (br < 120)
                        price = 3 * br * 1.15;
                    else
                        price = 3 * br;
                    break;
                case "Gladiolus":
                    if (br < 80)
                        price = 2.5 * br * 1.2;
                    else
                        price = 2.5 * br;
                    break;

            }
            if (budget >= price)
                Console.WriteLine($"Hey, you have a great garden with {br} {flower} and {budget - price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");


        }
    }
}
