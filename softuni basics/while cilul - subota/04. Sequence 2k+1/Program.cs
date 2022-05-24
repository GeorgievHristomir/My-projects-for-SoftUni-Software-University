using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num2 = 1;
            while (num2 <= number)
            {
                Console.WriteLine(num2);
                num2 = num2 * 2 + 1;
                
                
            }
        }
    }
}
