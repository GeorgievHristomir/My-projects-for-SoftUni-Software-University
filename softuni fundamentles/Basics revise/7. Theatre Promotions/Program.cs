using System;

namespace _7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            
            switch (day)
            {
                case "Weekday":
                    if (age > 122 || age < 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine(12 + "$");
                    }
                    else if (age > 18)
                    {
                        Console.WriteLine(18 + "$");
                    }
                    else
                    {
                        Console.WriteLine(12+"$");
                    }
                    break;
                case "Weekend":
                    if (age > 122 || age < 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine(15 + "$");
                    }
                    else if (age > 18)
                    {
                        Console.WriteLine(20 + "$");
                    }
                    else
                    {
                        Console.WriteLine(15 + "$");
                    }
                    break;
                case "Holiday":
                    if (age > 122 || age < 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else if (age > 64)
                    {
                        Console.WriteLine(10 + "$");
                    }
                    else if (age > 18)
                    {
                        Console.WriteLine(12 + "$");
                    }
                    else
                    {
                        Console.WriteLine(5 + "$");
                    }
                    break;
            }
        }
    }
}
