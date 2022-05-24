using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            double br = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            double brCards = double.Parse(Console.ReadLine());
            double brMuseum = double.Parse(Console.ReadLine());
            double sum = (nights * 20 + brCards * 1.60 + brMuseum * 6) * br;
            sum = sum * 1.25;
            Console.WriteLine($"{sum:f2}");
            


        }
    }
}
