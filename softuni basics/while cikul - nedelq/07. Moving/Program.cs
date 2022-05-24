using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string boxes = string.Empty;
            int sum = length * width * hight;
            while (sum > 0)
            {
                boxes = Console.ReadLine();
                if (boxes == "Done")
                {
                    Console.WriteLine($"{sum} Cubic meters left.");
                    break;
                }
                sum -= int.Parse(boxes);
            }
            if (boxes != "Done")
                Console.WriteLine($"No more free space! You need {Math.Abs(sum)} Cubic meters more.");
        }
    }
}
