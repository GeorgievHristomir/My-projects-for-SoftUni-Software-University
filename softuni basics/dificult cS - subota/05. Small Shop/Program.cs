using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double kol = double.Parse(Console.ReadLine());
            if (city == "Sofia" && product == "coffee")
            {
                Console.WriteLine(0.5 * kol);
            }
            else if (city == "Sofia" && product == "water")
            {
                Console.WriteLine(0.8 * kol);
            }
            else if (city == "Sofia" && product == "beer")
            {
                Console.WriteLine(1.2 * kol);
            }
            else if (city == "Sofia" && product == "sweets")
            {
                Console.WriteLine(1.45 * kol);
            }
            else if (city == "Sofia" && product == "peanuts")
            {
                Console.WriteLine(1.6 * kol);
            }
            else if (city == "Plovdiv" && product == "coffee")
            {
                Console.WriteLine(0.4 * kol);
            }
            else if (city == "Plovdiv" && product == "water")
            {
                Console.WriteLine(0.7 * kol);
            }
            else if (city == "Plovdiv" && product == "beer")
            {
                Console.WriteLine(1.15 * kol);
            }
            else if (city == "Plovdiv" && product == "sweets")
            {
                Console.WriteLine(1.3 * kol);
            }
            else if (city == "Plovdiv" && product == "peanuts")
            {
                Console.WriteLine(1.5 * kol);
            }
            else if (city == "Varna" && product == "coffee")
            {
                Console.WriteLine(0.45 * kol);

            }
            else if (city == "Varna" && product == "water")
            {
                Console.WriteLine(0.7 * kol);

            }
            else if (city == "Varna" && product == "beer")
            {
                Console.WriteLine(1.1 * kol);


            }
            else if (city == "Varna" && product == "sweets")
            {
                Console.WriteLine(1.35 * kol);

            }
            else if (city == "Varna" && product == "peanuts")
            {
                Console.WriteLine(1.55 * kol);

            }
        }
    }
}
