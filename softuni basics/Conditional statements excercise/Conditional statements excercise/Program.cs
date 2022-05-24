using System;

namespace Conditional_statements_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double ex = double.Parse(Console.ReadLine());
            int puzel = int.Parse(Console.ReadLine());
            int gKukli = int.Parse(Console.ReadLine());
            int pMecheta = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int kam = int.Parse(Console.ReadLine());
            int num = puzel + gKukli + pMecheta + min + kam;
            double price = puzel * 2.60 + gKukli * 3 + pMecheta * 4.1 + min * 8.2 + kam * 2;
            if (num >= 50)
                price = price - price * 0.25;
            price = price - price * 0.1;
            if (price >= ex)
                Console.WriteLine($"Yes! {price - ex:f2} lv left.");
            else
                Console.WriteLine($"Not enough money! {ex - price:f2} lv needed.");

        }
    }
}
