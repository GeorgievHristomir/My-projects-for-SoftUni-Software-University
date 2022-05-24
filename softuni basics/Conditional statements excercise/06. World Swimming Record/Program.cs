using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double wr = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeS = double.Parse(Console.ReadLine());

            double supro = Math.Floor(meters / 15.0);
            double Ivan = meters * timeS + supro * 12.5;

            if(Ivan >= wr)
                Console.WriteLine($"No, he failed! He was {Ivan - wr:f2} seconds slower." );

            if (wr > Ivan)
                Console.WriteLine($"Yes, he succeeded! The new world record is {Ivan:f2} seconds.");
            
        }
    }
}
