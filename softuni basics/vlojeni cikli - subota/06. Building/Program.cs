using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i > 0; i--)
            {
                Console.WriteLine();
                for (int k = 0; k < b; k++)
                {
                    if(i == a)
                        Console.Write($"L{i}{k} ");
                    else if(i%2 == 0)
                        Console.Write($"O{i}{k} ");
                    else
                        Console.Write($"A{i}{k} ");
                    
                }
            }
        }
    }
}
