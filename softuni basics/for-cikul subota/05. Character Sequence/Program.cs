using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                char l = a[i];
                Console.WriteLine(l);
            }
        }
    }
}
