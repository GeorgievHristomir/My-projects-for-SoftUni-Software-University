using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum1 = 1;
            int sum2 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                for (int k = int.Parse(number[i].ToString()); k >= 1; k--)
                {
                    sum1 *= k;
                }
                sum2 += sum1;
                sum1 = 1;
            }
            if (sum2 == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
