using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string gr = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (gr)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45 * n;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.8 * n;
                    }
                    else
                    {
                        price = 10.46 * n;
                    }
                    if (n >= 30)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Business":
                    if (n >= 100)
                    {
                        n -= 10;
                    }
                    if (day == "Friday")
                    {
                        price = 10.9 * n;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.6 * n;
                    }
                    else
                    {
                        price = 16 * n;
                    }
                    
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15 * n;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20 * n;
                    }
                    else
                    {
                        price = 22.5 * n;
                    }
                    if (n >= 10 && n <= 20)
                    {
                        price -= price * 0.05;
                    }
                    break;
                    
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
