using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;

            switch(type)
            {
                case "Premiere":
                    price = c * r * 12.0;
                    break;
                case "Normal":
                    price = r * c * 7.5;
                    break;
                case "Discount":
                    price = c * r * 5.0;
                    break;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
