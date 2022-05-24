using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int rightHour = int.Parse(Console.ReadLine());
            int rightMin = int.Parse(Console.ReadLine());
            int hisHour = int.Parse(Console.ReadLine());
            int hisMin = int.Parse(Console.ReadLine());
            int m1 = rightHour * 60 + rightMin;
            int m2 = hisHour * 60 + hisMin;
            int h = 0;
            int m = 0;

            if (m1 - 30 > m2)
            {
                Console.WriteLine("Early");
                h = (m1 - m2) / 60;
                m = (m1 - m2) % 60;
                if (h >= 1)
                {
                    if (m >= 10)
                        Console.WriteLine($"{h}:{m} hours before the start");
                    else
                        Console.WriteLine($"{h}:0{m} hours before the start");
                }
                else
                    Console.WriteLine($"{m} minutes before the start");


            }
            else if (m1 - m2 <= 30 && m1 - m2 >= 0)
            {
                Console.WriteLine("On Time");
                m = m1 - m2;
                if (m != 0)
                    Console.WriteLine($"{m} minutes before the start");
            }
            else
            {
                Console.WriteLine("Late");
                h = (Math.Abs(m1 - m2)) / 60;
                m = (Math.Abs(m1 - m2)) % 60;
                if (h >= 1)
                {
                    if (m >= 10)
                        Console.WriteLine($"{h}:{m} hours after the start");
                    else  
                        Console.WriteLine($"{h}:0{m} hours after the start");
                    
                }
                else
                    Console.WriteLine($"{m} minutes after the start");

            }



        }
    }
}
