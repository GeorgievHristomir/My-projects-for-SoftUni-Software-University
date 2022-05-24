using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b;
            if (a <= 100)
            {
                b = 5;
            }
            else if (a <= 1000)
            {
                b = 0.2 * a;

            }
            else
                b = 0.1 * a;
            if (a % 2 == 0)
                b = b + 1;
            if (a % 10 == 5)
                b = b + 2;
            Console.WriteLine(b);
            Console.WriteLine(a + b);
            
        }
    }
}
