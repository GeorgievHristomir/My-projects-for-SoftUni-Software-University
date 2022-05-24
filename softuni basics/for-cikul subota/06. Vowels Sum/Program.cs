using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char l = a[i];
                if (l == 'a')
                    sum += 1;
                else if (l == 'e')
                    sum += 2;
                else if (l == 'i')
                    sum += 3;
                else if (l == 'o')
                    sum += 4;
                else if (l == 'u')
                    sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
