using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            string taken = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int width= int.Parse(Console.ReadLine());
            int br = length * width;
            int sum = 0;
            while (br > 0)
            {
                taken = Console.ReadLine();
                if (taken == "STOP")
                {
                    Console.WriteLine($"{br} pieces are left.");
                    break;
                }
                else
                {
                    sum += int.Parse(taken);
                    br -= int.Parse(taken);
                }
                
            }
            if (taken != "STOP")
            {

                Console.WriteLine($"No more cake left! You need {Math.Abs(br)} pieces more.");
            }
        }
    }
}
