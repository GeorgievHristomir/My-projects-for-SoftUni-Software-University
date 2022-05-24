using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            double sum = 0;
            int br = 1;
            int br2 = 0;
            while (br <= 12)
            {
                double mark = double.Parse(Console.ReadLine());
                
                if (mark < 4)
                {
                    if (br2 == 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {br} grade");
                        break;
                    }
                    br2++;
                    continue;
                }
                
                sum += mark;
                
                   br++;


            }
            if (br2 < 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum/(br-1):f2}");
            }
        }
    }
}
