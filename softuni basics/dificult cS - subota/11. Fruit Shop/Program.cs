using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string Day = Console.ReadLine();
            double kol = double.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            if (Day == "Monday" || Day == "Tuesday" || Day == "Wednesday" || Day == "Thursday" || Day == "Friday")

            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.5;
                        break;
                    case "apple":
                        price = 1.2;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.7;
                        break;
                    case "pineapple":
                        price = 5.5;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;


                }

            }
            else if (Day == "Saturday" || Day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.7;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.9;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.0;
                        break;
                    case "pineapple":
                        price = 5.6;
                        break;
                    case "grapes":
                        price = 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;


                }
            }
            else
                Console.WriteLine("error");
            totalPrice = price * kol;
            if (totalPrice != 0)
            Console.WriteLine($"{price * kol:f2}");
        }
    }
}
