using System;

namespace _7._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;
            while (money != "Start")
            {
                if (money == "0.1" || money == "0.2" || money == "0.5" || money == "1" || money == "2")
                {
                    sum += double.Parse(money);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                money = Console.ReadLine();
            }
            money = Console.ReadLine();
            while (money != "End")
            {
                
                switch (money)
                {
                    case "Nuts":
                        if (sum - 2 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            sum -= 2;
                            Console.WriteLine($"Purchased nuts"); 
                        }
                        break;
                    case "Water":
                        if (sum - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            sum -= 0.7;
                            Console.WriteLine($"Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (sum - 1.5 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            sum -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (sum - 0.8 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            sum -= 0.8;
                            Console.WriteLine($"Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (sum - 1.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            sum -= 1;
                            Console.WriteLine($"Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                money = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
