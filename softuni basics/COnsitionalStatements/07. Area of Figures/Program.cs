using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0  , b = 0  , r = 0 , h = 0 , S = 0  ;
            string c = Console.ReadLine();
            if (c == "square")
            {
                a = double.Parse(Console.ReadLine());
                S = a * a;
                Console.WriteLine($"{S:f3}");
            }
            else if (c == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                S = a * b;
                Console.WriteLine($"{S:f3}");

            }
            
            else if (c == "circle")
            {
                r = double.Parse(Console.ReadLine());
                S = Math.PI * Math.Pow(r, 2);
                Console.WriteLine($"{S:f3}");
            }
            else if (c == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                S = a * h / 2;
                Console.WriteLine($"{S:f3}");

            }


        }
    }
}
