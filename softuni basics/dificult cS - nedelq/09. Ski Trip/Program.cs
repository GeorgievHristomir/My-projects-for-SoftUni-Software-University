using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();
            double totalPrice = 0;
            int nights = Days - 1;

            switch (room)
            {
                case "room for one person":
                    totalPrice = nights * 18.0;
                    break;
                case "apartment":
                    if (Days < 10)
                        totalPrice = nights * 25.0 - 0.3 * (nights * 25.0);
                    else if (Days >= 10 && Days <= 15)
                        totalPrice = nights * 25.0 - 0.35 * (nights * 25.0);
                    else if (Days > 15)
                        totalPrice = (nights) * 25.0 - 0.5 * (nights * 25.0);
                    break;
                case "president apartment":
                    if (Days < 10)
                        totalPrice = nights * 35.0 - 0.1 * (nights * 35.0);
                    else if (Days >= 10 && Days <= 15)
                        totalPrice = nights * 35.0 - 0.15 * (nights * 35.0);
                    else if (Days > 15)
                        totalPrice = nights * 35.0 - 0.2 * (nights * 35.0);
                    break;
                default:
                    break;
            }

            if (feedback == "positive")
                totalPrice += 0.25 * totalPrice;
            else if (feedback == "negative")
                totalPrice -= 0.1 * totalPrice;
            Console.WriteLine($"{totalPrice:f2}");




        }
    }
}
