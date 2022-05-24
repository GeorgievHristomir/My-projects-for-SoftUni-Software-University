using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double price = N * 250 + 0.35 * N * 250 * M + 0.1 * N * 250 * P;
            
            if (N > M)
                price = price - price * 0.15;
            if (budjet < price)
                Console.WriteLine($"Not enough money! You need {price - budjet:f2} leva more!");
            if (price <= budjet)
                Console.WriteLine($"You have {budjet - price:f2} leva left!");
        }
    }
}
