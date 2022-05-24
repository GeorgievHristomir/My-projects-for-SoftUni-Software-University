using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            int help = 1;
            Console.WriteLine(help);
            for (int i = 1; i < n; i++)
            {
                help += 2;
                Console.WriteLine(help);
                sum += help;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
