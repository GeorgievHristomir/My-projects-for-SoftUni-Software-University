using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            int br1 = 0;
            int br2 = 0;
            int br3 = 0;
            int br4 = 0;
            int br5 = 0;
            for (int i = 0; i < n; i++)
            {
                
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number >= 41)
                    br5 += number;
                else if (number >= 26)
                    br4 += number;
                else if (number >= 13)
                    br3 += number;
                else if (number >= 6)
                    br2 += number;
                else
                    br1 += number;
            }
            Console.WriteLine($"{br1 / sum * 100:f2}%");
            Console.WriteLine($"{br2 / sum * 100:f2}%");
            Console.WriteLine($"{br3 / sum * 100:f2}%");
            Console.WriteLine($"{br4 / sum * 100:f2}%");
            Console.WriteLine($"{br5 / sum * 100:f2}%");
        }
    }
}
