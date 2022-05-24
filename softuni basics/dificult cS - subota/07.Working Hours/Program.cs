using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            switch (b)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (a >= 10 && a <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                        Console.WriteLine("closed");
                    break;

                case "Sunday":
                    Console.WriteLine("closed");
                    break;

            }
        }
    }
}
