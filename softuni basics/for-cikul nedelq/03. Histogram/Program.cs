using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double br0 = 0.0;
            int br1 = 0;
            int br2 = 0;
            int br3 = 0;
            int br4 = 0;
            int br5 = 0;
            for (int i = 0; i < n; i++)
            {
                br0++;
                int number = int.Parse(Console.ReadLine());
                if (number >= 800)
                {
                    br5++;
                }
                else if (number >= 600)
                {
                    br4++;
                }
                else if (number >= 400)
                {
                    br3++;
                }
                else if (number >= 200)
                {
                    br2++;
                }
                else 
                {
                    br1++;
                }

            }
            Console.WriteLine($"{br1 / br0 * 100:f2}%");
            Console.WriteLine($"{br2 / br0 * 100:f2}%");
            Console.WriteLine($"{br3 / br0 * 100:f2}%");
            Console.WriteLine($"{br4 / br0 * 100:f2}%");
            Console.WriteLine($"{br5 / br0 * 100:f2}%");
            

        }
    }
}
