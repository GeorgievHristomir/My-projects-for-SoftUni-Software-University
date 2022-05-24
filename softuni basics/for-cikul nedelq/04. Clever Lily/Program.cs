using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age =  int.Parse(Console.ReadLine());
            double washingMachine =  double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int br = 0;
            double savedMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                    br++;
                else
                    savedMoney += 10 * (i/2) - 1;
            }
            savedMoney += br * priceToy;
            if (savedMoney >= washingMachine)
                Console.WriteLine($"Yes! {savedMoney - washingMachine:f2}");
            else
                Console.WriteLine($"No! {washingMachine - savedMoney:f2}");

        }
    }
}
