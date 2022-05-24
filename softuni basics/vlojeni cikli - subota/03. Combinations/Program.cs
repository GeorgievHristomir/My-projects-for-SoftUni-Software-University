using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                for (int k = 0; k <= a; k++)
                {
                    for (int c = 0; c <= a; c++)
                    {
                        if (i + k + c == a)
                            br++;
                    }
                }
            }
            Console.WriteLine(br); ;
        }
    }
}
