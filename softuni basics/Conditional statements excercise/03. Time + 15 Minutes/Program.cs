using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == 23 && b >= 45)
            {
                a = a + 1 - 24;
                b = b + 15 - 60;
                if (b < 10)
                    Console.WriteLine($"{a}:0{b}");
                else
                    Console.WriteLine($"{a}:{b}");

            }
            else if (b >= 45)
            {
                b = b + 15 - 60;
                a = a + 1;
                if (b < 10)
                    Console.WriteLine($"{a}:0{b}");
                else
                    Console.WriteLine($"{a}:{b}");
            }
            else if (b < 45)
            {
                b = b + 15;
                Console.WriteLine($"{a}:{b}");
            }

        }
    }
}
