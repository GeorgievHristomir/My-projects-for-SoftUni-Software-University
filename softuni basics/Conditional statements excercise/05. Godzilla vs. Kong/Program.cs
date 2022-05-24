using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double dekor = 0.1 * budget;
            double price2;
            if (statisti > 150)
                price2 = price * statisti - 0.1 * price * statisti;
            else
                price2 = price * statisti;
            if (dekor + price2 <= budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - price2-dekor:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {price2 + dekor - budget:f2} leva more.");
            }

            

        }
    }
}
