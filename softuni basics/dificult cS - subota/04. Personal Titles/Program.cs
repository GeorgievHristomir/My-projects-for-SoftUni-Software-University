using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            if (age >= 16 && sex == 'm')
                Console.WriteLine("Mr.");
            else if (age < 16 && sex == 'm')
                Console.WriteLine("Master");
            else if (age >= 16 && sex == 'f')
                Console.WriteLine("Ms.");
            else
                Console.WriteLine("Miss");
        }
    }
}
