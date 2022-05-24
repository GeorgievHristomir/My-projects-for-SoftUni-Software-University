using System;

namespace _1._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 66)
            {
                Console.WriteLine("elder");
            }
            else if (number >= 20)
            {
                Console.WriteLine("adult");
            }
            else if (number >= 14)
            {
                Console.WriteLine("teenager");
            }
            else if (number >= 3)
            {
                Console.WriteLine("child");
            }
            else
            {
                Console.WriteLine("baby");
            }
        }
    }
}
