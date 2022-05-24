using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string action = string.Empty;
            while (sum < 10000)
            {
                action = Console.ReadLine();
                if (action != "Going home")
                {
                    sum += int.Parse(action);
                    
                }
                else
                {
                    action = Console.ReadLine();
                    sum += int.Parse(action);
                    break;
                }
            }
            if (sum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum - 10000} steps over the goal!");               
            }
            else
            {
                Console.WriteLine($"{10000 - sum} more steps to reach goal.");              
            }
        }
    }
}
