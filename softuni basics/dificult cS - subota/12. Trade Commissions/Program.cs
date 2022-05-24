using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double percentige = 0;
            switch(city)
            {
                case "Sofia":
                    if (s > 10000)
                        percentige += 0.12;
                    else if (s > 1000)
                        percentige += 0.08;
                    else if (s > 500)
                        percentige += 0.07;
                    else if (s >= 0)
                        percentige += 0.05;
                    else
                        Console.WriteLine("error");
                    break;
                case "Varna":
                    if (s > 10000)
                        percentige += 0.13;
                    else if (s > 1000)
                        percentige += 0.10;
                    else if (s > 500)
                        percentige += 0.075;
                    else if (s >= 0)
                        percentige += 0.045;
                    else
                        Console.WriteLine("error");
                    break;
                case "Plovdiv":
                    if (s > 10000)
                        percentige += 0.145;
                    else if (s > 1000)
                        percentige += 0.12;
                    else if (s > 500)
                        percentige += 0.08;
                    else if (s >= 0)
                        percentige += 0.055;
                    else
                        Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            if (s>=0 && percentige != 0)
            Console.WriteLine($"{s *  percentige:f2}");
            
                
        }
    }
}
