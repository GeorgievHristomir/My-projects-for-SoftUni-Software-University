using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                sum += days * capsules * price;
                Console.WriteLine($"The price for the coffee is: ${days * capsules * price:f2}");
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
