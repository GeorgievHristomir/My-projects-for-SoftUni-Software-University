using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string laina = Console.ReadLine();
            double sum = 0.0;
            while (laina != "NoMoreMoney")
            {
                if (double.Parse(laina) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += double.Parse(laina);
                Console.WriteLine($"Increase: {double.Parse(laina):f2}");
                laina = Console.ReadLine();

            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
