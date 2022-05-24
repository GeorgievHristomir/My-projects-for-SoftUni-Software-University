using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            double discountStudio = 0;

            switch (mounth)
            {
                case "May":
                case "October":
                    priceStudio = 50.0;
                    priceApartment = 65.0;
                    if (nights > 14)
                        discountStudio = 0.7;
                    else if (nights > 7)
                        discountStudio = 0.95;
                    else
                        discountStudio = 1.0;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.2;
                    priceApartment = 68.7;
                    if (nights > 14)
                        discountStudio = 0.8;
                    else
                        discountStudio = 1.0;
                    break;
                case "July":
                case "August":
                    priceStudio = 76.0;
                    priceApartment = 77.0;
                    discountStudio = 1.0;
                    
                    break;
                default:
                    break;

            }
            if (nights > 14)
                Console.WriteLine($"Apartment: {priceApartment * nights * 0.9:f2} lv.");
            else
                Console.WriteLine($"Apartment: {priceApartment * nights:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio * nights * discountStudio:f2} lv.");
        }
    }
}
