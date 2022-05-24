using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a <= 200 || a==0)
                Console.WriteLine("");
            else
                Console.WriteLine("invalid");
        }
    }
}
