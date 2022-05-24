using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int meters = int.Parse(Console.ReadLine());
            
            int days = 1;
            int sum = 5364;
            while (a != "END" && sum < 8848 && days <= 5)
            {
                
                if (a == "Yes")
                {
                    
                    days++;
                    if (days <= 5)
                        sum += meters;
                }
                else
                    sum += meters;
                if (days > 5 || sum >= 8848)
                {
                    break;
                }
                a = Console.ReadLine();
                if (a == "END")
                {
                    break;
                }
                meters = int.Parse(Console.ReadLine());
            }
            if(sum >= 8848)
                Console.WriteLine($"Goal reached for {days} days!");
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(sum);
            }
        }
    }
}
