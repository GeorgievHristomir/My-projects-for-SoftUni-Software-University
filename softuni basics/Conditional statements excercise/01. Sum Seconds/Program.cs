using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int s, m;

            if (a + b + c > 120)
            {
                s = a + b + c - 120;
                m = 2;
                if (s < 10)
                    Console.WriteLine($"{m}:0{s}");
                else
                    Console.WriteLine($"{m}:{s}");
            }
            else if (a + b + c >= 60)
            {
                s = a + b + c - 60;
                m = 1;
                if (s < 10)
                    Console.WriteLine($"{m}:0{s}");
                else
                    Console.WriteLine($"{m}:{s}");
            }
            else if (a < 60)
            {
                s = a + b + c;
                m = 0;
                if (s < 10)
                    Console.WriteLine($"{m}:0{s}");
                else
                    Console.WriteLine($"{m}:{s}");
            }



        }
    }
}
