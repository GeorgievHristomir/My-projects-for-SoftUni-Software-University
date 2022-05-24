using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int br = 0;
            
            for (int i = a; i <= b; i++)
            {
                for (int k = a; k <= b; k++)
                {
                    br++;
                    if (k + i == c)
                    {
                        Console.WriteLine($"Combination N:{br} ({i} + {k} = {c})");
                        return;
                    }
                    
                }                                   
                
            }
            Console.WriteLine($"{br} combinations - neither equals {c}");
        }
    }
}
