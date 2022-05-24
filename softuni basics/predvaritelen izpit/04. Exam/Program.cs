using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            double br = 0.0;
            double br1 = 0.0;
            double br2 = 0.0;
            double br3 = 0.0;
            double br4 = 0.0;
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade >= 5.00)
                {
                    br4++;
                    br++;
                }
                else if(grade >= 4.00)
                {
                    br3++;
                    br++;
                }
                else if (grade >= 3.00)
                {
                    br2++;
                    br++;
                }
                else 
                {
                    br1++;
                    br++;
                }
            }
            Console.WriteLine($"Top students: {br4/br * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {br3/br * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {br2/br * 100:f2}%");
            Console.WriteLine($"Fail: {br1/br * 100:f2}%");
            Console.WriteLine($"Average: {sum / br:f2}");
        }
    }
}
