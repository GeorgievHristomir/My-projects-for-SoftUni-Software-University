using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int brDays = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double kgFoodPerDay1 = double.Parse(Console.ReadLine());
            double kgFoodPerDay2 = double.Parse(Console.ReadLine());
            double kgFoodPerDay3 = double.Parse(Console.ReadLine());
            double sum = kgFoodPerDay1 * brDays + kgFoodPerDay2 * brDays + kgFoodPerDay3 * brDays;
            if (sum > kgFood)
            {
                Console.WriteLine($"{Math.Ceiling(sum - kgFood)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(kgFood - sum)} kilos of food left.");
            }
        }
    }
}
