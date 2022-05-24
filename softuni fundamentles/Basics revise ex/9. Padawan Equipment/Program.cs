using System;

namespace _9._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double pOfLightsabers = double.Parse(Console.ReadLine());
            double pOfRobes = double.Parse(Console.ReadLine());
            double pOfBelts = double.Parse(Console.ReadLine());
            double price;
            int disscount = students / 6;
            price = (students * pOfBelts - disscount * pOfBelts) + (students * pOfRobes ) + (Math.Ceiling(1.1 * students) * pOfLightsabers);
            if (budget - price >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {price - budget:f2}lv more.");
            }

            
        }
    }
}
