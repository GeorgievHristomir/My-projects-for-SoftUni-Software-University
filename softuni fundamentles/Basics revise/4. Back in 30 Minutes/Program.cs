using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;
            if (min >= 60)
            {
                hours += 1;
                min -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            if (min < 10)
            {
                Console.WriteLine($"{hours}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hours}:{min}");
            }



        }
    }
}
